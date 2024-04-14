
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class LocationRepository(ServiceProviderContext context) 
    : RepositoryBase(context), ILocationRepository
{
    //
    public async Task<Location?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Locations.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<Location> GetList() => from i in Context.Locations select i;

    public async Task<Location> AddAsync(Location entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<Location>(jsonString) ??
                        throw new AppException("Json conversion error for add Location");
         newentity.Id = Guid.NewGuid();
         newentity.DateCreated = DateTime.UtcNow;
         newentity.DateModified = DateTime.UtcNow;

         Context.Locations.Add(newentity);
         await Context.SaveChangesAsync();
         return newentity;
    }

    public async Task<Location> UpdateAsync(Location entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for Location update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Locations.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}