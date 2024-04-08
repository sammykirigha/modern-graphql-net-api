using Microsoft.Extensions.Configuration;

namespace ServiceProvider.Core.Settings;

public static class AppSettingConfiguration
{
	public static IConfiguration InitConfiguration()
	{
		var config = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
			.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: false)
			.AddEnvironmentVariables()
			.Build();
		return config;
	}
}