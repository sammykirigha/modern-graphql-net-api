﻿
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class UserRepository(ServiceProviderContext context) : RepositoryBase(context), IUserRepository
{
    public async Task<User> AddAsync(User entity)
    {
        var jsonString = JsonSerializer.Serialize(entity);
        var newEntity = JsonSerializer.Deserialize<User>(jsonString) ??
                        throw new AppException("Json conversion error for add user");

        newEntity.Id = Guid.NewGuid();
        newEntity.DateCreated = DateTime.UtcNow;
        newEntity.DateCreated = DateTime.UtcNow;

        Context.Users.Add(newEntity);
        await Context.SaveChangesAsync();

        return newEntity;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var result = await Context.Users.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result;
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        var entity = await Context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public IQueryable<User> GetList() => from i in Context.Users select i;

    public async Task<User> UpdateAsync(User entity)
    {
        if (entity.Id == Guid.Empty)
            throw new AppException("Id missing for the user to update");
        Context.Entry(entity).State = EntityState.Modified;
        entity.DateModified = DateTime.UtcNow;

        await Context.SaveChangesAsync();

        return entity;
    }
}
