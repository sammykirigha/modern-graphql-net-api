using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public static class ServiceQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Service> GetServices(IServiceService service) => service.GetList();
    
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ServicePaged> GetServicesPaged(IServiceService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static async Task<Service?> GetServiceById(IServiceService service, Guid id) => await service.GetByIdAsync(id);
}