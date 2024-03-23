using System.Globalization;

namespace ServiceProvider.Core.Exceptions;

public class AppAccessException : Exception
{
   public AppAccessException():base()
   {
   }

   public AppAccessException(string message): base(message)
   {
   }

   public AppAccessException(string message, params object[] args): base(string.Format(CultureInfo.CurrentCulture, message, args))
   {
    
   }
}