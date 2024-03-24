

using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;

namespace ServiceProvider.Data.Repositories;

public class RepositoryBase(ServiceProviderContext context) : IRepositoryBase
{
    protected ServiceProviderContext Context {get; } = context;

    public async Task<ServiceProviderTransaction> BeginTransactionAsync()
    {
        var trans = new ServiceProviderTransaction
        {
          IsNested = Context.Database.CurrentTransaction != null
        };

        if (!trans.IsNested)
            trans.Transaction = await Context.Database.BeginTransactionAsync();
        return trans;
    }
}