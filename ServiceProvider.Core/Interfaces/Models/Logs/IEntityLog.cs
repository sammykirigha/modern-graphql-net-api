namespace ServiceProvider.Core.Models.Logs;

public interface IEntityLog
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
}

