

namespace ServiceProvider.Core.Models;

public class EntityLogPaged
{
    public EntityLog? EntityLog { get; set; } 
    
    public int Count { get; set; }
    public int Total { get; set; }
}

