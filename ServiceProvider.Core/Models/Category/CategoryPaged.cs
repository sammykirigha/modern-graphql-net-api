

namespace ServiceProvider.Core.Models;

public partial class CategoryPaged
{
    public Category? Category {get; set;}

    public int Count {get; set;}
    public int Total {get; set;}
}