using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories;

public class ConstituencyRepository(ServiceProviderContext Context): RepositoryBase(Context), IConstituencyRepository
{
	public async Task<Constituency?> GetByIdAsync(Guid id)
	{
		var entity = await Context.Constituencies.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		return entity;
	}	
	
	public async Task<Constituency?> GetByNameAsync(string Name)
	{
		var entity = await Context.Constituencies.AsNoTracking().FirstOrDefaultAsync(x => x.ConstituencyName == Name);
		return entity;
	}

	public IQueryable<Constituency> GetList() => from i in Context.Constituencies select i;

	public async Task<Constituency> AddAsync(Constituency entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newentity = JsonSerializer.Deserialize<Constituency>(jsonString) ??
		                throw new AppException("Json conversion error for add ConstituencyRepository");
		newentity.Id = Guid.NewGuid();
		newentity.DateCreated = DateTime.UtcNow;
		newentity.DateModified = DateTime.UtcNow;

		Context.Constituencies.Add(newentity);
		await Context.SaveChangesAsync();
		return newentity;
	}
}