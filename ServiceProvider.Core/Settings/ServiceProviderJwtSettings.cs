namespace ServiceProvider.Core.Settings;

public class ServiceProviderJwtSettings
{
	public const string SectionName = "ServiceProviderJwt";
	public string ValidIssuer { get; set; } = "";
	public List<string> ValidAudiences { get; set; } = new();
	public string IssuerSigningKey { get; set; } = "";
}