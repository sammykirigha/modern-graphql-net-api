using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.GraphQL;
[Authorize]
[QueryType]
public static class ServiceListingsQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ServiceListing> GetListings(IServiceListingService service) => service.GetList();
}