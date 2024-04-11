using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Services;

public class UserProfileCoreService : IUserProfileCoreService
{
	public UserProfile LoggedInUser { get; set; } = new UserProfile();
	public UserProfile ActiveUser { get; set; } = new UserProfile();
}