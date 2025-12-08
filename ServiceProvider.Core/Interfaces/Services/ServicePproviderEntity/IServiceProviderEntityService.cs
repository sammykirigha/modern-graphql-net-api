using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Models.ServiceProvider;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IServiceProviderEntityService
{
	Task<ServiceProviderEntity?> GetByIdAsync(Guid id);
	IQueryable<ServiceProviderEntity> GetList();
	IQueryable<ServiceProviderEntityPaged> GetPagedList();
	Task<ServiceProviderEntity> AddAsync(ServiceProviderEntity entity, EntityLogInfo logInfo);
	Task<ServiceProviderEntity> UpdateAsync(ServiceProviderEntity entity, EntityLogInfo logInfo, ServiceProviderEntity? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
	Task<LoginResponseDto> ActivateAccountAndResetPassword(string token, string newPassword, string confirmPassword);
}