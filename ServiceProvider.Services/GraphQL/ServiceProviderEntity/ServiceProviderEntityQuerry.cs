using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;


using ServiceProvider.Core.Models.ServiceProvider;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public static class ServiceProviderEntityQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ServiceProviderEntity> GetServiceProviders(IServiceProviderEntityService service) => service.GetList();
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ServiceProviderEntityPaged> GetServiceProvidersPaged(IServiceProviderEntityService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static async Task<ServiceProviderEntity?> GetServiceProviderById(IServiceProviderEntityService service, Guid id) => await service.GetByIdAsync(id);
}