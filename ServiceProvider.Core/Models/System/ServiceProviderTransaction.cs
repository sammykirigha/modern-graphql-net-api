
using Microsoft.EntityFrameworkCore.Storage;

namespace  ServiceProvider.Core.Models;

public partial class ServiceProviderTransaction : IDisposable
{
    // <summary>
    // Indicates if a transaction already exists for this context
    // <summary>
    public bool IsNested { get; set; }
    // <summary>
    // The active transaction....should be left as null when IsNested is true
    // <summary>
    public IDbContextTransaction Transaction { get; set; }

    public async Task CommitAsync()
    {
        if (!IsNested && Transaction != null)
        {
            await Transaction.CommitAsync();
        }
    }

    public async void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (Transaction != null)
            {
                Transaction.Dispose();
                Transaction = null;
            }
        }
    }
    
    
}

