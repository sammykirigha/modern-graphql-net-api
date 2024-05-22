
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class PaymentRepository(ServiceProviderContext context) 
    : RepositoryBase(context), IPaymentRepository
{
    //
    public async Task<Payment?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Payments.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<Payment> GetList() => from i in Context.Payments select i;

    public async Task<Payment> AddAsync(Payment entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<Payment>(jsonString) ??
                        throw new AppException("Json conversion error for add Payment");
         newentity.Id = Guid.NewGuid();
         newentity.DateCreated = DateTime.UtcNow;
         newentity.DateModified = DateTime.UtcNow;

         Context.Payments.Add(newentity);
         await Context.SaveChangesAsync();
         return newentity;
    }

    public async Task<Payment> UpdateAsync(Payment entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for Payment update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Payments.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}

