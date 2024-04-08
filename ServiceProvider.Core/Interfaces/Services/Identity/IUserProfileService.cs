using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IUserProfileService
{
	UserProfile LoggedInUser { get; set; }
	UserProfile ActiveUser { get; set; }

	Task<UserProfile> AddDevUserAsync();
	Task<UserProfile> GetUserProfileAsync(Guid? id = null);
}