

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
                    //ActiveServiceProviderId = u.ActiveServiceProviderId ?? sp.Id,
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
        // get data
        //var sp = await Context.ServiceProviders.FirstAsync();
        //var clients = await (
            //from c in Context.Clients
            //where c.ServiceProviderId == sp.Id
            //select c
        //).Take(3).ToListAsync();

        var curuser = await (
            from u in Context.Users
                //.Include(x => x.ServiceProviders)
                //.Include(x => x.Clients)
            where u.Id == user.Id
            select u
        ).AsNoTracking().FirstOrDefaultAsync();

        if (curuser != null)
        {
            //if (!curuser.ServiceProviders.Any(x => x.Id == sp.Id))
                //user.ServiceProviders.Add(sp);
            //foreach (var client in clients)
           // {
                //if (!curuser.Clients.Any(x => x.Id == client.Id))
                   // user.Clients.Add(client);
           // }
            Context.Users.Update(user);
        }
        else
        {
            //user.ServiceProviders.Add(sp);
            //clients.ForEach(x => user.Clients.Add(x));
            Context.Users.Add(user);
        }

        await Context.SaveChangesAsync();

        return user;
    }
}

