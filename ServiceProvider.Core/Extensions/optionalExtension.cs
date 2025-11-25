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

    //validate Guid value
    public static void ValidateGuid(this Optional<Guid> input,
        [CallerArgumentExpression(nameof(input))] string callerExp = "")
    {
        if (input.IsEmpty || input.Value == Guid.Empty)
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} must be a valid non-empty GUID", ValidationCode.InvalideValue);
        }
    }

    public static void ValidatePassword(this Optional<string> input,
        [CallerArgumentExpression(nameof(input))] string callerExp = "")
    {
        if (input.IsEmpty)
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} is required", ValidationCode.MissingRequirement);
        }

        var password = input.Value;
        if (string.IsNullOrWhiteSpace(password))
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} cannot be empty or whitespace", ValidationCode.InvalideValue);
        }

        // Password must be at least 8 characters long
        if (password.Length < 8)
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} must be at least 8 characters long", ValidationCode.InvalideValue);
        }

        // Check for at least one uppercase letter
        if (!password.Any(char.IsUpper))
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} must contain at least one uppercase letter", ValidationCode.InvalideValue);
        }

        // Check for at least one lowercase letter
        if (!password.Any(char.IsLower))
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} must contain at least one lowercase letter", ValidationCode.InvalideValue);
        }

        // Check for at least one digit
        if (!password.Any(char.IsDigit))
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} must contain at least one digit", ValidationCode.InvalideValue);
        }

        // Check for at least one special character
        if (!password.Any(c => !char.IsLetterOrDigit(c)))
        {
            var name = callerExp[(callerExp.LastIndexOf('.') + 1)..];
            throw new AppException($"The {name} must contain at least one special character", ValidationCode.InvalideValue);
        }
    }
}