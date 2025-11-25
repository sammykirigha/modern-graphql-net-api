using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PrismBenefits.Core.Interfaces.Services.Identity;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Settings;
using ServiceProvider.Data.Repositories;
using ServiceProvider.Services;
using System.Text;

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

		services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
		.AddJwtBearer(options =>
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidIssuer = AppSettings.ServiceProviderJwt.ValidIssuer,
				ValidateAudience = true,
				ValidAudiences = AppSettings.ServiceProviderJwt.ValidAudiences,
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppSettings.ServiceProviderJwt.IssuerSigningKey)),
				ValidateLifetime = true,
				ClockSkew = TimeSpan.Zero
			};
		});

		services.AddAuthorization(options =>
		{
			options.AddPolicy("Admin", policy => policy.RequireClaim("role", "Admin"));
			options.AddPolicy("User", policy => policy.RequireClaim("role", "User"));
			//options.AddPolicy("Manager", policy => policy.RequireClaim("department", "Accounts"));
		});

		return services;
	}
}