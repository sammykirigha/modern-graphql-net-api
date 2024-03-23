

namespace ServiceProvider.Core.Extensions;

public static class ExceptionExtension
{
    public static List<Exception> GetInnerExceptions(this Exception ex)
    {
        if(ex == null)
            throw new ArgumentNullException(nameof(ex));

        var list = new List<Exception>();
        var exinner = ex;

        while(exinner!= null)
        {
            list.Add(exinner);
            exinner = exinner.InnerException;
        }

        return list;
    }
}