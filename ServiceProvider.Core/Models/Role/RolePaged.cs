
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Model;

public class RolePaged
{
    public Role? Role { get; set; }
    public int Count { get; set; }
    public int Total { get; set; }
}

