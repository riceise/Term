using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
                    Message = "Произошла ошибка при обработке списка ДД.",
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
    }
}