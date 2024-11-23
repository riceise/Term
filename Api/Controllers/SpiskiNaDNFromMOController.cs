using Microsoft.AspNetCore.Mvc;
using Api.Services;
using System.ComponentModel.DataAnnotations;
using Data.Model.Entities.Dictionary;
using Share.DTOs;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadedFileController : ControllerBase
    {
        private readonly IUploadedFileService _uploadedFileService;

        public UploadedFileController(IUploadedFileService uploadedFileService)
        {
            _uploadedFileService = uploadedFileService;
        }
        [HttpPost("upload")]    
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Файл не выбран.");

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                stream.Position = 0;

                try
                {
                    await _uploadedFileService.ProcessSpiskiNaDN(stream);
                }
                catch (ValidationException ex)
                {
                    return BadRequest(new { message = "Файл содержит ошибки.", errors = ex.Message });
                }
            }
            return Ok("Файл успешно загружен.");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SpiskiNaDNFromMODTO dto)
        {
            if (id != dto.N_reest)
                return BadRequest("ID записи не соответствует ID в DTO.");

            if (!ModelState.IsValid)
            {
                var errors = GetValidationErrors();
                return BadRequest(new { message = "Ошибка валидации", errors });
            }

            await _uploadedFileService.UpdateAsync(dto);
            return Ok("Запись обновлена.");
        }

        [HttpGet("nreest/{nReest}")]
        public async Task<IActionResult> GetByNReest(int nReest)
        {
            var results = await _uploadedFileService.GetByNReestAsync(nReest);

            if (results == null || !results.Any())
            {
                return NotFound("Записи с указанным номером реестра не найдены.");
            }

            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _uploadedFileService.GetByIdAsync(id);
            return result != null ? Ok(result) : NotFound("Запись не найдена.");
        }

        [HttpGet("lastname/{lastName}")]
        public async Task<IActionResult> GetByLastName(string lastName)
        {
            var results = await _uploadedFileService.GetByLastNameAsync(lastName);
            return Ok(results);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            var existingRecord = await _uploadedFileService.GetByIdAsync(id);

            if (existingRecord == null)
            {
                return NotFound("Запись с указанным ID не найдена.");
            }
            
            _uploadedFileService.DeleteByIdAsync(id);
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
