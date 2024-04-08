
namespace ServiceProvider.Core.Models;
public class EntityLogChange
{
    public string Name { get; set; } = "";
    public object? OldValue { get; set; }
    public object? NewValue { get; set; }
}