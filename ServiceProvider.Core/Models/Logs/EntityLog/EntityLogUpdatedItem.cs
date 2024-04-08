
namespace ServiceProvider.Core.Models;

public class EntityLogUpdatedItem<T>
{
    public required T NewEntity {get; set;}
    public T? OldEntity {get; set;}
}