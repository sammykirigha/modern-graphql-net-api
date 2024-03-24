

namespace ServiceProvider.Core.Models;

public class ErrorLogPaged
{
    public ErrorLog? ErrorLog { get; set; }
    
    public int Count { get; set; }
    
    public int Total { get; set; }
}

