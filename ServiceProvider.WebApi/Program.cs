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
using Microsoft.Extensions.Options;
using ServiceProvider.Core.Interfaces.EmailService;
using ServiceProvider.Core.Interfaces.Passwords;
using ServiceProvider.Core.Interfaces.Services.PaymentStrategy;
using ServiceProvider.Core.Interfaces.Storage;
using ServiceProvider.Services.Infrastructure;
using ServiceProvider.Services.Mapping;
using ServiceProvider.Services.Services.EmailService;

var builder = WebApplication.CreateBuilder(args);
var isTestEnvironment = builder.Environment.IsEnvironment("IntegrationTests");

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
// Only add app settings if not in test environment
if (!isTestEnvironment)
{
	builder.AddAppSettings();
	builder.Host.UseSerilog((context, services, configuration) => configuration
		.ReadFrom.Configuration(context.Configuration)
		.ReadFrom.Services(services)
		.Enrich.FromLogContext());
}
else
{
	builder.Configuration.AddTestAppSettings();

}
builder.AddVersionSettings();

//automapper
services.AddAutoMapper(typeof(Program), typeof(UserProfile));
//stripe gat way
services.Configure<StripeSettings>(builder.Configuration!.GetSection("StripeSettings"));
services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<StripeSettings>>().Value);

//email
services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
services.AddScoped<IEmailService, SmtpEmailService>();
services.AddScoped<IPasswordResetTokenService, PasswordResetTokenService>();

//aws
services.AddScoped<IStorageService, StorageService>();
services.Configure<AwsSettings>(builder.Configuration.GetSection("AwsSettings"));

//tokens
services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
services.Configure<MPesaSettings>(builder.Configuration.GetSection("MPesaSettings"));

//payment
services.AddKeyedScoped<IPaymentStrategy, MpesaDarajaGateway>("mpesa");
services.AddKeyedScoped<IPaymentStrategy, StripeGateway>("stripe");

//add services
services.AddSingleton<ITelemetryInitializer, AppVersionTelemetryInitializer>();
services.AddScoped<IUserProfileCoreService, UserProfileCoreService>();
services.AddHttpContextAccessor();
services.AddHttpClient();
services.AddDataServices(builder.Environment);
services.AddMainServices();
services.AddCorsConfig();
services.AddIdentityConfig();
services.AddSwaggerConfig();
services.AddGraphQLConfig(builder.Environment);

services.AddHttpContextAccessor();
services.AddControllers();
services.AddHealthChecks();
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

// *** APP ***
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
	app.UseSerilogRequestLogging();
	app.UseSwaggerConfig();
    app.UseDeveloperExceptionPage();
    
    using (var scope = app.Services.CreateScope())
    {
	    var dbContext = scope.ServiceProvider.GetRequiredService<ServiceProviderContext>();
        
	    if (dbContext.Database.IsRelational())
	    {
		    
		    var pendingMigrations = dbContext.Database.GetPendingMigrations();
		    if (pendingMigrations.Any())
		    {
			    dbContext.Database.Migrate();
		    }
	    }
    }
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

public partial class Program { }

// "email": "dkirigha18+1@gmail.com",

// "password": "AdminPa55word!"
