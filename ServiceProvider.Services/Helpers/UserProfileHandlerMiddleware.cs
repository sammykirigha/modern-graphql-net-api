using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Http;
using ServiceProvider.Core.Interfaces.Services;

namespace ServiceProvider.Services.Helpers;

public class UserProfileHandlerMiddleware
{
	private readonly RequestDelegate _next;

	public UserProfileHandlerMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task InvokeAsync(
		HttpContext context,
		IUserProfileService service)
	{
		service.LoggedInUser = await service.GetUserProfileAsync();

		service.ActiveUser = service.LoggedInUser.UserId == service.LoggedInUser.ActiveUserId
			? service.LoggedInUser
			: await service.GetUserProfileAsync(service.LoggedInUser.ActiveUserId);

		if (context.User.Identity is { IsAuthenticated: true })
		{
			var requestTelemetry = context.Features.Get<RequestTelemetry>();

			requestTelemetry?.Properties.Add("LoggedInUserId", service.LoggedInUser.UserId.ToString());
			requestTelemetry?.Properties.Add("UserId", service.ActiveUser.UserId.ToString());
		}

		await _next(context);
	}
}