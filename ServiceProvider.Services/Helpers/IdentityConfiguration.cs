
using Microsoft.Extensions.DependencyInjection;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
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

		return services;
	}
}