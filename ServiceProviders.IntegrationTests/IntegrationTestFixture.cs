using Bogus;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq.Protected;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Microsoft.DependencyInjection;
using Xunit.Microsoft.DependencyInjection.Abstracts;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Services;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider;
using ServiceProvider.Data;
using System.Net;
using System.Text;
using System.Numerics;

namespace ServiceProviders.IntegrationTests;

public class IntegrationTestFixture : TestBedFixture // which implements IDisposable, IAsyncDisposable
{
    private SqliteConnection? _connection;
	private bool _seeded = false;
	protected Faker Faker = new();
	public Mock<HttpMessageHandler> MockHttpMessageHandlerMock = new();

    public IntegrationTestFixture()
    {
     
    } 

    protected override IEnumerable<TestAppSettings> GetTestAppSettings()
	{
		// this should find the appsettings.json that gets copied from WebApi.Admin at build time
		yield return new() { Filename = "appsettings.json", IsOptional = false };
	}

	//wire up the implemented services
	protected override void AddServices(IServiceCollection services, IConfiguration configuration)
	{
		_connection = new SqliteConnection("Filename=:memory:");
		_connection.Open();

		services.AddDbContext<ServiceProviderContext>(options => options.UseSqlite(_connection));

		// https://stackoverflow.com/questions/69981685/asp-net-core-6-how-do-i-get-required-service
		using (Microsoft.Extensions.DependencyInjection.ServiceProvider serviceProvider = services.BuildServiceProvider())
		{
			var dbContext = serviceProvider.GetRequiredService<ServiceProviderContext>();

			//EnsureDeleted() is an additional option that first deletes an existing database.
			dbContext.Database.EnsureDeleted();
			dbContext.Database.EnsureCreated();
		}

		services.AddHttpContextAccessor();
		services.AddSingleton(GetMockHttpClientFactory());

		//// this should be renamed to AddRespositories; they are not services
		services.AddDataServices();

		services.AddScoped<IUserProfileCoreService, UserProfileCoreService>();

		// hack to cope with new IWebHostEnvironment dependency in UserProfileService to create dev user
		services.AddScoped<IWebHostEnvironment, IntegrationTestWebHostEnvironment>();
		services.AddScoped<IUserProfileService, UserProfileService>();

		services.AddScoped<IIdentityRepository, IIdentityRepository>();
		services.AddScoped<IIdentityService, IIdentityService>();
		services.AddScoped<IClaimsUserService, IClaimsUserService>();


		services.AddMainServices();

		Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

		try
		{
			SeedDatabase(services).GetAwaiter().GetResult();
		}
		catch (Exception ex)
		{
			Console.WriteLine(" hook debugger here");
			Console.WriteLine(ex.ToString());

			// this method is called by the magic plumbing, via the constructor
			// exceptions thrown here just get swallowed, somewhere, and DO NOT interrupt unit test execution
			// If there is an error in seeding, it will typically show as a foreign key constraint in a test method.
			// I have not found a way to force the xUnit plumbing to stop on exceptions thrown here.
			// The only way to discover them is to run tests in the debugger and hook here.
			throw;
		}
	}

	protected IHttpClientFactory GetMockHttpClientFactory()
	{
		var response = new HttpResponseMessage
		{
			StatusCode = HttpStatusCode.OK,
		};

		MockHttpMessageHandler.Protected()
			.Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
			.ReturnsAsync(response)
			.Verifiable();
		var httpClient = new HttpClient(MockHttpMessageHandler.Object)
		{
			BaseAddress = new Uri("https://dummy/")
		};

		var mockHttpClientFactory = new Mock<IHttpClientFactory>();
		mockHttpClientFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClient);
		return mockHttpClientFactory.Object;
	}

	#region seeded IDs to cope with foreign key constraints on Add operations

	public Guid CategoryId { get; private set; }
	public Guid RoleId { get; private set; }
	public Guid PermissionId { get; private set; }
	public Guid LocationId { get; private set; }
	public Guid ServiceId { get; private set; }
	public Guid UserId { get; private set; }
	public Guid UserId_2 { get; private set; }


	public async Task SeedDatabase(IServiceCollection services)
	{
		if (!_seeded)
		{
			try
			{
				using var serviceProvider = services.BuildServiceProvider();

				var serviceRepository = serviceProvider.GetRequiredService<IServiceRepository>();
				var service = await serviceRepository.AddAsync(new ServiceProvider.Core.Models.Service { Name = "test service provider name", CategoryId = CategoryId, LocationId = LocationId });
				ServiceId = service.Id;

				var roleRepository = serviceProvider.GetRequiredService<IRoleRepository>();
				var role = await roleRepository.AddAsync(new ServiceProvider.Core.Models.Role { Name = "test role" });
				RoleId = role.Id;

				var locationRepository = serviceProvider.GetRequiredService<ILocationRepository>();
				var location = await locationRepository.AddAsync(new ServiceProvider.Core.Models.Location {County = "Test County", Town = "Test Town", Area = "Test Town" });
				LocationId = location.Id;

				var permissionRepository = serviceProvider.GetRequiredService<IPermissionRepository>();
				var permission = await permissionRepository.AddAsync(new ServiceProvider.Core.Models.Permission { Name="Test Permission" });
				PermissionId = permission.Id;
				//_ = await calendarDateRepository.AddAsync(calendarDate_1);

				_seeded = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("hook debugger here");
				Console.WriteLine(ex);
				throw;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _connection != null)
		{
			_connection.Close();
			_connection.Dispose();
		}
		base.Dispose(disposing);
	}
	protected override ValueTask DisposeAsyncCore() => new();
}