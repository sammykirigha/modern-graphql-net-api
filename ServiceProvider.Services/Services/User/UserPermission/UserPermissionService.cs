using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services;

public class UserPermissionService: IUserPermissionService
{
    private readonly IUserPermissionRepository _repository;
    private readonly IEntityLogService _log;

    public UserPermissionService(
        IUserPermissionRepository repository,
        IEntityLogService log)
    {
        _repository = repository;
        _log = log;
    }


    // QUERIES
    public async Task<UserPermission?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity;
    }

    public IQueryable<UserPermission> GetList()
    {
        return _repository.GetList().AsNoTracking();
    }

    public IQueryable<UserPermissionPaged> GetPagedList()
    {
        return (
            from u in _repository.GetList()
            select new UserPermissionPaged
            {
                UserPermission = u
            }
        ).AsNoTracking();
    }


    // MUTATIONS
    public async Task<UserPermission> AddAsync(UserPermission input, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.AddAsync(input);
        await _log.LogAddAsync(logInfo, entity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<UserPermission> UpdateAsync(UserPermission input, EntityLogInfo logInfo, UserPermission? oldEntity = null)
    {
        using var trans = await _repository.BeginTransactionAsync();

        oldEntity ??= await _repository.GetByIdAsync(input.Id)
                      ?? throw new AppException($"{nameof(UserPermission)} not found.", ValidationCode.MissingRequirementEntity);
        var entity = await _repository.UpdateAsync(input);
        await _log.LogUpdateAsync(logInfo, entity, oldEntity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(UserPermission)} not found.", ValidationCode.MissingRequirementEntity);
        var result = await _repository.DeleteAsync(id);
        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }
}