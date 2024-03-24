
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IRepositoryBase
{
    Task<ServiceProviderTransaction> BeginTransactionAsync();
}

