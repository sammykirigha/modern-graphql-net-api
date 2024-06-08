namespace ServiceProvider.Core.Settings;

public class StripeSettings
{
    public const string SectionName = "StripeSettings";
    public string SecretKey { get; set; } ="";
    public string PublishableKey { get; set; } ="";
}