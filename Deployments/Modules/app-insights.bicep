param location string
param app_insights_name string

resource appInsightsComponents 'Microsoft.Insights/components@2020-02-02' = {
  name: app_insights_name
  location: location
  kind: 'web'
  properties: {
    Application_Type: 'web'
  }
}