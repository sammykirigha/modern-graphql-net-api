using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Data.Contexts;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories;

public class ClientRepository(ServiceProviderContext context) : RepositoryBase(context), IClientRepository
{

	public async   Task<Client> AddAsync(Client entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newEntity = JsonSerializer.Deserialize<Client>(jsonString) ??
		                throw new AppException("Json conversion error for add user");

		newEntity.Id = Guid.NewGuid();
		newEntity.DateCreated = DateTime.UtcNow;
		newEntity.DateCreated = DateTime.UtcNow;

		Context.Clients.Add(newEntity);
		await Context.SaveChangesAsync();

		return newEntity;
	}

	public async Task<int> DeleteAsync(Guid id)
	{
		var result = await Context.Clients.Where(x => x.Id == id).ExecuteDeleteAsync();
		return result;
	}

	public async Task<Client?> GetByIdAsync(Guid id)
	{
		var entity = await Context.Clients.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		return entity;
	}

	public IQueryable<Client> GetList() => from i in Context.Clients select i;

	public async Task<Client> UpdateAsync(Client entity)
	{
		if (entity.Id == Guid.Empty)
			throw new AppException("Id missing for the user to update");
		Context.Entry(entity).State = EntityState.Modified;
		entity.DateModified = DateTime.UtcNow;

		await Context.SaveChangesAsync();

		return entity;
	}
}