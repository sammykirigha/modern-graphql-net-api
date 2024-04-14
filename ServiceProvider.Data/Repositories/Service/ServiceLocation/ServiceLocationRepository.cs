
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class ServiceLocationRepository(ServiceProviderContext context) : RepositoryBase(context), IServiceLocationRepository
{
    public async Task<ServiceLocation> AddAsync(ServiceLocation entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newEntity = JsonSerializer.Deserialize<ServiceLocation>(jsonString) ??
                        throw new AppException("Json conversion error for add ServiceLocation");

        newEntity.Id = Guid.NewGuid();
        newEntity.DateCreated = DateTime.UtcNow;
        newEntity.DateCreated = DateTime.UtcNow;

        Context.ServiceLocations.Add(newEntity);
        await Context.SaveChangesAsync();

        return newEntity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.ServiceLocations.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }

    public async Task<ServiceLocation?> GetByIdAsync(Guid id)
    {
        var entity = await Context.ServiceLocations.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<ServiceLocation> GetList() => from i in Context.ServiceLocations select i;

    public async Task<ServiceLocation> UpdateAsync(ServiceLocation entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for the ServiceLocation to update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;

        await Context.SaveChangesAsync();

        return entity;
    }
}
