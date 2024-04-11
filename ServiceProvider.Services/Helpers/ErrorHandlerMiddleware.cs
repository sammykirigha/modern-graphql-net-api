
using Microsoft.AspNetCore.Http;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using System.Net;
using System.Text.Json;

namespace ServiceProvider.Helpers;

public class ErrorHandlerMiddleware(RequestDelegate _next)
{
    public async Task InvokeAsync(
        HttpContext context,
        IErrorLogService errService,
        IUserProfileService service)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            switch (error)
            {
                case AppException:
                    // custom application error
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case KeyNotFoundException:
                    // not found error
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
                default:
                    //unhandled error
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    var profile = await service.GetUserProfileAsync();
                    var log = new ErrorLog()
                    {
                        Type = (error.Source ?? string.Empty).MaxLength(100),
                        Message = error.Message.MaxLength(1000),
                        Data = error.ToString(),
                        ActiveUserId = profile.UserId != Guid.Empty ? profile.ActiveUserId : null,
                        ActiveUserName = profile.ActiveUserFullName.MaxLength(100),
                        LoggedInUserId = profile.UserId != Guid.Empty ? profile.UserId : null,
                        LoggedInUserName = profile.FullName.MaxLength(100)
                    };
                    await errService.LogErrorAsync(log);
                    break;
            }
            
            var result = JsonSerializer.Serialize(new
            {
                message = error.Message,
                stackTrace = error.StackTrace
            });
            await response.WriteAsync(result);
        }
    }
}