using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IClientsServicesService
{
	Task<ClientsServices?> GetByIdAsync(Guid id);
	IQueryable<ClientsServices> GetList();
	IQueryable<ClientsServicesPaged> GetPagedList();
	Task<ClientsServices> AddAsync(ClientsServices entity, EntityLogInfo logInfo);
	Task<ClientsServices> UpdateAsync(ClientsServices entity, EntityLogInfo logInfo, ClientsServices? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}