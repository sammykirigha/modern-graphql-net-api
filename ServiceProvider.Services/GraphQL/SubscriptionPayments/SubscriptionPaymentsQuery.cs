using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public static class SubscriptionPaymentsQuery
{
    [UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<SubscriptionPayments> GetSubscriptionPaymentss(ISubscriptionPaymentsService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<SubscriptionPaymentsPaged> GetSubscriptionPaymentssPaged(ISubscriptionPaymentsService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<SubscriptionPayments?> GetSubscriptionPaymentsById(ISubscriptionPaymentsService service, Guid id)
		=> service.GetByIdAsync(id);
}