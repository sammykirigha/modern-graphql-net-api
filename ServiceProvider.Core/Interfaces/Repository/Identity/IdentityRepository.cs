using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IIdentityRepository : IRepositoryBase
{
    Task<User> AddDevUserAsync(User user);
    Task<UserProfile> GetUserProfileAsync(Guid userId);
    Task<UserStatus> GetUserStatusAsync(Guid userId);
}

