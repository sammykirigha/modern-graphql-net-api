using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.Extensions.Options;
using ServiceProvider.Core.Interfaces.Storage;
using ServiceProvider.Core.Settings;

namespace ServiceProvider.Services.Infrastructure;
public class StorageService : IStorageService
{
	private readonly IAmazonS3 _s3Client;
	private readonly AwsSettings _awsSettings;

	public StorageService(  IOptions<AwsSettings> awsSettingsOptions)
	{
		_awsSettings = awsSettingsOptions.Value;
		
		//create credentials and s3 client if needed
		AWSCredentials credentials = new BasicAWSCredentials(_awsSettings.AWS_ACCESS_KEY_ID, _awsSettings.AWS_SECRET_ACCESS_KEY);
		RegionEndpoint region = RegionEndpoint.GetBySystemName(_awsSettings.AWS_REGION);
		
		_s3Client = new AmazonS3Client(credentials, region);
	}
	
	public async Task<string> UploadFileAsync(Stream fileStream, string fileName, string contentType)
	{
		var uploadRequest = new TransferUtilityUploadRequest
		{
			InputStream = fileStream,
			Key = fileName,
			BucketName = _awsSettings.AWS_BUCKET_NAME,
			ContentType = contentType,
		};
		
		using (var transferUtility = new TransferUtility(_s3Client))
		{
			await transferUtility.UploadAsync(uploadRequest);
		}
		return $"https://{_awsSettings.AWS_BUCKET_NAME}{fileName}"; 
	}
}