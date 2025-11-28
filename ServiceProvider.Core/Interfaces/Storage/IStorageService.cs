namespace ServiceProvider.Core.Interfaces.Storage;

public interface IStorageService
{
	Task<string> UploadFileAsync(Stream fileStream, string fileName, string contentType);
}