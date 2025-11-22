

using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class IdentityRepository(ServiceProviderContext context) : RepositoryBase(context),  IIdentityRepository
{
    public async Task<UserProfile?> GetUserProfileAsync(Guid userId)
    {
        var profile = await (
            from u in Context.Users
            where u.Id == userId
            select new UserProfile
                {
                    UserId = u.Id,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    RoleId = u.RoleId,
                    // ActiveServiceProviderId = u.ActiveServiceProviderId ?? sp.Id,
                    //ActiveClientId = u.ActiveClientId ?? client.Id,
                    //ActiveUserId = u.ActiveUserId ?? u.Id,
                    //ActiveUserFirstName = u.ActiveUser != null ? u.ActiveUser.FirstName : u.FirstName,
                    //ActiveUserLastName = u.ActiveUser != null ? u.ActiveUser.LastName : u.LastName,
                }).FirstOrDefaultAsync();

        return profile;
    }
    
    public async Task<UserStatus?> GetUserStatusAsync(Guid userId)
    {
        var status = await (
            from u in Context.Users
            where u.Id == userId
            select new UserStatus
            {
                UserId = u.Id,
                IsActive = u.IsActive
            }).FirstOrDefaultAsync();

        return status;
    }
    
    public async Task<User> AddDevUserAsync(User user)
    {
        Context.Users.Add(user);

        await Context.SaveChangesAsync();

        return user;
    }

    public async Task<User?> GetUserByEmailAsync(string email)
    {
        return await Context.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.Email == email);
    }
}

