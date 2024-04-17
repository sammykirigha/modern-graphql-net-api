using Bogus;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Xunit.Microsoft.DependencyInjection;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace PrismBenefits.IntegrationTests;

public class IntegrationTestFixture : TestBedFixture // which implements IDisposable, IAsyncDisposable
{
	private SqliteConnection? _connection;
	private bool _seeded = false;
	protected Faker Faker = new();

	public IntegrationTestFixture() { }

	protected override IEnumerable<TestAppSettings> GetTestAppSettings()
	{
		// this should find the appsettings.json that gets copied from WebApi.Admin at build time
		yield return new() { Filename = "appsettings.json", IsOptional = false };
	}

	// wire up the implemented services
	protected override void AddServices(IServiceCollection services, IConfiguration? configuration)
	{
		_connection = new SqliteConnection("Filename=:memory:");
		_connection.Open();

		services.AddDbContext<BenefitContext>(options =>
			options.UseSqlite(_connection)
		);

		// https://stackoverflow.com/questions/69981685/asp-net-core-6-how-do-i-get-required-service
		using (Microsoft.Extensions.DependencyInjection.ServiceProvider serviceProvider = services.BuildServiceProvider())
		{
			var dbContext = serviceProvider.GetRequiredService<BenefitContext>();

			//EnsureDeleted() is an additional option that first deletes an existing database.
			dbContext.Database.EnsureDeleted();
			dbContext.Database.EnsureCreated();
		}

		services.AddHttpContextAccessor();
		services.AddHttpClient();

		//// this should be renamed to AddRespositories; they are not services
		services.AddDataServices();

		services.AddScoped<IUserProfileCoreService, UserProfileCoreService>();

		// hack to cope with new IWebHostEnvironment dependency in UserProfileService to create dev user
		services.AddScoped<IWebHostEnvironment, IntegrationTestWebHostEnvironment>();
		services.AddScoped<IUserProfileService, UserProfileService>();

		services.AddScoped<IIdentityRepository, IdentityRepository>();
		services.AddScoped<IIdentityService, IdentityService>();
		services.AddScoped<IClaimsUserService, ClaimsUserService>();


		services.AddMainServices();

		services.AddScoped<IFileService, FileService>();
		services.AddScoped<IFileRepository, FileRepository>();
		services.AddScoped<BlobStorage, BlobStorage>();
		

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

	#region seeded IDs to cope with foreign key constraints on Add operations
	
	public Guid RoleId { get; private set; }
	public Guid PermissionId { get; private set; }
	public Guid UserId { get; private set; }
	public Guid UserId_2 { get; private set; }
	// for benefit tests

	public Guid LocationId_1 { get; private set; }
	public Guid LocationId_2 { get; private set; }
	public Guid CategoryId_1 { get; private set; }
	public Guid CategoryId_2 { get; private set; }

	public Guid ServiceId { get; private set; }
	public Guid CarrierId { get; private set; }

	#endregion seeded IDs to cope with foreign key constraints on Add operations


	public async Task SeedDatabase(IServiceCollection services)
	{
		if (!_seeded)
		{
			try
			{
				using var serviceProvider = services.BuildServiceProvider();

				var serviceProviderRepository = serviceProvider.GetRequiredService<IServiceProviderRepository>();
				PrismBenefits.Core.Models.ServiceProvider svcProvider = await serviceProviderRepository.AddAsync(new PrismBenefits.Core.Models.ServiceProvider { Name = "test service provider name", HCMCompanyId = 1 });
				ServiceProviderId = svcProvider.Id;

				var clientRepository = serviceProvider.GetRequiredService<IClientRepository>();
				var client = await clientRepository.AddAsync(new Client { ServiceProviderId = ServiceProviderId, Name = "Test Client Name" });
				ClientId = client.Id;

				var roleRepository = serviceProvider.GetRequiredService<IRoleRepository>();
				var role = await roleRepository.AddAsync(new Role { ClientId = ClientId, Name = "test role" });
				RoleId = role.Id;

				var departmentRepository = serviceProvider.GetRequiredService<IDepartmentRepository>();
				var department = await departmentRepository.AddAsync(new Department { Name = "test department", ClientId = ClientId });
				DepartmentId = department.Id;

				var divisionRepository = serviceProvider.GetRequiredService<IDivisionRepository>();
				var division = await divisionRepository.AddAsync(new Division { Name = "test division", ClientId = ClientId });
				DivisionId = division.Id;

				// these are not benefit-eligible benefit classes, by default
				var benefitClassRepository = serviceProvider.GetRequiredService<IBenefitClassRepository>();
				var benefitClass = await benefitClassRepository.AddAsync(new BenefitClass { Name = "test benefit class", ClientId = ClientId });
				BenefitClassId = benefitClass.Id;
				var benefitClass_2 = await benefitClassRepository.AddAsync(new BenefitClass { Name = "test benefit class 2", ClientId = ClientId });
				BenefitClassId_2 = benefitClass_2.Id;


				// the benefit class needs a benefit class calendar assignment that is Active and effective before the asOfDate
				// see GetEmployeesAsync for the requirements...
				var calendar_1 = new Calendar
				{
					ClientId = ClientId,
					Name = "Calendar for benefit classes",
					StartDate = DateTime.UtcNow.AddMonths(-2),
					CalendarType = CalendarType.Weekly, // whatever
					DedFreq = 26
				};
				var calendarRepository = serviceProvider.GetRequiredService<ICalendarRepository>();
				calendar_1 = await calendarRepository.AddAsync(calendar_1);
				CalendarId_1 = calendar_1.Id;
				

				var jobTitleRepository = serviceProvider.GetRequiredService<IJobTitleRepository>();
				var jobTitle = await jobTitleRepository.AddAsync(new JobTitle { Name = "test job title", ClientId = ClientId });
				JobTitleId = jobTitle.Id;

				var userRepository = serviceProvider.GetRequiredService<IUserRepository>();
				var user = await userRepository.AddAsync(new Core.Models.User { FirstName = "test first name" });
				user.SsoObjectId = user.Id;
				await userRepository.UpdateAsync(user);
				UserId = user.Id;
				var user_2 = await userRepository.AddAsync(new Core.Models.User { FirstName = "another first name" });
				user_2.SsoObjectId = user_2.Id;
				await userRepository.UpdateAsync(user_2);
				UserId_2 = user_2.Id;

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
