using Microsoft.AspNetCore.Mvc;
using Api.Services;
using System.ComponentModel.DataAnnotations;
using Share.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{   
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    
    public class SpiskiNaDNFromMOController : ControllerBase
    {
        private readonly ISpiskiNaDNFromMOService _spiskiNaDnFromMoService;
        
        public SpiskiNaDNFromMOController(ISpiskiNaDNFromMOService spiskiNaDnFromMoService)
        {
            _spiskiNaDnFromMoService = spiskiNaDnFromMoService;
        }
        [HttpGet("byUploadFileId/{uploadFileId}")]
        public async Task<IActionResult> GetByUploadFileId(int uploadFileId)
        {
            var result = await _spiskiNaDnFromMoService.GetByUploadFileIdAsync(uploadFileId);
            return Ok(result);
        }
        [HttpGet("GetFiles")]
        public async Task<ActionResult<IEnumerable<FileDTOView>>> GetAllFiles()
        {
            var files = await _spiskiNaDnFromMoService.GetFileInfoAsync();
            return Ok(files);
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Файл не выбран.");

            var userId = 1; 
            var fileName = file.FileName;
            var filePath = Path.Combine("UploadedFiles", fileName);
            var fullFilePath = Path.Combine(Directory.GetCurrentDirectory(), filePath);

            Directory.CreateDirectory(Path.GetDirectoryName(fullFilePath) ?? string.Empty);

            using (var fileStream = new FileStream(fullFilePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            int uploadFileId = 0;

            try
            {
                // Валидация файла
                using (var validationStream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read))
                {
                    var errors = await _spiskiNaDnFromMoService.ValidateFileAsync(validationStream);
                    if (errors.Any())
                        return BadRequest(new { message = "Файл содержит ошибки.", errors });
                }

                // Запись информации о загруженном файле
                var uploadFileInfoDTO = new UploadFileInfoDTO
                {
                    UserId = userId,
                    FileName = fileName,
                    FilePath = fullFilePath,
                    UploadDate = DateTime.Now,
                    UploadStatus = false
                };

                uploadFileId = await _spiskiNaDnFromMoService.RecordUploadFileInfoAndReturnIdAsync(uploadFileInfoDTO);

                // Обработка файла
                using (var processingStream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read))
                {
                    await _spiskiNaDnFromMoService.ProcessFileRowsToStagingAsync(processingStream, uploadFileId);
                }

                // Обновление статуса файла
                await _spiskiNaDnFromMoService.UpdateUploadFileStatusAsync(uploadFileId, true);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { message = "Файл содержит ошибки.", errors = ex.Message });
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException?.Message ?? "Нет внутреннего исключения.";
                return StatusCode(500, new
                {
                    message = "Произошла ошибка при обработке файла.",
                    errors = ex.Message,
                    innerException
                });
            }

            return Ok(new
            {
                message = "Файл успешно загружен.",
                uploadFileId = uploadFileId
            });
        }

        
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateSpiskiNaDNFromMODTO dto)
        {
            var existingRecord = await _spiskiNaDnFromMoService.GetByIdAsync(id);
            if (existingRecord == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                var errors = GetValidationErrors();
                return BadRequest(new { message = "Ошибка валидации", errors });
            }

            var updatedDto = new SpiskiNaDNFromMODTO
            {
                Id = id, 
                Npp = dto.Npp,
                LastName = dto.LastName,
                Name = dto.Name,
                Patronymic = dto.Patronymic,
                BirthDay = dto.BirthDay,
                Snils = dto.Snils,
                N_reest = dto.N_reest,
                Period = dto.Period,
                Organizaciya = dto.Organizaciya
            };

            await _spiskiNaDnFromMoService.UpdateAsync(updatedDto);

            return Ok(updatedDto);
        }

        [HttpGet("nreest/{nReest}")]
        public async Task<IActionResult> GetByNReest(int nReest)
        {
            var results = await _spiskiNaDnFromMoService.GetByNReestAsync(nReest);

            if (results == null || !results.Any())
            {
                return NotFound("Записи с указанным номером реестра не найдены.");
            }
            
            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _spiskiNaDnFromMoService.GetByIdAsync(id);
            return result != null ? Ok(result) : NotFound("Запись не найдена.");
        }

        [HttpGet("lastname/{lastName}")]
        public async Task<IActionResult> GetByLastName(string lastName)
        {
            var results = await _spiskiNaDnFromMoService.GetByLastNameAsync(lastName);
            if (results == null || !results.Any())
            {
                return NotFound($"Записи с фамилией {lastName} не найдены");
            }
            return Ok(results);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            var existingRecord = await _spiskiNaDnFromMoService.GetByIdAsync(id);

            if (existingRecord == null)
            {
                return NotFound("Запись с указанным ID не найдена.");
            }
            
             await _spiskiNaDnFromMoService.DeleteByIdAsync(id);
            return Ok("Запись удалена.");
        }

        private IEnumerable<string> GetValidationErrors()
        {
            return ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage);
        }
    }

}
