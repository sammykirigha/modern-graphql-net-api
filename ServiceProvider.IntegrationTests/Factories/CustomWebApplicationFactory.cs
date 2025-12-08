using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.IntegrationTests;
public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
{
	private  SqliteConnection _sqliteConnection;
	
	protected override void ConfigureWebHost(IWebHostBuilder builder)
	{
		_sqliteConnection = new SqliteConnection("DataSource=:memory:");
		_sqliteConnection.Open();

		builder.ConfigureTestServices(services =>
		{
			var descriptor = services.SingleOrDefault(
				d => d.ServiceType == typeof(DbContextOptions<ServiceProviderContext>));
			if (descriptor != null)
			{
				services.Remove(descriptor);
			}
			
			services.AddDbContext<ServiceProviderContext>(options =>
			{
				options.UseSqlite(_sqliteConnection);
			});

			using (var scope = services.BuildServiceProvider().CreateScope())
			{
				var dbContext = scope.ServiceProvider.GetRequiredService<ServiceProviderContext>();
				dbContext.Database.EnsureCreated();
			}
		});
	}
    
    protected override void Dispose(bool disposing)
    {
	    base.Dispose(disposing);
	    if (disposing && _sqliteConnection != null)
	    {
		    _sqliteConnection.Close();
		    _sqliteConnection.Dispose();
	    }
    }
    
}