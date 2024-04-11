
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ServiceProvider;
using ServiceProvider.Data.Contexts;

namespace Microsoft.Extensions.DependencyInjection;

public static class GraphQLConfigurationExtensions
{
	public static IServiceCollection AddGraphQLConfig(this IServiceCollection services, IWebHostEnvironment environment)
	{
		services
			.AddGraphQLServer()
			.ModifyRequestOptions(opt =>
				opt.IncludeExceptionDetails = environment.IsDevelopment() || environment.IsStaging())
			.AddAuthorization()
			.AddProjections()
			.AddFiltering()
			.AddSorting()
			.RegisterDbContext<ServiceProviderContext>(DbContextKind.Synchronized)
			.AddGraphQLServices();
			//.AddServicesTypes();

		return services;
	}
}