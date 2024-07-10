param application string
param environment string
param location string
param storageName string

resource storageaccount 'Microsoft.Storage/storageAccounts@2022-09-01' = {
  name: storageName
  location: location
  tags: {
    application: application
    environment: environment
  }
  kind: 'StorageV2'
  sku: {
    name: 'Standard_LRS'
  }
}

resource blobContainer 'Microsoft.Storage/storageAccounts/blobServices/containers@2022-09-01' = {
  name: '${storageaccount.name}/default/blobcontainer'
}