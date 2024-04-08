
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IIdentityService
{
	Task<User> AddDevUserAsync(User user);
	Task<UserProfile?> GetUserProfileAsync(Guid userId);
	Task<bool> IsUserActiveAsync(Guid userId);
}