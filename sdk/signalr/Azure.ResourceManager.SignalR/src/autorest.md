# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
# require: https://raw.githubusercontent.com/sonwan2020/azure-rest-api-specs/sonwan/add-asc-scenarios-file/specification/signalr/resource-manager/readme.md
require: D:\\projects\\codegen\\azure-rest-api-specs\\specification\\signalr\\resource-manager\\readme.md
namespace: Azure.ResourceManager.SignalR
clear-output-folder: true
skip-csproj: true
output-folder: Generated/
modelerfour:
  lenient-model-deduplication: true
list-exception:
    - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
```
