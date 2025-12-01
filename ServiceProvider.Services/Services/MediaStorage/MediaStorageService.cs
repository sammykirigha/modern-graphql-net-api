using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Repository.Medias;
using ServiceProvider.Core.Interfaces.Services.Medias;
using ServiceProvider.Core.Interfaces.Storage;
using ServiceProvider.Core.Models.Medias;
using System.Security.Claims;


namespace ServiceProvider.Services.Services.MediaStorage;
public class MediaStorageService : IMediaStorageService
{
	private readonly IStorageService _storageService;
	private readonly IServiceProviderEntityRepository _spRepository;
	private readonly IMediaRepository _mediaRepository;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public MediaStorageService(
		IStorageService storageService, 
		IMediaRepository mediaRepository, 
		IHttpContextAccessor httpContextAccessor,  
		IServiceProviderEntityRepository spRepository)
	{
		_storageService = storageService;
		_mediaRepository = mediaRepository;
		_spRepository = spRepository;
		_httpContextAccessor = httpContextAccessor;
	}

	public async Task<string> ProcessDocumentUpload(Stream fileStream, string originalFileName, string contentType, MediaCategory uploadingReason)
	{
		if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
			throw new AppException($"You are not authorised to perform this");
		
		var  email = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
		
		var spId = await _spRepository.GetList().Where(sp => sp.Email == email).Select(sp => sp.Id)
			.FirstOrDefaultAsync();
		
		using var trans = await _mediaRepository.BeginTransactionAsync();
		
		var folder = uploadingReason == MediaCategory.BusinessImages ? "business-images" : "personal-documents";

		var s3Key = $"/{folder}/{DateTime.UtcNow.Ticks}_{Guid.NewGuid()}_{originalFileName}"; 
		
		var fileUrl = await _storageService.UploadFileAsync(fileStream, s3Key, contentType);
		
		var media = new Media()
		{
			Category = uploadingReason,
			Url = fileUrl,
			ServiceProviderId = spId,
			DateCreated = DateTime.UtcNow,
			DateModified = DateTime.UtcNow
		};

		await _mediaRepository.AddAsync(media);
		trans.CommitAsync();
		
		return fileUrl;
	}
}