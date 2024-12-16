using Microsoft.AspNetCore.Mvc;
using Api.Services;
using System.ComponentModel.DataAnnotations;
using Share.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [Authorize]
    [Route("api/processing/[controller]")]
    [ApiController]
    
    public class FileProcessingController : ControllerBase
    {
        
    }
}

