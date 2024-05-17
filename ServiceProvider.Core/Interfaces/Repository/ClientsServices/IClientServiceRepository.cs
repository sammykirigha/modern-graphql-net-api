using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IClientsServicesRepository : IRepositoryBase
{
    Task<ClientsServices?> GetByIdAsync(Guid id);
    IQueryable<ClientsServices> GetList();
    Task<ClientsServices> AddAsync(ClientsServices entity);
    Task<ClientsServices> UpdateAsync(ClientsServices entity);
    Task<int> DeleteAsync(Guid id);
}