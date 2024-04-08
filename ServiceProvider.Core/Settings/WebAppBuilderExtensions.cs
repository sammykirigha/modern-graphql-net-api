using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace ServiceProvider.Core.Settings;

public static class WebAppBuilderExtensions
{
    public static void AddAppSettings(this WebApplicationBuilder builder)
    {
        // paths    
        AppSettings.WebRootPath = builder.Environment.WebRootPath;
        AppSettings.ContentRootPath = builder.Environment.ContentRootPath;
        
        //data settings
        AppSettings.Data.SqlConnectionString = builder.Configuration.GetConnectionString("SqlConnectionString") ?? "";
        if(AppSettings.Data.IsEFMigration)
            AppSettings.Data.SqlConnectionString = builder.Configuration.GetConnectionString("SqlConnectionStringEF") ?? "";
        
        //url settings
        var urls = builder.Configuration.GetSection(AppSettings.UrlSectionName);
        AppSettings.AngularUrl = urls.GetValue<string>(nameof(AppSettings.AngularUrl)) ?? "";
        AppSettings.ApiUrl = urls.GetValue<string>(nameof(AppSettings.ApiUrl)) ?? "";
    }
    
    public static void AddTestAppSettings(this WebApplicationBuilder builder)
    {
        
        //data settings
        AppSettings.Data.SqlConnectionString = builder.Configuration.GetConnectionString("SqlConnectionString") ?? "";
        if(AppSettings.Data.IsEFMigration)
            AppSettings.Data.SqlConnectionString = builder.Configuration.GetConnectionString("SqlConnectionStringEF") ?? "";
        
        //url settings
        var urls = builder.Configuration.GetSection(AppSettings.UrlSectionName);
        AppSettings.AngularUrl = urls.GetValue<string>(nameof(AppSettings.AngularUrl)) ?? "";
        AppSettings.ApiUrl = urls.GetValue<string>(nameof(AppSettings.ApiUrl)) ?? "";
    }
    
    public static void AddVersionSettings(this WebApplicationBuilder builder)
    {
        var version = builder.Configuration.GetSection(VersionSettings.SectionName);
        VersionSettings.ContainerTag = version.GetValue<string>(nameof(VersionSettings.ContainerTag)) ?? string.Empty;
        VersionSettings.Branch = version.GetValue<string>(nameof(VersionSettings.Branch)) ?? string.Empty;
    }
}