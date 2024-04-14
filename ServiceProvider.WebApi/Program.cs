using Microsoft.ApplicationInsights.Extensibility;
using Serilog;
using Serilog.Events;
using Microsoft.EntityFrameworkCore;
using ServiceProvider;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Services;
using ServiceProvider.Core.Settings;
using ServiceProvider.Core.Utilities;
using ServiceProvider.Data;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Helpers;
using ServiceProvider.Services.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
builder.Configuration.AddJsonFile("appversion.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appversion.{environment}.json", optional: true, reloadOnChange: true);

var services = builder.Services;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateBootstrapLogger();

//add settings
AppSettings.Data.IsEFMigration = Environment.GetCommandLineArgs().Contains("migrations") ||
                                  Environment.GetCommandLineArgs().Contains("database");
builder.AddAppSettings();
builder.AddVersionSettings();

builder.Host.UseSerilog((contex, services, configuration) => configuration.ReadFrom.Configuration(contex.Configuration).ReadFrom.Services(services));
//add services
services.AddSingleton<ITelemetryInitializer, AppVersionTelemetryInitializer>();
services.AddScoped<IUserProfileCoreService, UserProfileCoreService>();
services.AddHttpContextAccessor();
services.AddHttpClient();
services.AddDataServices();
services.AddMainServices();
services.AddCorsConfig();
services.AddIdentityConfig();
services.AddSwaggerConfig();
services.AddGraphQLConfig(builder.Environment);

services.AddControllers();
services.AddHealthChecks();
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

// *** APP ***
var app = builder.Build();
app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
app.UseSwaggerConfig();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseRouting();
app.UseCors();
app.UseDefaultFiles();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<UserProfileHandlerMiddleware>();

app.MapControllers();
app.MapGraphQL();

//HealthCheck Middleware
app.MapHealthChecks("/api/health");
app.UseStaticFiles();

// ef migrations
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ServiceProviderContext>();
    if (context.Database.GetPendingMigrations().Any())
        context.Database.Migrate();
}

app.Run();
