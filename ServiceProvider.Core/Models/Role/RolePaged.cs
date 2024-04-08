

namespace ServiceProvider.Core.Models;

public partial class RolePaged
{
    public Role? Role {get; set;}

    public int Count {get; set;}
    public int Total {get; set;}
}