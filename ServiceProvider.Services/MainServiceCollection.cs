
using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Services;

namespace ServiceProvider;
public static class MainServiceCollectionExtensions
{
	public static IServiceCollection AddMainServices(this IServiceCollection services)
	{
		// Services
		// logs
		services.AddScoped<IErrorLogService, ErrorLogService>();
		services.AddScoped<IEntityLogService, EntityLogService>();
        
		//users
		services.AddScoped<IUserService, UserService>();
		services.AddScoped<IUserPermissionService, UserPermissionService>();
        
		// Permission
		services.AddScoped<IPermissionService, PermissionService>();
        
		//Role
		services.AddScoped<IRoleService, RoleService>();
		services.AddScoped<IRolePermissionService, RolePermissionService>();

		//service
		services.AddScoped<IServiceLocationService, ServiceLocationService>();
		services.AddScoped<IServiceService, ServiceService>();

		//location
		services.AddScoped<ILocationService, LocationService>();

		//category
		services.AddScoped<ICategoryService, CategoryService>();
		
		//service provider client 
		services.AddScoped<IClientService, ClientService>();
        
		return services;
	}
    
	public static IRequestExecutorBuilder AddGraphQLServices(this IRequestExecutorBuilder builder)
	{
		// logs
		builder.RegisterService<IErrorLogService>();
		builder.RegisterService<IEntityLogService>();
        
		//users
		builder.RegisterService<IUserService>();
		builder.RegisterService<IUserPermissionService>();
        
		// permission
		builder.RegisterService<IPermissionService>();
        
		//Role
		builder.RegisterService<IRoleService>();
		builder.RegisterService<IRolePermissionService>();

		//location
		builder.RegisterService<ILocationService>();

		//category
		builder.RegisterService<ICategoryService>();

		//service
		builder.RegisterService<IServiceLocationService>();
		builder.RegisterService<IServiceService>();

		//client
		builder.RegisterService<IClientService>();

		//user
		builder.RegisterService<IUserService>();
        
		return builder;
	}
}