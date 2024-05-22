# Service Provider API Project
This API is designed to allows users to access the services provided by the clients within the platform. The application is developed using Angular and .NET 8.
 
## Directory Structure
 
This project contains the following folders:
- `ServiceProvider.Core`: Containes data Models, enums, extension methods, and interfaces
- `ServiceProvider.Data`: Containe the DbContext and all the models configurations
- `ServiceProvider.Services`: Containes Services that communicates with the database repository, and GraphQL configurations
- `ServiceProvider.WebApi`: Entrypoint that bootstraps and runs the backend .NET Core Web Api
- `ServiceProvider.IntegrationTests`: Containes all the unit tests and integration tests.
 
## Application Setup
 
- `Database`: The application uses SSQL Server database, and EF Core migrations tool for applying domain entity changes to the database.
- `Backend`: The Api is written using `.NET Core 8.0`
- `Frontend`: The front is built using `Angular v17`. This one is not yet complete
 
## Spin Up The Application
In the `ServiceProvider.WebApi` directory of the project run `dotnet run` to spin up the application both the backend api, and database.
 
## Integration Tests
The API integration tests can be executed by this command `dotnet test ServiceProvider.IntegrationTests`