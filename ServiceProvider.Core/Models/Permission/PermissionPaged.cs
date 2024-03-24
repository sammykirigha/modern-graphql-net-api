namespace ServiceProvider.Core.Models;

public class PermissionPaged
{
    public Permission? Permission { get; set; }
    public int? Count { get; set; }
    public int? Total { get; set; }
}

