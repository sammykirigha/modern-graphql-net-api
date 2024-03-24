
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Data.Repositories;

public class PermissionRepository(ServiceProviderContext context) : RepositoryBase(context), IPermissionRepository
{
    public async Task<Permission?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Permissions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<Permission> GetList() => from i in Context.Permissions select i;

    public async Task<Permission> AddAsync(Permission entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<Permission>(jsonString) ??
                        throw new AppException("Json conversion error for add RolePermission");

        newentity.Id = Guid.NewGuid();
        newentity.DateCreated = DateTime.UtcNow;
        newentity.DateModified = DateTime.UtcNow;

        Context.Permissions.Add(newentity);
        await Context.SaveChangesAsync();

        return newentity;
    }

    public async Task<Permission> UpdateAsync(Permission entity)
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
        var result = await Context.Permissions.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}