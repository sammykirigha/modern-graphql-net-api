
using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public class ServiceLocationQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ServiceLocation> GetServiceLocations(IServiceLocationService service)
		=> service.GetList();
    
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ServiceLocationPaged> GetServiceLocationsPaged(IServiceLocationService service)
		=> service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<ServiceLocation?> GetServiceLocationsById(IServiceLocationService service, Guid id)
		=> service.GetByIdAsync(id);
}