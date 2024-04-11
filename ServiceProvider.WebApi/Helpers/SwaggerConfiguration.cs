using Microsoft.OpenApi.Models;
using ServiceProvider.Core.Settings;

namespace Microsoft.Extensions.DependencyInjection;

public static class SwaggerConfigurationExtensions
{
    public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
    {
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "ServiceProvider Admin Api", Version = "v1" });
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.OAuth2,
                Flows = new OpenApiOAuthFlows
                {
                    AuthorizationCode = new OpenApiOAuthFlow
                    {
                        AuthorizationUrl = AppSettings.AzureAd.AuthorizationUrl,
                        TokenUrl = AppSettings.AzureAd.TokenUrl,
                        Scopes = AppSettings.AzureAd.Scopes
                    }
                }
            });
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                [new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "oauth2"
                    }
                }] = new List<string>()
            });
        });

        return services;
    }

    public static WebApplication UseSwaggerConfig(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.RoutePrefix = string.Empty;
            options.SwaggerEndpoint($"/swagger/v1/swagger.json", "ServiceProvider Admin Api v1");
            options.OAuthClientId(AppSettings.AzureAd.ClientId);
            options.OAuthScopes(AppSettings.AzureAd.Scopes.Keys.ToArray());
            options.OAuthUsePkce();
        });

        return app;
    }
}

