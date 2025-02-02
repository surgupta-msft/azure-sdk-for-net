// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagedNetworkFabric;
using Azure.ResourceManager.ManagedNetworkFabric.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_InternalNetworkCollection
    {
        // InternalNetworks_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_InternalNetworksCreateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/preview/2023-02-01-preview/examples/InternalNetworks_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this L3IsolationDomainResource created on azure
            // for more information of creating L3IsolationDomainResource, please refer to the document of L3IsolationDomainResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier l3IsolationDomainResourceId = L3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            L3IsolationDomainResource l3IsolationDomain = client.GetL3IsolationDomainResource(l3IsolationDomainResourceId);

            // get the collection of this InternalNetworkResource
            InternalNetworkCollection collection = l3IsolationDomain.GetInternalNetworks();

            // invoke the operation
            string internalNetworkName = "example-internalnetwork";
            InternalNetworkData data = new InternalNetworkData(501)
            {
                Mtu = 1500,
                ConnectedIPv4Subnets =
{
new ConnectedSubnet()
{
Prefix = "10.0.0.0/24",
}
},
                ConnectedIPv6Subnets =
{
new ConnectedSubnet()
{
Prefix = "3FFE:FFFF:0:CD30::a0/29",
}
},
                StaticRouteConfiguration = new StaticRouteConfiguration()
                {
                    BfdConfiguration = new BfdConfiguration(),
                    IPv4Routes =
{
new StaticRouteProperties("10.1.0.0/24",new string[]
{
"10.0.0.1"
})
},
                    IPv6Routes =
{
new StaticRouteProperties("2fff::/64",new string[]
{
"2ffe::1"
})
},
                },
                BgpConfiguration = new BgpConfiguration(6)
                {
                    BfdConfiguration = new BfdConfiguration(),
                    DefaultRouteOriginate = BooleanEnumProperty.True,
                    AllowAS = 1,
                    AllowASOverride = AllowASOverride.Enable,
                    IPv4ListenRangePrefixes =
{
"10.1.0.0/25"
},
                    IPv6ListenRangePrefixes =
{
"2fff::/66"
},
                    IPv4NeighborAddress =
{
new NeighborAddress()
{
Address = "10.1.0.0",
}
},
                    IPv6NeighborAddress =
{
new NeighborAddress()
{
Address = "2fff::",
}
},
                },
                ImportRoutePolicyId = "/subscriptions/subscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName1",
                ExportRoutePolicyId = "/subscriptions/subscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName2",
            };
            ArmOperation<InternalNetworkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, internalNetworkName, data);
            InternalNetworkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InternalNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // InternalNetworks_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_InternalNetworksGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/preview/2023-02-01-preview/examples/InternalNetworks_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this L3IsolationDomainResource created on azure
            // for more information of creating L3IsolationDomainResource, please refer to the document of L3IsolationDomainResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier l3IsolationDomainResourceId = L3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            L3IsolationDomainResource l3IsolationDomain = client.GetL3IsolationDomainResource(l3IsolationDomainResourceId);

            // get the collection of this InternalNetworkResource
            InternalNetworkCollection collection = l3IsolationDomain.GetInternalNetworks();

            // invoke the operation
            string internalNetworkName = "example-internalnetwork";
            InternalNetworkResource result = await collection.GetAsync(internalNetworkName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InternalNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // InternalNetworks_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_InternalNetworksGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/preview/2023-02-01-preview/examples/InternalNetworks_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this L3IsolationDomainResource created on azure
            // for more information of creating L3IsolationDomainResource, please refer to the document of L3IsolationDomainResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier l3IsolationDomainResourceId = L3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            L3IsolationDomainResource l3IsolationDomain = client.GetL3IsolationDomainResource(l3IsolationDomainResourceId);

            // get the collection of this InternalNetworkResource
            InternalNetworkCollection collection = l3IsolationDomain.GetInternalNetworks();

            // invoke the operation
            string internalNetworkName = "example-internalnetwork";
            bool result = await collection.ExistsAsync(internalNetworkName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // InternalNetworks_List_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_InternalNetworksListMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/preview/2023-02-01-preview/examples/InternalNetworks_List_MaximumSet_Gen.json
            // this example is just showing the usage of "InternalNetworks_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this L3IsolationDomainResource created on azure
            // for more information of creating L3IsolationDomainResource, please refer to the document of L3IsolationDomainResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier l3IsolationDomainResourceId = L3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            L3IsolationDomainResource l3IsolationDomain = client.GetL3IsolationDomainResource(l3IsolationDomainResourceId);

            // get the collection of this InternalNetworkResource
            InternalNetworkCollection collection = l3IsolationDomain.GetInternalNetworks();

            // invoke the operation and iterate over the result
            await foreach (InternalNetworkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InternalNetworkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
