using ServiceProvider.Core.Settings;

namespace Microsoft.Extensions.DependencyInjection;

public static class CorsConfigurationExtensions
{
	public static IServiceCollection AddCorsConfig(this IServiceCollection services)
	{
		services.AddCors(options =>
		{
			options.AddDefaultPolicy(policy =>
			{
				policy.WithOrigins(AppSettings.AngularUrl, AppSettings.ApiUrl)
					.AllowAnyHeader()
					.AllowAnyMethod()
					.AllowCredentials();
			});
		});

		return services;
	}
}