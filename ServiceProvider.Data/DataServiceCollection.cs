using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Repositories.Auth;
using ServiceProvider.Core.Interfaces.Repository.Medias;
using ServiceProvider.Core.Settings;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Data.Repositories;
using ServiceProvider.Data.Repositories.Auth;
using ServiceProvider.Data.Repositories.Medias;

namespace ServiceProvider.Data;

public static class DataServiceCollectionExtensions
{       
	public static IServiceCollection AddDataServices(this IServiceCollection services, IWebHostEnvironment environment = null)
	{
		// Check if we're in test environment
		bool isTestEnvironment = environment?.IsEnvironment("IntegrationTests") == true;

		if (isTestEnvironment)
		{
			// Use in-memory database for tests
			services.AddDbContext<ServiceProviderContext>(options => 
				options.UseInMemoryDatabase($"InMemoryDbForTesting_{Guid.NewGuid()}"));
		}
		else
		{
			services.AddDbContext<ServiceProviderContext>(options => options.UseSqlServer(AppSettings.Data.SqlConnectionString, x => x.MigrationsAssembly("ServiceProvider.Data")));
		}
		
		
		// Repositories
		services.AddScoped<IRepositoryBase, RepositoryBase>();
        
		// logs
		services.AddScoped<IErrorLogRepository, ErrorLogRepository>();
		services.AddScoped<IEntityLogRepository, EntityLogRepository>();
        
		// user
		services.AddScoped<IUserRepository, UserRepository>();
		services.AddScoped<IUserPermissionRepository, UserPermissionRepository>();
		
		//refresh token
		services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        
		// Permission
		services.AddScoped<IPermissionRepository, PermissionRepository>();
		
		//media
		services.AddScoped<IMediaRepository, MediaRepository>();
        
		//Role
		services.AddScoped<IRoleRepository, RoleRepository>();
		services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();

		//location
		services.AddScoped<ILocationRepository, LocationRepository>();

		//category
		services.AddScoped<ICategoryRepository, CategoryRepository>();

		//service
		services.AddScoped<IServiceRepository, ServiceRepository>();
		//serviceListing
		services.AddScoped<IServiceListingRepository, ServiceListingRepository>();
		//serviceListingServices
		services.AddScoped<IServiceListingsServicesRepository, ServiceListingsServicesRepository>();
		
		//serviceProviderclient
		services.AddScoped<IServiceProviderEntityRepository, ServiceProviderEntityRepository>();

		//plans
		services.AddScoped<IPlanRepository, PlanRepository>();

		//payments
		services.AddScoped<IPaymentRepository, PaymentRepository>();

		//susbscription
		services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
        
		//providerLocations
		services.AddScoped<IProviderLocationsRepository, ProviderLocationsRepository>();
		
		return services;
	}
    
}