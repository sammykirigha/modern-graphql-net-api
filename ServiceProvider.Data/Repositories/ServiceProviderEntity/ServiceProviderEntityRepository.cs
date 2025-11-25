using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;

using System.Text.Json;

namespace ServiceProvider.Data.Repositories;

public class ServiceProviderEntityRepository(ServiceProviderContext context) : RepositoryBase(context), IServiceProviderEntityRepository
{

	public async   Task<ServiceProviderEntity> AddAsync(ServiceProviderEntity entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newEntity = JsonSerializer.Deserialize<ServiceProviderEntity>(jsonString) ??
		                throw new AppException("Json conversion error for add user");

		newEntity.Id = Guid.NewGuid();
		newEntity.DateCreated = DateTime.UtcNow;
		newEntity.DateCreated = DateTime.UtcNow;

		Context.ServiceProviders.Add(newEntity);
		await Context.SaveChangesAsync();

		return newEntity;
	}

	public async Task<int> DeleteAsync(Guid id)
	{
		var result = await Context.ServiceProviders.Where(x => x.Id == id).ExecuteDeleteAsync();
		return result;
	}

	public async Task<ServiceProviderEntity?> GetByIdAsync(Guid id)
	{
		var entity = await Context.ServiceProviders.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		return entity;
	}

	public IQueryable<ServiceProviderEntity> GetList() => from i in Context.ServiceProviders select i;

	public async Task<ServiceProviderEntity> UpdateAsync(ServiceProviderEntity entity)
	{
		if (entity.Id == Guid.Empty)
			throw new AppException("Id missing for the user to update");
		Context.Entry(entity).State = EntityState.Modified;
		entity.DateModified = DateTime.UtcNow;

		await Context.SaveChangesAsync();

		return entity;
	}
}