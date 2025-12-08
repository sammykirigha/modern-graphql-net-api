namespace ServiceProvider.Core.Settings;

public class MPesaSettings
{
	public string ConsumerKey { get; set; } = string.Empty;
	public string ConsumerSecret { get; set; } = string.Empty;
	public bool InProduction { get; set; }
	public string BusinessShortCode { get; set; } = string.Empty;
	public string ShortCode { get; set; } = string.Empty;
	public string PassKey { get; set; } = string.Empty;
	public string GrantType { get; set; } = string.Empty;
	public string CallbackUrl { get; set; } = string.Empty;
}