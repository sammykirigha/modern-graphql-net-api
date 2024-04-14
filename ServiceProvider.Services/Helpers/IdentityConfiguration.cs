using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;
using PrismBenefits.Core.Interfaces.Services.Identity;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Settings;
using ServiceProvider.Data.Repositories;
using ServiceProvider.Services;

namespace ServiceProvider.Helpers;

public static class IdentityConfigurationExtensions
{
	public static IServiceCollection AddIdentityConfig(this IServiceCollection services)
	{
		services.AddScoped<IIdentityRepository, IdentityRepository>();
		services.AddScoped<IClaimsUserService, ClaimsUserService>();
		services.AddScoped<IIdentityService, IdentityService>();
		services.AddScoped<IUserProfileService, UserProfileService>();
		services.AddScoped<IJwtTokenHandlerService, JwtTokenHandlerService>();

		services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddMicrosoftIdentityWebApi(o =>
		{
			o.TokenValidationParameters.NameClaimType = "name";
		}, o =>
		{
			o.Instance = AppSettings.AzureAd.Instance;
			o.Domain = AppSettings.AzureAd.Domain;
			o.ClientId = AppSettings.AzureAd.ClientId;
			o.SignedOutCallbackPath = AppSettings.AzureAd.SignedOutCallbackPath;
			o.SignUpSignInPolicyId = AppSettings.AzureAd.SignUpSignInPolicyId;
		});

		return services;
	}
}