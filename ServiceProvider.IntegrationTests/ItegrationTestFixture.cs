

namespace ServiceProvider.IntegrationTests
{
 public class IntergrationTestFixture : TestBedFixture
 {
	 private SqliteConnection? _connection;
	 private bool _seeded = false;
	 protected Faker Faker = new();
	 
	 public IntergrationTestFixture()
	 {
	 }
	 
	 protected override IEnumerable<TestAppSettings> GetTestAppSettings()
	 {
		 yield return new() {Filename = "appsettings.json", IsOptional = false};
	 }
	 
	 protected override void AddServices(IServiceCollection services, IConfiguration configuration)
	 {
		 _connection = new SqliteConnection("Filename=:memory:");
		 _connection.Open();
		 services.AddDbContext<ServiceProviderDbContext>(options =>
		 {
			 options.UseSqlite(_connection);
		 });
		 
		  using (Microsoft.Extensions.DependencyInjection.ServiceProvider serviceProvider = services.BuildServiceProvider())
         	 {
         		 var dbContext = serviceProvider.GetRequiredService<ServiceProviderDbContext>();
         		 dbContext.Database.EnsureCreated();
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
	 }
	 
	
 }
};

