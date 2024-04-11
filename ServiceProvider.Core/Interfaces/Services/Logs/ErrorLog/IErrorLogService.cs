
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IErrorLogService
{
    
	Task<ErrorLog> LogErrorAsync(ErrorLog log);
	Task<ErrorLog> LogErrorAsync(Exception error);
	Task<ErrorLog> LogErrorAsync(string type, string message, string data);


	// QUERIES
	Task<ErrorLog?> GetByIdAsync(Guid id);

	IQueryable<ErrorLog> GetList();

	IQueryable<ErrorLogPaged> GetPagedList();
}