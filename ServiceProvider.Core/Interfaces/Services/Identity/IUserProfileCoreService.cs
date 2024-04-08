
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IUserProfileCoreService
{
	UserProfile LoggedInUser { get; set; }
	UserProfile ActiveUser { get; set; }
}