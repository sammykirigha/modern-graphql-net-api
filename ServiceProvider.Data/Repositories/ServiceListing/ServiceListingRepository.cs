using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.DTOs.ServiceListing;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories;

public class ServiceListingRepository(ServiceProviderContext Context) : RepositoryBase(Context) , IServiceListingRepository
{
public async Task<ServiceListing> AddAsync(CreateServiceListingDto entity)
{
	var jsonString = JsonSerializer.Serialize(entity);
	var newEntity = JsonSerializer.Deserialize<ServiceListing>(jsonString) ??
	                throw new AppException("Json conversion error for add ServiceListing");

	newEntity.Id = Guid.NewGuid();
	newEntity.DateCreated = DateTime.UtcNow;
	newEntity.DateCreated = DateTime.UtcNow;

	Context.ServiceListings.Add(newEntity);
	await Context.SaveChangesAsync();

	return newEntity;
}

public async Task<ServiceListing> GetByIdWithServicesAsync(Guid id)
{
	var entity = await Context.ServiceListings
		.Where(sl => sl.Id == id).Include(sl => sl.ServiceListingsServices)
		.FirstOrDefaultAsync();
	return entity ?? throw new AppException($"ServiceListing with Id {id} not found");
}

public async Task<int> DeleteAsync(Guid id)
{
	var result = await Context.ServiceListings.Where(x => x.Id == id).ExecuteDeleteAsync();
	return result;
}

public async Task<ServiceListing?> GetByIdAsync(Guid id)
{
	var entity = await Context.ServiceListings.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
	return entity;
}

public IQueryable<ServiceListing> GetList() => from i in Context.ServiceListings select i;

public async Task<ServiceListing> UpdateAsync(ServiceListing entity)
{
	if (entity.Id == Guid.Empty)
		throw new AppException("Id missing for the Service to update");
	Context.Entry(entity).State = EntityState.Modified;
	entity.DateModified = DateTime.UtcNow;

	await Context.SaveChangesAsync();

	return entity;
}
}