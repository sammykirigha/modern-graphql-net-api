
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class RoleRepository(ServiceProviderContext context) 
    : RepositoryBase(context), IRoleRepository
{
    public async Task<Role?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Roles.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }
    
    public async Task<Role> GetByNameAsync(string name)
	{
		var entity = await Context.Roles.AsNoTracking().FirstOrDefaultAsync(x => x.Name == name);
		if (entity == null)
			throw new AppException($"Role with name '{name}' not found");
		return entity;
	}

    public IQueryable<Role> GetList() => from i in Context.Roles select i;

    public async Task<Role> AddAsync(Role entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<Role>(jsonString) ??
                        throw new AppException("Json conversion error for add Role");
         newentity.Id = Guid.NewGuid();
         newentity.DateCreated = DateTime.UtcNow;
         newentity.DateModified = DateTime.UtcNow;

         Context.Roles.Add(newentity);
         await Context.SaveChangesAsync();
         return newentity;
    }

    public async Task<Role> UpdateAsync(Role entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for Role update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Roles.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}

