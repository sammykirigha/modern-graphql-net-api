using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Services.Medias;

namespace ServiceProvider.WebApi.Admin.Controllers;
[ApiController]
[Route("api/[controller]")]
public class FileUploadsController : ControllerBase
{
	private readonly IMediaStorageService  _mediaStorageService;

	public FileUploadsController(
		IMediaStorageService mediaStorageService
	)
	{
		_mediaStorageService = mediaStorageService;
	}

	[Authorize]
	[HttpPost("UploadFile")]
	public async Task<IActionResult> UploadFile(IFormFile file, [FromQuery] string category)
	{
		if (file == null || file.Length == 0)
			return BadRequest("No file uploaded.");

		using var stream = file.OpenReadStream();
		var fileUrl = await _mediaStorageService.ProcessDocumentUpload(stream, file.FileName, file.ContentType, Enum.Parse<MediaCategory>(category, true));

		return Ok(new { FileUrl = fileUrl });
	}
}