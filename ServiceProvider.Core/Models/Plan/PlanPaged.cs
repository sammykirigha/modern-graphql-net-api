namespace ServiceProvider.Core.Models;

public partial class PlanPaged
{
    public Plan? Plan {get; set;}

    public int Count {get; set;}
    public int Total {get; set;}
}