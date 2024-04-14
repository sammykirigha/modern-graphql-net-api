using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using Location = ServiceProvider.Core.Models.Location;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[QueryType]
public static class LocationQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Location> GetLocations(ILocationService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<LocationPaged> GetLocationsPaged(ILocationService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<Location?> GetLocationById(ILocationService service, Guid id)
		=> service.GetByIdAsync(id);
}