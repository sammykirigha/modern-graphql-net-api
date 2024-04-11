
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
        
		return builder;
	}
}