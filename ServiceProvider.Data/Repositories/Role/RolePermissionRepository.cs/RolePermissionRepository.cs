using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class RolePermissionRepository(ServiceProviderContext context) 
    : RepositoryBase(context), IRolePermissionRepository
{
    public async Task<RolePermission> AddAsync(RolePermission entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newEntity = JsonSerializer.Deserialize<RolePermission>(jsonString) ??
                        throw new AppException("Json conversion error for add RolePermission");

        newEntity.Id = Guid.NewGuid();
        newEntity.DateCreated = DateTime.UtcNow;
        newEntity.DateModified = DateTime.UtcNow;

        Context.RolePermissions.Add(newEntity);
        await Context.SaveChangesAsync();

        return newEntity;
    }

    public async Task<RolePermission?> GetByIdAsync(Guid id)
    {
        var entity = await Context.RolePermissions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<RolePermission> GetList() => from i in Context.RolePermissions select i;
    
    public async Task<RolePermission> UpdateAsync(RolePermission entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for RolePermission update");
        
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateCreated = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.RolePermissions.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}

