using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IClientRepository : IRepositoryBase
{
    Task<Client?> GetByIdAsync(Guid id);
    IQueryable<Client> GetList();
    Task<Client> AddAsync(Client entity);
    Task<Client> UpdateAsync(Client entity);
    Task<int> DeleteAsync(Guid id);
}