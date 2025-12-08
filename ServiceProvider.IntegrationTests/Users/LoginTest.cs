using System.Net;

namespace ServiceProvider.IntegrationTests.Users;

public class LoginTest : IntegrationTestFixtureBase
{
	public LoginTest(CustomWebApplicationFactory<Program> factory) : base(factory){}

	[Fact]
	public async Task Login_Should_Return_Access_And_Refresh_Token()
	{
		// Arrange
		var loginRequest = new
		{
			query = @"
            mutation {
              loginUser(user: {
                email: ""admin@sp.com"",
                password: ""Pa55word123!""
              }) {
                accessToken
                refreshToken
              }
            }"
		};

		// Act
		var response = await SendGraphQlRequestAsync< dynamic>(loginRequest.query);

		// Assert
		response.Should().Be(HttpStatusCode.OK);

		var loginResponse = response.Data.ToObject<LoginResponse>();
		
		loginResponse.Should().NotBeNull();
		loginResponse.Data.LoginUser.AccessToken.Should().NotBeNullOrEmpty();
		loginResponse.Data.LoginUser.RefreshToken.Should().NotBeNullOrEmpty();
		
	}

		private class LoginResponse
		{
			public LoginUserData Data { get; set; }
		}

		private class LoginUserData
		{
			public TokenResult LoginUser { get; set; }
		}

		private class TokenResult
		{
			public string AccessToken { get; set; }
			public string RefreshToken { get; set; }
		}
	
}