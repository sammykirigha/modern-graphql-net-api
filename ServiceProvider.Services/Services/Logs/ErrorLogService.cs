using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services;

public class ErrorLogService : IErrorLogService
{
    private readonly IErrorLogRepository _repository;
    private readonly IUserProfileService _userProfileService;

    public ErrorLogService(
        IErrorLogRepository errorLogRepository,
        IUserProfileService userProfileService)
    {
        _repository = errorLogRepository;
        _userProfileService = userProfileService;
    }
    
    public async Task<ErrorLog> LogErrorAsync(ErrorLog log)
    {
        var newlog = await _repository.AddAsync(log);
        return newlog;
    }
    
    public async Task<ErrorLog> LogErrorAsync(Exception error)
    {
        var newlog = await LogErrorAsync(
            (error.Source ?? string.Empty).MaxLength(100),
            error.Message.MaxLength(1000),
            error.ToString());
        return newlog;
    }
    
    public async Task<ErrorLog> LogErrorAsync(string type, string message, string data)
    {
        var profile = _userProfileService.ActiveUser;

        var log = new ErrorLog
        {
            Type = type,
            Message = message,
            Data = data,

            ActiveUserId = profile.UserId != Guid.Empty ? profile.ActiveUserId : null,
            ActiveUserName = profile.ActiveUserFullName.MaxLength(100),
            LoggedInUserId = profile.UserId != Guid.Empty ? profile.UserId : null,
            LoggedInUserName = profile.FullName.MaxLength(100)
        };

        var newlog = await _repository.AddAsync(log);
        return newlog;
    }
    
    // QUERIES
    // QUERIES
    public async Task<ErrorLog?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity;
    }

    public IQueryable<ErrorLog> GetList()
    {
        return _repository.GetList().AsNoTracking();
    }

    public IQueryable<ErrorLogPaged> GetPagedList()
    {
        return (
            from u in _repository.GetList()
            select new ErrorLogPaged
            {
                ErrorLog = u
            }
        ).AsNoTracking();
    }
}