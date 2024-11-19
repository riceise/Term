using Microsoft.AspNetCore.Mvc;
using Api.Services;
using System.ComponentModel.DataAnnotations;
using Data.Model.Entities.Dictionary;


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
                    return BadRequest(ex.Message);
                }
            }
            return Ok("Файл успешно загружен.");
        }

    }
}