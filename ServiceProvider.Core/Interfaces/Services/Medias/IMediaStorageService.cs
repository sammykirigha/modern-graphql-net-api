using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.Interfaces.Services.Medias;
public interface IMediaStorageService
{
	Task<string> ProcessDocumentUpload(Stream fileStream, string originalFileName, string contentType, MediaCategory uploadingReason);
}