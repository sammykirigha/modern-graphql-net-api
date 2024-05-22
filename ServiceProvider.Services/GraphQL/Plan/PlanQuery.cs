// using HotChocolate.Authorization;
// using ServiceProvider.Core.Interfaces.Services;
// using ServiceProvider.Core.Models;

// namespace ServiceProvider.Services.GraphQL;
// [Authorize]
// [QueryType]
// public static class PlanQuery
// {
//     [UseProjection]
// 	[UseFiltering]
// 	[UseSorting]
// 	public static IQueryable<Plan> GetLocations(IPlanService service) => service.GetList();
    
// 	[UsePaging]
// 	[UseProjection]
// 	[UseFiltering]
// 	[UseSorting]
// 	public static IQueryable<PlanPaged> GetPlansPaged(IPlanService service) => service.GetPagedList();
    
// 	[UseSingleOrDefault]
// 	public static Task<Plan?> GetPlanById(IPlanService service, Guid id)
// 		=> service.GetByIdAsync(id);
// }