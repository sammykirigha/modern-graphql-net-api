using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class ServiceRepository(ServiceProviderContext context) : RepositoryBase(context), IServiceRepository
{
    public async Task<Service> AddAsync(Service entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newEntity = JsonSerializer.Deserialize<Service>(jsonString) ??
                        throw new AppException("Json conversion error for add Service");

        newEntity.Id = Guid.NewGuid();
        newEntity.DateCreated = DateTime.UtcNow;
        newEntity.DateCreated = DateTime.UtcNow;

        Context.Services.Add(newEntity);
        await Context.SaveChangesAsync();

        return newEntity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Services.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }

    public async Task<Service?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Services.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<Service> GetList() => from i in Context.Services select i;

    public async Task<Service> UpdateAsync(Service entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for the Service to update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;

        await Context.SaveChangesAsync();

        return entity;
    }
}
