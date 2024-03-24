

using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class UserPermissionRepository(ServiceProviderContext context)
    : RepositoryBase(context), IUserPermissionRepository
{
    public async Task<UserPermission> AddAsync(UserPermission entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newEntity = JsonSerializer.Deserialize<UserPermission>(jsonString) 
                        ?? throw new AppException("Json conversion error for add user permission");
        
        newEntity.Id = Guid.NewGuid();
        newEntity.DateCreated = DateTime.UtcNow;

        Context.UserPermissions.Add(newEntity);
        await Context.SaveChangesAsync();

        return newEntity;

    }
    
    //Delete
    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.UserPermissions.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }

    public async Task<UserPermission?> GetByIdAsync(Guid id)
    {
        var entity = await Context.UserPermissions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<UserPermission> GetList() => from i in Context.UserPermissions select i;

    public async Task<UserPermission> UpdateAsync(UserPermission entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for UserPermission update");

        Context.Entry(entity).State = EntityState.Modified;
        entity.DateCreated = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }
}

