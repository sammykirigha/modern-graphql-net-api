using System.Formats.Asn1;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class EntityLogRepository(ServiceProviderContext context) : RepositoryBase(context), IEntityLogRepository
{
    public async Task<EntityLog?> GetByIdAsync(Guid id)
    {
        var entity = await Context.EntityLogs.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }
    
    //
    public IQueryable<EntityLog> GetList() => from i in Context.EntityLogs select i;

    public async Task<EntityLog> AddAsync(EntityLog entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<EntityLog>(jsonString) 
                        ?? throw new AppException("Json conversion error for the added entity");
        newentity.Id = Guid.NewGuid();
        newentity.DateCreated = DateTime.UtcNow;
        Context.EntityLogs.Add(newentity);
        await Context.SaveChangesAsync();

        return newentity;
    }

    public async Task<EntityLog> UpdateAsync(EntityLog entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for updating entity");
        Context.Entry(entity).State = EntityState.Modified;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.EntityLogs.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}

