param sku string
param location string
param appServicePlanName string
param application string
param environment string

resource appServicePlan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: appServicePlanName
  location: location
  sku: {
    name: sku
  }
  kind: 'linux'
  properties: {
    reserved: true
  }
  tags: {
    application: application
    environment: environment
  }
}