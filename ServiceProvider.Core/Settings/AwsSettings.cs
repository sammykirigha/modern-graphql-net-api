namespace ServiceProvider.Core.Settings;

public class AwsSettings
{
	public string AWS_BUCKET_NAME { get; set; } = string.Empty;
	public string AWS_ACCESS_KEY_ID { get; set; }= string.Empty;
	public string AWS_SECRET_ACCESS_KEY { get; set; }= string.Empty;
	public string AWS_REGION { get; set; } = string.Empty;
	public string AWS_ENDPOINT { get; set; } = string.Empty;
}