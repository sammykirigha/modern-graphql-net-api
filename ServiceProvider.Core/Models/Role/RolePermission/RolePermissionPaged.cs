

namespace ServiceProvider.Core.Models;

public class RolePermissionPaged
{
    public RolePermission? RolePermission { get; set; }
    public int Count { get; set; }
    public int Total { get; set; }
}

