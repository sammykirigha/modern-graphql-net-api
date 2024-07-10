param sites_rum_ui_name string
param application string
param environment string
param location string

resource sites_rum_ui_name_resource 'Microsoft.Web/staticSites@2022-09-01' = {
  name: sites_rum_ui_name
  location: location
  tags: {
    application: application
    environment: environment
  }
  sku: {
    name: 'Standard'
    tier: 'Standard'
  }
  properties: {
    branch: null
    repositoryUrl: null
    allowConfigFileUpdates: true
    provider: 'DevOps'
  }
}