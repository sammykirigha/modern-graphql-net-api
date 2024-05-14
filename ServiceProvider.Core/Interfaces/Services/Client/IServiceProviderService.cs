using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IClientService
{
	Task<Client?> GetByIdAsync(Guid id);
	IQueryable<Client> GetList();
	IQueryable<ClientPaged> GetPagedList();
	Task<Client> AddAsync(Client entity, EntityLogInfo logInfo);
	Task<Client> UpdateAsync(Client entity, EntityLogInfo logInfo, Client? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}