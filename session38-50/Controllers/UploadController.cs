using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using session38_50.Models;
using SixLabors.ImageSharp;

namespace session38_50.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UploadController : ControllerBase
{
    private readonly FileUploadSettings _settings;
    private readonly IWebHostEnvironment _env;

    public UploadController(IOptions<FileUploadSettings> settings, IWebHostEnvironment env)
    {
        _settings = settings.Value;
        _env = env;
    }

    [HttpPost("image")]
    public async Task<ActionResult> UploadImage([FromForm] IFormFile file)
    {
        try
        {
            // Kiem tra file co null hay khong
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }
            // kiem tra kich thuoc file co vuot qua muc hay khong
            if (file.Length > _settings.MaxSizeFile)
            {
                return BadRequest("File is too large.");
            }
            // Kiem tra dinh dang file
            // lay duoi file 
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (!_settings.AllowedExtensions.Contains(extension))
            {
                return BadRequest("File extension is invalid.");
            }

            // Tao ten file trc khi luu vao project
            var fileName = $"{Guid.NewGuid()}{extension}";
            var uploadPath = Path.Combine(_env.WebRootPath, _settings.UploadPath);
            
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            var image = await Image.LoadAsync(file.OpenReadStream());
            // Luu file
            var filePath = Path.Combine(uploadPath, fileName);
            await image.SaveAsync(filePath);
            return Ok(new UploadResponse
            {
                Success = true,
                Message =  "Uploaded file successfully.",
                FilePath = filePath
            });
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
       
    }
}