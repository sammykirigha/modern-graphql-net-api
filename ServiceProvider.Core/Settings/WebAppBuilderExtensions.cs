using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace ServiceProvider.Core.Settings;

public static class WebAppBuilderExt
{
	public static void AddAppSettings(this WebApplicationBuilder builder)
	{
		// paths
		AppSettings.WebRootPath = builder.Environment.WebRootPath;
		AppSettings.ContentRootPath = builder.Environment.ContentRootPath;

		// data
		builder.Configuration.AddConnectionStringAppSettings();

		// urls
		var urls = builder.Configuration.GetSection(AppSettings.UrlSectionName);
		AppSettings.AngularUrl = urls.GetValue<string>(nameof(AppSettings.AngularUrl)) ?? "";
		AppSettings.ApiUrl = urls.GetValue<string>(nameof(AppSettings.ApiUrl)) ?? "";

		// azure ad
		var azuread = builder.Configuration.GetSection(AzureAdB2CSettings.SectionName);
		azuread.Bind(AppSettings.AzureAd);
		AppSettings.AzureAd.Scopes = azuread.GetSection(nameof(AppSettings.AzureAd.Scopes)).GetChildren().ToDictionary(x => x.Value ?? "", x => x.Key);

		//stripe api
		var stripe = builder.Configuration.GetSection(StripeSettings.SectionName);
		stripe.Bind(AppSettings.Stripe);
		AppSettings.Stripe.SecretKey = stripe.GetSection(nameof(AppSettings.Stripe.SecretKey)).GetChildren().ToString()!;

		//serviceProvider jwt settings
		var serviceProviderJwt = builder.Configuration.GetSection(ServiceProviderJwtSettings.SectionName);
		serviceProviderJwt.Bind(AppSettings.ServiceProviderJwt);

	}

	public static void AddTestAppSettings(this IConfiguration configuration)
	{
		// data
		AppSettings.Data.SqlConnectionString = configuration.GetConnectionString("SqlConnectionString") ?? string.Empty;
		if (AppSettings.Data.IsEFMigration)
		{
			AppSettings.Data.SqlConnectionString = configuration.GetConnectionString("SqlConnectionStringEF") ?? string.Empty;
		}

		// urls
		var urls = configuration.GetSection(AppSettings.UrlSectionName);
		AppSettings.AngularUrl = urls.GetValue<string>(nameof(AppSettings.AngularUrl)) ?? "";
		AppSettings.ApiUrl = urls.GetValue<string>(nameof(AppSettings.ApiUrl)) ?? "";


		// azure ad
		var azuread = configuration.GetSection(AzureAdB2CSettings.SectionName);
		azuread.Bind(AppSettings.AzureAd);
		AppSettings.AzureAd.Scopes = azuread.GetSection(nameof(AppSettings.AzureAd.Scopes)).GetChildren().ToDictionary(x => x.Value ?? "", x => x.Key);

		//stripe api
		var stripe = configuration.GetSection(StripeSettings.SectionName);
		stripe.Bind(AppSettings.Stripe);
		AppSettings.Stripe.SecretKey = stripe.GetSection(nameof(AppSettings.Stripe.SecretKey)).GetChildren().ToString()!;

	}

	public static void AddVersionSettings(this WebApplicationBuilder builder)
	{
		var version = builder.Configuration.GetSection(VersionSettings.SectionName);
		VersionSettings.ContainerTag = version.GetValue<string>(nameof(VersionSettings.ContainerTag)) ?? string.Empty;
		VersionSettings.Branch = version.GetValue<string>(nameof(VersionSettings.Branch)) ?? string.Empty;
	}
	
	public static void AddConnectionStringAppSettings(this IConfiguration configuration)
	{
		AppSettings.Data.SqlConnectionString = configuration.GetConnectionString("SqlConnectionString") ?? "";
		AppSettings.Data.StorageConnectionString = configuration.GetConnectionString("StorageConnectionString") ?? "";
		if (AppSettings.Data.IsEFMigration)
			AppSettings.Data.SqlConnectionString = configuration.GetConnectionString("SqlConnectionStringEF") ?? "";
	} 
}
