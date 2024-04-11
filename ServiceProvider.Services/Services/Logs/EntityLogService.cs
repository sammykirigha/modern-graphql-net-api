
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Models;
using ServiceProvider.Core.Interfaces.Models.Logs;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services;

public class EntityLogService(
    IEntityLogRepository _repository, 
    IUserProfileCoreService _userProfileService
    ) : IEntityLogService
{
    public async Task<EntityLog> LogChangeAsync(EntityLog log)
    {
        var newlog = await _repository.AddAsync(log);
        return newlog;
    }
    
    public async Task<ICollection<EntityLog>> LogChangesAsync(ICollection<EntityLog> logs)
    {
        var newlogs = await _repository.AddListAsync(logs);
        return newlogs;
    }
    
    public async Task<EntityLog> LogInfoAsync<T>(EntityLogInfo info, T newEntity, UserProfile? user = null)
        where T : IEntity?
    {
        var log = BuildLog(LogChangeType.Info, info, newEntity, default, user);
        return await LogChangeAsync(log);
    }

    public async Task<ICollection<EntityLog>> LogInfoListAsync<T>(EntityLogInfo info, ICollection<T> newEntityList,
        UserProfile? user = null)
        where T : IEntity?
    {
        using var trans = await _repository.BeginTransactionAsync();
        var list = new List<EntityLog>();
        foreach (var newEntity in newEntityList)
        {
            var log = BuildLog(LogChangeType.Info, info, newEntity, default, user);
            list.Add(log);
        }
        
        var newlogs = await LogChangesAsync(list);

        await trans.CommitAsync();
        return newlogs;
    }
    
    //ADD
    public async Task<EntityLog> LogAddAsync<T>(EntityLogInfo info, T newEntity, UserProfile? user = null)
        where T : IEntity?
    {
        var log = BuildLog(LogChangeType.Add, info, newEntity, default, user);
        return await LogChangeAsync(log);
    }

    public async Task<ICollection<EntityLog>> LogAddListAsync<T>(EntityLogInfo info, ICollection<T> newEntityList,
        UserProfile? user = null)
        where T : IEntity?
    {
        if (newEntityList.Count == 0)
            return new List<EntityLog>();
        
        using var trans = await _repository.BeginTransactionAsync();
        var list = new List<EntityLog>();
        foreach (var newEntity in newEntityList)
        {
            var log = BuildLog(LogChangeType.Add, info, newEntity, default, user);
            list.Add(log);
        }
        var newLogs = await LogChangesAsync(list);
        await trans.CommitAsync();
        return newLogs;
    }
    
    public async Task<EntityLog> LogUpdateAsync<T>(EntityLogInfo info, T newEntity, T? oldEntity, UserProfile? user = null)
        where T : IEntity?
    {
        var log = BuildLog(LogChangeType.Update, info, newEntity, oldEntity, user);
        return await LogChangeAsync(log);
    }

    public async Task<ICollection<EntityLog>> LogUpdateListAsync<T>(EntityLogInfo info, ICollection<EntityLogUpdatedItem<T>> updateEntityList, UserProfile? user = null)
        where T : IEntity?
    {
        if (updateEntityList.Count == 0)
            return new List<EntityLog>();

        using var trans = await _repository.BeginTransactionAsync();

        var list = new List<EntityLog>();
        foreach (var updItem in updateEntityList)
        {
            var log = BuildLog(LogChangeType.Update, info, updItem.NewEntity, updItem.OldEntity, user);
            list.Add(log);
        }
        var newlogs = await LogChangesAsync(list);

        await trans.CommitAsync();

        return newlogs;
    }
    
    public ICollection<EntityLogUpdatedItem<T>> BuildUpdateEntityList<T>(ICollection<T> newEntityList, ICollection<T?> oldEntityList)
        where T : IEntity?
    {
        var list = newEntityList
            .Where(newItem => newItem != null)
            .Select(newItem =>
            {
              var oldItem = oldEntityList.FirstOrDefault(old => old?.Id == newItem?.Id);
              return new EntityLogUpdatedItem<T>
              {
                  OldEntity = oldItem,
                  NewEntity = newItem
              };
            }).ToList();

        return list;
    }
    
    // DELETE
    public async Task<EntityLog> LogDeleteAsync<T>(EntityLogInfo info, T deletedEntity, UserProfile? user = null)
        where T : IEntity?
    {
        var log = BuildLog(LogChangeType.Delete, info, deletedEntity, default, user);
        return await LogChangeAsync(log);
    }

    public async Task<ICollection<EntityLog>> LogDeleteListAsync<T>(EntityLogInfo info, ICollection<T> deletedEntityList,
        UserProfile? user = null)
        where T : IEntity?
    {
        if (deletedEntityList.Count == 0)
            return new List<EntityLog>();
        using var trans = await _repository.BeginTransactionAsync();

        var list = new List<EntityLog>();
        foreach (var deletedEntity in deletedEntityList)
        {
            var log = BuildLog(LogChangeType.Delete, info, deletedEntity, default, user);
            list.Add(log);
        }
        var newLogs = await LogChangesAsync(list);
        await trans.CommitAsync();
        return newLogs;
    }
    
    // queries
    public async Task<EntityLog> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity;
    }
    
    public IQueryable<EntityLog> GetList()
    {
        return _repository.GetList().AsNoTracking();
    }
    
    public IQueryable<EntityLogPaged> GetPagedList()
    {
        return (
            from l in _repository.GetList()
            select new EntityLogPaged
            {
                EntityLog = l
            }
        ).AsNoTracking();
    }
    
    
    // PRIVATE METHODS
    private EntityLog BuildLog<T>(LogChangeType changeType, IEntityLogInfo info, T newEntity, T? oldEntity, UserProfile? user = null)
        where T : IEntity?
    {
        if (newEntity == null)
            throw new ArgumentNullException(nameof(newEntity));

        var log = new EntityLog
        {
            Id = Guid.NewGuid(),
            //ServiceProviderId = user?.ActiveServiceProviderId ?? _actionContext.ServiceProviderId,
            //ClientId = user?.ActiveClientId ?? _actionContext.ClientId,
            Entity = typeof(T).Name,
            PrimaryKey = newEntity.Id,
            Category = info.Category,
            ChangeType = changeType,
            ChangeTrigger = info.ChangeTrigger,
            ChangeReason = info.ChangeReason,
            //OldData = oldEntity.Serialize(),
            NewData = newEntity.Serialize(),
            ActiveUserId = user?.ActiveUserId ?? _userProfileService.LoggedInUser.ActiveUserId,
            ActiveUserName = user?.ActiveUserFullName ?? _userProfileService.LoggedInUser.ActiveUserFullName,
            LoggedInUserId = user?.UserId.ToNullIfDefault() ?? _userProfileService.LoggedInUser.UserId.ToNullIfDefault(),
            LoggedInUserName = user?.FullName.IsEMpty(_userProfileService.LoggedInUser.FullName)
        };

        // determine changes
        if (oldEntity != null)
        {
            var changes = new List<EntityLogChange>();
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                if (prop.Name.Equals("DateModified", StringComparison.OrdinalIgnoreCase))
                    continue;

                var oldval = prop.GetValue(oldEntity, null);
                var newval = prop.GetValue(newEntity, null);
                if (oldval.Serialize() != newval.Serialize())
                {
                    changes.Add(new EntityLogChange
                    {
                        Name = prop.Name,
                        OldValue = oldval,
                        NewValue = newval
                    });
                }
            }
            log.Changes = changes.Serialize();
        }

        return log;
    }
}