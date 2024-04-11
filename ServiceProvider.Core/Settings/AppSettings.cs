

namespace ServiceProvider.Core.Settings;
public static class AppSettings
{
	public const string UrlSectionName = "UrlSettings";

	public static string WebRootPath { get; set; } = "";
	public static string ContentRootPath { get; set; } = "";
	public static string AngularUrl { get; set; } = "";
	public static string ApiUrl { get; set; } = "";

	public static DataSettings Data { get; set; } = new DataSettings();
	public static AzureAdB2CSettings AzureAd { get; set; } = new AzureAdB2CSettings();
	public static ServiceProviderJwtSettings ServiceProviderJwt { get; set; } = new();
}