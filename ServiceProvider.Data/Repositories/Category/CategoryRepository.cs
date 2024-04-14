
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class CategoryRepository(ServiceProviderContext context) 
    : RepositoryBase(context), ICategoryRepository
{
    //
    public async Task<Category?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<Category> GetList() => from i in Context.Categories select i;

    public async Task<Category> AddAsync(Category entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<Category>(jsonString) ??
                        throw new AppException("Json conversion error for add Category");
         newentity.Id = Guid.NewGuid();
         newentity.DateCreated = DateTime.UtcNow;
         newentity.DateModified = DateTime.UtcNow;

         Context.Categories.Add(newentity);
         await Context.SaveChangesAsync();
         return newentity;
    }

    public async Task<Category> UpdateAsync(Category entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for Category update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Categories.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}