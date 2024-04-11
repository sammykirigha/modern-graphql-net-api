

namespace ServiceProvider.Core.Models;
public partial class UserPaged {
    public User? User {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}