using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class UserRepository(ServiceProviderContext context) : RepositoryBase(context), IUserRepository
{
    public async Task<User> AddAsync(User entity)
    {
        Context.Users.Add(entity);

        await Context.SaveChangesAsync();
        
        return entity;

    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Users.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }
    public async Task<User?> GetByEmailAsync(string email)
    {
        var entity = await Context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Email == email);
        return entity;
    }

    public IQueryable<User> GetList() => from i in Context.Users select i;

    public async Task<User> UpdateAsync(User entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for the user to update");

        Context.Entry(entity).State = EntityState.Modified;

        entity.DateModified = DateTime.UtcNow;

        await Context.SaveChangesAsync();

        return entity;
    }
}
