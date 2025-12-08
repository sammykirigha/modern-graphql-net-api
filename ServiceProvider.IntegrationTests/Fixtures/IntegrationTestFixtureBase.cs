using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;


namespace ServiceProvider.IntegrationTests;

public class IntegrationTestFixtureBase :  IClassFixture<CustomWebApplicationFactory<Program>>
{
	protected readonly HttpClient _client;
	protected readonly CustomWebApplicationFactory<Program> Factory;

	public IntegrationTestFixtureBase(CustomWebApplicationFactory<Program> factory)
	{
		Factory = factory;
		_client = Factory.CreateClient();
	}
	
	protected async Task<GraphQLResponse<TResponse>> SendGraphQlRequestAsync<TResponse>(string query, object variables = null, string operationName = null)
	{
		var graphQLClient = new GraphQLHttpClient(new GraphQLHttpClientOptions{EndPoint = new Uri("http://localhost:5133/")}, new SystemTextJsonSerializer(), _client);

		var request = new GraphQLRequest { Query = query, Variables = variables, OperationName = operationName };

		return await graphQLClient.SendQueryAsync<TResponse>(request);
	}
	
}