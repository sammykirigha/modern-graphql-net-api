

namespace ServiceProvider.Core.Interfaces.Models.Logs;

public interface IEntityLog
{
    public Guid Id {get; set;}
    public DateTime DateCreated {get; set;}
}