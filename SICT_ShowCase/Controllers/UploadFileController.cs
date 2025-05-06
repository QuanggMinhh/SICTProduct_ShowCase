using Application.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IUploadFileService _uploadFileService;
        private readonly IMapper _mapper;

        public UploadFileController(IUploadFileService uploadFileService, IMapper mapper)
        {
            _uploadFileService = uploadFileService;
            _mapper = mapper;
        }

        [HttpPost("upload/{id}")]
        public async Task<IActionResult> Upload(IFormFile file, int id)
        {
            await _uploadFileService.UploadFileAsync(file, id);
            return Ok();
        }

        [HttpGet("Download")]
        public async Task<IActionResult> Download(int id)
        {
            var fileDto = await _uploadFileService.DownloadFileAsync(id);
            if (fileDto == null)
            {
                return NotFound();
            }
            return File(fileDto.Data, fileDto.ContentType, fileDto.FileName);
        }

        [HttpGet("getListFile")]
        public async Task<IActionResult> GetListFile()
        {
            var files = await _uploadFileService.GetAllFileAsync();
            return Ok(files);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFileById(int id)
        {
            var files = await _uploadFileService.GetFileByIdAsync(id);
            return Ok(files);
        }

        [HttpGet("byProductId/{id}")]
        public async Task<IActionResult> GetFilesByProductId(int id)
        {
            var files = await _uploadFileService.GetFilesByProductIdAsync(id);
            return Ok(files);
        }
    }
}
