param environment string
param appName string
param location string
param administratorLogin string
@secure()
param administratorLoginPassword string

resource databaseServer 'Microsoft.Sql/servers@2022-02-01-preview' = {
  name: '${appName}-${environment}'
  location: location
  properties: {
    administratorLogin: administratorLogin
    administratorLoginPassword: administratorLoginPassword
  }
}

resource sqlServerDatabase 'Microsoft.Sql/servers/databases@2022-02-01-preview' = {
  parent: databaseServer
  name: '${databaseServer.name}-db'
  location: location
  sku: {
    name: 'Standard'
    size: '3000'
    tier: 'Standard'
  }
}