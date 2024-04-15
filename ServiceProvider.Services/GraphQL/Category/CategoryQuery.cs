using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[QueryType]
public static class CategoryQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Category> GetCategories(ICategoryService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<CategoryPaged> GetCategorysPaged(ICategoryService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<Category?> GetCategoryById(ICategoryService service, Guid id)
		=> service.GetByIdAsync(id);
}