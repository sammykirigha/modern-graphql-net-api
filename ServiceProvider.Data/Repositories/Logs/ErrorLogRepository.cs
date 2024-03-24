using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class ErrorLogRepository(ServiceProviderContext context) : RepositoryBase(context), IErrorLogRepository
{
    public async Task<ErrorLog> AddAsync(ErrorLog entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newentity = JsonSerializer.Deserialize<ErrorLog>(jsonString) ??
                        throw new AppException("Json conversion error for add entity");
        newentity.Id = Guid.NewGuid();
        newentity.DateCreated = DateTime.UtcNow;

        Context.ErrorLogs.Add(newentity);
        await Context.SaveChangesAsync();

        return entity;
    }

    public IQueryable<ErrorLog> GetList() => from i in Context.ErrorLogs select i;

    public async Task<ErrorLog?> GetByIdAsync(Guid id)
    {
        var result = await Context.ErrorLogs.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return result;
    }

    public async Task<ErrorLog> UpdateAsync(ErrorLog entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Missing id for the updating entity");
        Context.Entry(entity).State = EntityState.Modified;
        await Context.SaveChangesAsync();

        return entity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.ErrorLogs.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }
}

