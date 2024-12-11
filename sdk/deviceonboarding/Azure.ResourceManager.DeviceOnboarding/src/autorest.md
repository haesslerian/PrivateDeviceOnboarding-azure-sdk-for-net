azure-arm: true
csharp: true
public-clients: true
library-name: DeviceOnboarding
namespace: Azure.ResourceManager.DeviceOnboarding
require: https://github.com/Azure/azure-rest-api-specs-pr/blob/RPSaaSMaster/specification/deviceonboarding/resource-manager/readme.md
#tag: package-2024-12-01-preview
output-folder: $(this-folder)/Generated
clear-output-folder: true
sample-gen:
  output-folder: $(this-folder)/../samples/Generated
  clear-output-folder: true
skip-csproj: true
