namespace ServiceProvider.Core.Models;
public partial class UserPermissionPaged {
    public UserPermission? UserPermission {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}