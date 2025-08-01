// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedInstanceOperationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheManagedInstanceManagementOperation()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetManagedInstanceOperation.json
            // this example is just showing the usage of "ManagedInstanceOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceOperationResource created on azure
            // for more information of creating ManagedInstanceOperationResource, please refer to the document of ManagedInstanceOperationResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            Guid operationId = Guid.Parse("00000000-1111-2222-3333-444444444444");
            ResourceIdentifier managedInstanceOperationResourceId = ManagedInstanceOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, operationId);
            ManagedInstanceOperationResource managedInstanceOperation = client.GetManagedInstanceOperationResource(managedInstanceOperationResourceId);

            // invoke the operation
            ManagedInstanceOperationResource result = await managedInstanceOperation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceOperationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Cancel_CancelTheManagedInstanceManagementOperation()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/CancelManagedInstanceOperation.json
            // this example is just showing the usage of "ManagedInstanceOperations_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceOperationResource created on azure
            // for more information of creating ManagedInstanceOperationResource, please refer to the document of ManagedInstanceOperationResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            Guid operationId = Guid.Parse("11111111-1111-1111-1111-111111111111");
            ResourceIdentifier managedInstanceOperationResourceId = ManagedInstanceOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, operationId);
            ManagedInstanceOperationResource managedInstanceOperation = client.GetManagedInstanceOperationResource(managedInstanceOperationResourceId);

            // invoke the operation
            await managedInstanceOperation.CancelAsync();

            Console.WriteLine("Succeeded");
        }
    }
}
