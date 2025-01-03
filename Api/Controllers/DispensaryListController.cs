﻿using Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Data.Model.Entities.UploadedFile;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class DispensaryListController : ControllerBase
    {
        private readonly DispensaryListService _service;

        public DispensaryListController(DispensaryListService service)
        {
            _service = service;
        }

        [HttpPost("process/{uploadFileInfId}")]
        public async Task<IActionResult> ProcessDispensaryList(int uploadFileInfId)
        {
            try
            {
                await _service.ProcessDispensaryListAsync(uploadFileInfId);

                return Ok(new
                {
                    Success = true,
                    Message = "Процесс обработки завершен успешно."
                });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new
                {
                    Success = false,
                    Message = "Произошла ошибка при обработке списка ДН.",
                    Details = ex.Message 
                });
            }
        }


        [HttpGet("download/{uploadFileInfId}")]
        public async Task<IActionResult> DownloadExcelFile(int uploadFileInfId)
        {
            try
            {
                var fileContent = await _service.GenerateExcelFileAsync(uploadFileInfId);
                return File(fileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DispensaryListResults.xlsx");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ошибка при генерации Excel файла: {ex.Message}");
            }
        }
        [HttpGet("results/{uploadFileInfId}")]
        public async Task<IActionResult> GetDispensaryListResults(int uploadFileInfId)
        {
            try
            {
                var results = await _service.GetDispensaryListResultsAsync(uploadFileInfId);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Success = false,
                    Message = "Произошла ошибка при получении данных.",
                    Details = ex.Message
                });
            }
        }

    }
}