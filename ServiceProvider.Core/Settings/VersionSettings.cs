namespace ServiceProvider.Core.Settings;

public static class VersionSettings
{
	public const string SectionName = "VersionSettings";
    
	public static string ContainerTag { get; set; } = string.Empty;
	public static string Branch { get; set; } = string.Empty;
}