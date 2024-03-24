

namespace ServiceProvider.Core.Models;

public class EntityLogUpdateItem<T>
{
    public required T NewEntity { get; set; }
    public T? OldEntity { get; set; }
}

