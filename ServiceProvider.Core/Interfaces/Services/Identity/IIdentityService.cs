
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IIdentityService
{
	Task<User> AddDevUserAsync();
	Task<UserProfile?> GetUserProfileAsync(Guid userId);
	Task<bool> IsUserActiveAsync(Guid userId);
	Task<string?> LoginAsync(string email, string password);
}