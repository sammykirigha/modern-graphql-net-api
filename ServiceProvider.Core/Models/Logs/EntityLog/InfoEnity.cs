namespace ServiceProvider.Core.Models;

public class InfoEntity : IEntity
{
    public Guid Id { get; set; }
    
    public string Info { get; set; }
    
    public string? Data { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}

