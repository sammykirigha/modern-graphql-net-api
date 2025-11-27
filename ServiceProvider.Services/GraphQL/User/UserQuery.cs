
using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Interfaces.Services.Users;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[QueryType]
public static class UserQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<User> GetUsers(IUserService service)
		=> service.GetList();
    
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<UserPaged> GetUsersPaged(IUserService service)
		=> service.GetListPaged();
    
	[UseSingleOrDefault]
	public static Task<User?> GetUserById(IUserService service, Guid id)
		=> service.GetByIdAsync(id);
}