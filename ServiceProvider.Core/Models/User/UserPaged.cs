

namespace ServiceProvider.Core.Models;
public partial class UserPaged {
    public User? USer {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}