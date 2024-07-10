targetScope = 'subscription'

param sites_serviceprovider_api_name string
param application string
param environment string
param sku string
param appName string
param location string
param UI_URL string
param linuxFxVersion string
param serverfarms_serviceprovider_app_service_plan_externalid string
param appServicePlanName string
param administratorLogin string
@secure()
param administratorLoginPassword string

var resourceGroupName = 'serviceprovider-${environment}'

// Creating resource group // this one has already been created so we wont create it
resource resource_group_name 'Microsoft.Resources/resourceGroups@2021-01-01' = {
  name: resourceGroupName
  location: location
}

module databaseServer './Modules/database-server.bicep' = {
  name: '${appName}-server-${environment}'
  scope: resource_group_name
  params: {
    appName: appName
    environment: environment
    location: location
    administratorLogin: administratorLogin
    administratorLoginPassword: administratorLoginPassword
  }
}

module sqlServerDatabase './Modules/database-server.bicep' = {
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

module sites_serviceprovider_api_name_resource './Modules/api.bicep' = {
  name: sites_serviceprovider_api_name
  scope: resource_group_name
  dependsOn: [
    appServicePlan
  ]
  params: {
    linuxFxVersion: linuxFxVersion
    application: appName
    environment: environment
    location: location
    serverfarms_serviceprovider_app_service_plan_externalid: serverfarms_serviceprovider_app_service_plan_externalid
    sites_serviceprovider_api_name: sites_serviceprovider_api_name
    UI_URL: UI_URL
  }
}

module appServicePlan './Modules/app-service-plan.bicep' = {
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

// reuse this file to provision resources in different resource group by passing the parameters file
// az deployment sub create --name rumSubDeployment --location eastus2 --template-file main.bicep -p main-rum-staging.json
// delete a resource group with all its resources 
// az group delete --name YourResourceGroupName --yes --no-wait
