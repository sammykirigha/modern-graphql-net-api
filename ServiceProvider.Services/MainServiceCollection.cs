using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceProvider.Core.Interfaces;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Interfaces.Services.Auth;
using ServiceProvider.Core.Interfaces.Services.Medias;
using ServiceProvider.Core.Interfaces.Services.Users;
using ServiceProvider.Services;
using ServiceProvider.Services.Auth;
using ServiceProvider.Services.Services;
using ServiceProvider.Services.Services.MediaStorage;
using Stripe;
using PlanService = ServiceProvider.Services.PlanService;
using SubscriptionService = ServiceProvider.Services.SubscriptionService;

namespace ServiceProvider;
public static class MainServiceCollectionExtensions
{
	public static IServiceCollection AddMainServices(this IServiceCollection services)
	{
		// Services
		// logs
		services.AddScoped<IErrorLogService, ErrorLogService>();
		services.AddScoped<IEntityLogService, EntityLogService>();

		//claim services
		services.AddScoped<IClaimsUserService, ClaimsUserService>();
        
		//users
		services.AddScoped<IUserService, UserService>();
		services.AddScoped<IUserPermissionService, UserPermissionService>();
		
		//refresh token
		services.AddScoped<IRefreshTokenService, RefreshTokenService>();
        
		// Permission
		services.AddScoped<IPermissionService, PermissionService>();
        
		//Role
		services.AddScoped<IRoleService, RoleService>();
		services.AddScoped<IRolePermissionService, RolePermissionService>();

		//service
		services.AddScoped<IServiceService, ServiceService>();
		
		//serviceListing
		services.AddScoped<IServiceListingService, ServiceListingService>();

		//location
		services.AddScoped<ILocationService, LocationService>();

		//category
		services.AddScoped<ICategoryService, CategoryService>();
		
		//service provider client 
		services.AddScoped<IServiceProviderEntityService, ServiceProviderEntityService>();

		//plans
		services.AddScoped<IPlanService, PlanService>();
		
		//media
		services.AddScoped<IMediaStorageService, MediaStorageService>();  

		//subscriptions
		services.AddScoped<ISubscriptionService, SubscriptionService>();
        
		return services;
	}
    
	public static IRequestExecutorBuilder AddGraphQLServices(this IRequestExecutorBuilder builder)
	{
		// logs
		builder.RegisterService<IErrorLogService>();
		builder.RegisterService<IEntityLogService>();

		//claims
		builder.RegisterService<IClaimsUserService>();
		
		//media
		builder.RegisterService<IMediaStorageService>();
        
		//users
		builder.RegisterService<IUserService>();
		builder.RegisterService<IUserPermissionService>();
		
		//refresh token
		builder.RegisterService<IRefreshTokenService>();
        
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
		builder.RegisterService<IServiceService>();
		
		//serviceListing
		builder.RegisterService<IServiceListingService>();

		//client
		builder.RegisterService<IServiceProviderEntityService>();

		//user
		builder.RegisterService<IPlanService>();

		//payment
		builder.RegisterService<IPaymentService>();

		//subscription
		builder.RegisterService<ISubscriptionService>();
		return builder;
	}
}