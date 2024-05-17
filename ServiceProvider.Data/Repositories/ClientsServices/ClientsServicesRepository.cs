using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories;

public class ClientsServicesRepository(ServiceProviderContext context) : RepositoryBase(context), IClientsServicesRepository
{

	public async   Task<ClientsServices> AddAsync(ClientsServices entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newEntity = JsonSerializer.Deserialize<ClientsServices>(jsonString) ??
		                throw new AppException("Json conversion error for add user");

		newEntity.Id = Guid.NewGuid();
		newEntity.DateCreated = DateTime.UtcNow;
		newEntity.DateCreated = DateTime.UtcNow;

		Context.ClientServices.Add(newEntity);
		await Context.SaveChangesAsync();

		return newEntity;
	}

	public async Task<int> DeleteAsync(Guid id)
	{
		var result = await Context.ClientServices.Where(x => x.Id == id).ExecuteDeleteAsync();
		return result;
	}

	public async Task<ClientsServices?> GetByIdAsync(Guid id)
	{
		var entity = await Context.ClientServices.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		return entity;
	}

	public IQueryable<ClientsServices> GetList() => from i in Context.ClientServices select i;

	public async Task<ClientsServices> UpdateAsync(ClientsServices entity)
	{
		if (entity.Id == Guid.Empty)
			throw new AppException("Id missing for the user to update");
		Context.Entry(entity).State = EntityState.Modified;
		entity.DateModified = DateTime.UtcNow;

		await Context.SaveChangesAsync();

		return entity;
	}
}