using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IClientServiceRepository : IRepositoryBase
{
    Task<ClientService?> GetByIdAsync(Guid id);
    IQueryable<ClientService> GetList();
    Task<ClientService> AddAsync(ClientService entity);
    Task<ClientService> UpdateAsync(ClientService entity);
    Task<int> DeleteAsync(Guid id);
}