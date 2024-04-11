namespace ServiceProvider.Core.Settings;

public class AzureAdB2CSettings
{
	public const string SectionName = "AzureAdB2C";

	public string Instance { get; set; } = "";
	public string Domain { get; set; } = "";
	public string ClientId { get; set; } = "";
	public string SignedOutCallbackPath { get; set; } = "";
	public string SignUpSignInPolicyId { get; set; } = "";

	public string SwaggerRedirectUrl { get; set; } = "";
	public string GraphQLRedirectUrl { get; set; } = "";

	public Dictionary<string, string> Scopes { get; set; } = new Dictionary<string, string>();


	public Uri AuthorizationUrl => new($"{Instance}/{Domain}/{SignUpSignInPolicyId}/oauth2/v2.0/authorize");
	public Uri TokenUrl => new($"{Instance}/{Domain}/{SignUpSignInPolicyId}/oauth2/v2.0/token");
}