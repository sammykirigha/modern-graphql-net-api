namespace Microsoft.Extensions.DependencyInjection;

public static class CorsConfigurationExtensions
{
	public static IServiceCollection AddCorsConfig(this IServiceCollection services)
	{
		services.AddCors(options =>
		{
			options.AddDefaultPolicy(policy =>
			{
				policy.WithOrigins("http://localhost:4200", "http://localhost:7134")
					.AllowAnyHeader()
					.AllowAnyMethod()
					.AllowCredentials();
			});
		});

		return services;
	}
}