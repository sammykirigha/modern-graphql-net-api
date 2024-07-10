param sites_serviceprovider_api_name string
param application string
param environment string
param location string
param linuxFxVersion string
param serverfarms_serviceprovider_app_service_plan_externalid string
param UI_URL string

resource sites_serviceprovider_api_name_resource 'Microsoft.Web/sites@2022-09-01' = {
  name: sites_serviceprovider_api_name
  location: location
  tags: {
    application: application
    environment: environment
  }
  kind: 'app,linux'
  properties: {
    enabled: true
    serverFarmId: serverfarms_serviceprovider_app_service_plan_externalid
    hostNameSslStates: [
      {
        name: '${sites_serviceprovider_api_name}.azurewebsites.net'
        sslState: 'Disabled'
        hostType: 'Standard'
      }
      {
        name: '${sites_serviceprovider_api_name}.scm.azurewebsites.net'
        sslState: 'Disabled'
        hostType: 'Repository'
      }
    ]
    reserved: true
    isXenon: false
    hyperV: false
    vnetRouteAllEnabled: false
    vnetImagePullEnabled: false
    siteConfig: {
      numberOfWorkers: 1
      linuxFxVersion: linuxFxVersion
      acrUseManagedIdentityCreds: false
      alwaysOn: false
      http20Enabled: false
      functionAppScaleLimit: 0
      minimumElasticInstanceCount: 0
    }
    scmSiteAlsoStopped: false
    clientAffinityEnabled: false
    clientCertEnabled: false
    clientCertMode: 'Required'
    hostNamesDisabled: false
    customDomainVerificationId: ''
    containerSize: 0
    dailyMemoryTimeQuota: 0
    httpsOnly: true
    redundancyMode: 'None'
    publicNetworkAccess: 'Enabled'
    storageAccountRequired: false
    keyVaultReferenceIdentity: 'SystemAssigned'
  }
}

resource appSettings 'Microsoft.Web/sites/config@2022-09-01' = {
  parent: sites_serviceprovider_api_name_resource
  name: 'appsettings'
  properties: {
    ApplicationInsightsAgent_EXTENSION_VERSION: '~3'
    UI_URL: UI_URL
    XDT_MicrosoftApplicationInsights_Mode: 'Recommended'
  }
}
