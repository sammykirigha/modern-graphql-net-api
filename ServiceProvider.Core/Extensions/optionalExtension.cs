using System.Runtime.CompilerServices;
using HotChocolate;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;

namespace ServiceProvider.Core.Extensions;

public static class OptionalExtension
{
    public static T CheckForValue<T>(this Optional<T> input, T defaultValue)
    {
        return input.HasValue? input.Value : defaultValue;
    }

    public static void CheckRequired<T>(this Optional<T> input, string? message = null, 
    [CallerArgumentExpression(nameof(input))] string callerExp = "")
    {
      var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
      if(input.IsEmpty)
      throw new AppException(message?? $"The {name} is required", ValidationCode.MissingRequirement);
    }

    public static void CheckRequiredCount<T>(this Optional<ICollection<T>> input,int count, string? message = null, 
    [CallerArgumentExpression(nameof(input))] string callerExp = "")
    {
      var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
      if(input.IsEmpty || input.Value?.Count < count)
      throw new AppException(message?? $"The {name} is required and must have at least {count} entry(ies)", ValidationCode.MissingRequirement);
    }
}