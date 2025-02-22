// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_PacketCoreControlPlaneResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneGet.json
            // this example is just showing the usage of "PacketCoreControlPlanes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // invoke the operation
            PacketCoreControlPlaneResource result = await packetCoreControlPlane.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCoreControlPlaneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletePacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneDelete.json
            // this example is just showing the usage of "PacketCoreControlPlanes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // invoke the operation
            await packetCoreControlPlane.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlanePatch.json
            // this example is just showing the usage of "PacketCoreControlPlanes_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // invoke the operation
            MobileNetworkResourcePatch patch = new MobileNetworkResourcePatch
            {
                UserAssignedIdentity = new MobileNetworkManagedServiceIdentity(MobileNetworkManagedServiceIdentityType.UserAssigned)
                {
                    UserAssignedIdentities =
{
["/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/rg1/providers/Microsoft.ManagedIdentity/userAssignedIdentities/testUserAssignedManagedIdentity"] = new UserAssignedIdentity()
},
                },
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            PacketCoreControlPlaneResource result = await packetCoreControlPlane.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCoreControlPlaneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Rollback_RollbackPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneRollback.json
            // this example is just showing the usage of "PacketCoreControlPlanes_Rollback" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // invoke the operation
            ArmOperation<AsyncOperationStatus> lro = await packetCoreControlPlane.RollbackAsync(WaitUntil.Completed);
            AsyncOperationStatus result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Reinstall_ReinstallPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneReinstall.json
            // this example is just showing the usage of "PacketCoreControlPlanes_Reinstall" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // invoke the operation
            ArmOperation<AsyncOperationStatus> lro = await packetCoreControlPlane.ReinstallAsync(WaitUntil.Completed);
            AsyncOperationStatus result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CollectDiagnosticsPackage_CollectDiagnosticsPackageFromPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneCollectDiagnosticsPackage.json
            // this example is just showing the usage of "PacketCoreControlPlanes_CollectDiagnosticsPackage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // invoke the operation
            PacketCoreControlPlaneCollectDiagnosticsPackage packetCoreControlPlaneCollectDiagnosticsPackage = new PacketCoreControlPlaneCollectDiagnosticsPackage(new Uri("https://contosoaccount.blob.core.windows.net/container/diagnosticsPackage.zip"));
            ArmOperation<AsyncOperationStatus> lro = await packetCoreControlPlane.CollectDiagnosticsPackageAsync(WaitUntil.Completed, packetCoreControlPlaneCollectDiagnosticsPackage);
            AsyncOperationStatus result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAllUeInformation_GetUEInformation()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/UeInfoList.json
            // this example is just showing the usage of "UeInformation_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // invoke the operation and iterate over the result
            await foreach (UEInfo item in packetCoreControlPlane.GetAllUeInformationAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
