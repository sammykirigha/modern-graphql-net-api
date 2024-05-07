targetScope = 'subscription'

param sites_rum_api_name string
param sites_rum_ui_name string
param app_insights_name string
param application string
param environment string
param sku string
param appName string
param location string
param Token string
param UI_URL string
param storageName string
param instrumentationKey string
param SendGrid_APIKey string
param connectionString string
param linuxFxVersion string
param serverfarms_rum_app_service_plan_externalid string
param appServicePlanName string
param administratorLogin string
@secure()
param administratorLoginPassword string

var resourceGroupName = 'rg-${environment}'

// Creating resource group
resource resource_group_name 'Microsoft.Resources/resourceGroups@2021-01-01' = {
  name: resourceGroupName
  location: location
}

module databaseServer './modules/database-server.bicep' = {
  name: '${appName}-${environment}'
  scope: resource_group_name
  params: {
    appName: appName
    environment: environment
    location: location
    administratorLogin: administratorLogin
    administratorLoginPassword: administratorLoginPassword
  }
}

module sqlServerDatabase './modules/database-server.bicep' = {
  name: '${databaseServer.name}-db'
  scope: resource_group_name
  params: {
    appName: appName
    environment: environment
    location: location
    administratorLogin: administratorLogin
    administratorLoginPassword: administratorLoginPassword
  }
}

module sites_rum_api_name_resource './modules/api.bicep' = {
  name: sites_rum_api_name
  scope: resource_group_name
  dependsOn: [
    appServicePlan, appInsightsComponents
  ]
  params: {
    linuxFxVersion: linuxFxVersion
    application: appName
    environment: environment
    location: location
    serverfarms_rum_app_service_plan_externalid: serverfarms_rum_app_service_plan_externalid
    sites_rum_api_name: sites_rum_api_name
    connectionString: connectionString
    instrumentationKey: instrumentationKey
    SendGrid_APIKey: SendGrid_APIKey
    Token: Token
    UI_URL: UI_URL
  }
}

module sites_rum_ui_name_resource './modules/ui.bicep' = {
  name: sites_rum_ui_name
  scope: resource_group_name
  params: {
    application: application
    environment: environment
    location: location
    sites_rum_ui_name: sites_rum_ui_name
  }
}

module appInsightsComponents './modules/app-insights.bicep' = {
  name: app_insights_name
  scope: resource_group_name
  params: {
    app_insights_name: app_insights_name
    location: location
  }
}

module appServicePlan './modules/app-service-plan.bicep' = {
  name: appServicePlanName
  scope: resource_group_name
  params: {
    appServicePlanName: appServicePlanName
    location: location
    sku: sku
    application: application
    environment: environment
  }
}

module storageaccount './modules/storage-account.bicep' = {
  name: storageName
  scope: resource_group_name
  params: {
    application: application
    environment: environment
    location: location
    storageName: storageName
  }
}

// reuse this file to provision resources in different resource group by passing the parameters file
// az deployment sub create --name rumSubDeployment --location eastus2 --template-file main.bicep -p main-rum-staging.json
// delete a resource group with all its resources 
// az group delete --name YourResourceGroupName --yes --no-wait
