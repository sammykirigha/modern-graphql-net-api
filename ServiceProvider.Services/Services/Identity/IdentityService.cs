
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services;

public class IdentityService : IIdentityService
{
	private readonly IIdentityRepository _repository;
	public IdentityService(IIdentityRepository repository)
	{
		_repository = repository;
	}
    
	public async Task<UserProfile?> GetUserProfileAsync(Guid userId)
	{
		var user = await _repository.GetUserProfileAsync(userId);
		return user;
	}

	public async Task<User> AddDevUserAsync(User user)
	{
		var devuser = await _repository.AddDevUserAsync(user);
		return devuser;
	}

	public async Task<bool> IsUserActiveAsync(Guid userId)
	{
		var status = await _repository.GetUserStatusAsync(userId);

		// user not found
		// user not active
		// user deleted
		if (status == null || !status.IsActive)
			return false;

		// user is active
		return true;
	}
}