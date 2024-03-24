
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IErrorLogRepository : IRepositoryBase
{
    Task<ErrorLog?> GetByIdAsync(Guid id);
    IQueryable<ErrorLog> GetList();
    Task<ErrorLog> AddAsync(ErrorLog entity);
    Task<ErrorLog> UpdateAsync(ErrorLog entity);
    Task<bool> DeleteAsync(Guid id);
}

