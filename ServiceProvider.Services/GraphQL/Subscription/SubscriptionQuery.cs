using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public static class SubscriptionQuery
{
    [UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Subscription> GetSubscriptions(ISubscriptionService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<SubscriptionPaged> GetSubscriptionsPaged(ISubscriptionService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<Subscription?> GetSubscriptionById(ISubscriptionService service, Guid id)
		=> service.GetByIdAsync(id);
}