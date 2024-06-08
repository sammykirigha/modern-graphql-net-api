using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class SubscriptionRepository(ServiceProviderContext context) 
    : RepositoryBase(context), ISubscriptionRepository
{
    //
    public async Task<Subscription?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Subscriptions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<Subscription> GetList() => from i in Context.Subscriptions select i;

    public async Task<Subscription> AddAsync(Subscription entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<Subscription>(jsonString) ??
                        throw new AppException("Json conversion error for add Subscription");
         newentity.Id = Guid.NewGuid();
         newentity.DateCreated = DateTime.UtcNow;
         newentity.DateModified = DateTime.UtcNow;

         Context.Subscriptions.Add(newentity);
         await Context.SaveChangesAsync();
         return newentity;
    }

    public async Task<Subscription> UpdateAsync(Subscription entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for Subscription update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Subscriptions.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}

