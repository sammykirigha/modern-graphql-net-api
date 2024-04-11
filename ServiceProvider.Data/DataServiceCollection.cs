using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Settings;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Data.Repositories;

namespace ServiceProvider.Data;

public static class DataServiceCollectionExtensions
{       
	public static IServiceCollection AddDataServices(this IServiceCollection services)
	{
		services.AddDbContextPool<ServiceProviderContext>(options => options.UseSqlServer(AppSettings.Data.SqlConnectionString, x => x.MigrationsAssembly("ServiceProvider.Data")));
        
		// Repositories
		services.AddScoped<IRepositoryBase, RepositoryBase>();
        
		// logs
		services.AddScoped<IErrorLogRepository, ErrorLogRepository>();
		services.AddScoped<IEntityLogRepository, EntityLogRepository>();
        
		// user
		services.AddScoped<IUserRepository, UserRepository>();
		services.AddScoped<IUserPermissionRepository, UserPermissionRepository>();
        
		// Permission
		services.AddScoped<IPermissionRepository, PermissionRepository>();
        
		//Role
		services.AddScoped<IRoleRepository, RoleRepository>();
		services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();
        
		return services;
	}
    
}