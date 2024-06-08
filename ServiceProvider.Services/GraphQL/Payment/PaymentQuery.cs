using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public static class PaymentQuery
{
    [UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Payment> GetPayments(IPaymentService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<PaymentPaged> GetPaymentsPaged(IPaymentService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<Payment?> GetPaymentById(IPaymentService service, Guid id)
		=> service.GetByIdAsync(id);
}