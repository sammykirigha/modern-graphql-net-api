
using System.Security.Claims;

namespace ServiceProvider.Core.Extensions;

public static class ClaimsPrincipalExtension
{
    public static string GetEmail(this ClaimsPrincipal cp) => cp.FindFirstValue(ClaimTypes.Email) ?? cp.FindFirstValue("emails") ?? "";

    public static string GetFirstName(this ClaimsPrincipal cp) => cp.FindFirstValue(ClaimTypes.GivenName) ?? "";

    public static string GetLastName(this ClaimsPrincipal cp) => cp.FindFirstValue(ClaimTypes.Surname) ?? "";
}