namespace ServiceProvider.Core.Settings;

public class DataSettings
{
	public const string SectionName = "DataSettings";
    
	public bool IsEFMigration { get; set; } = false;
    
	public string SqlConnectionString { get; set; } = "";
	public string StorageConnectionString { get; set; } = "";
}