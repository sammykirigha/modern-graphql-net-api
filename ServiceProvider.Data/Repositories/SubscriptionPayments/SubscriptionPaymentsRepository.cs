using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class SubscriptionPaymentsRepository(ServiceProviderContext context) 
    : RepositoryBase(context), ISubscriptionPaymentsRepository
{
    //
    public async Task<SubscriptionPayments?> GetByIdAsync(Guid id)
    {
        var entity = await Context.SubscriptionPayments.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<SubscriptionPayments> GetList() => from i in Context.SubscriptionPayments select i;

    public async Task<SubscriptionPayments> AddAsync(SubscriptionPayments entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<SubscriptionPayments>(jsonString) ??
                        throw new AppException("Json conversion error for add SubscriptionPayments");
         newentity.Id = Guid.NewGuid();
         newentity.DateCreated = DateTime.UtcNow;
         newentity.DateModified = DateTime.UtcNow;

         Context.SubscriptionPayments.Add(newentity);
         await Context.SaveChangesAsync();
         return newentity;
    }

    public async Task<SubscriptionPayments> UpdateAsync(SubscriptionPayments entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for SubscriptionPayments update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.SubscriptionPayments.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}

