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
    public partial class Sample_SqlServerJobVersionStepCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheSpecifiedVersionOfAJobStep()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetJobStepByVersion.json
            // this example is just showing the usage of "JobSteps_GetByVersion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobVersionResource created on azure
            // for more information of creating SqlServerJobVersionResource, please refer to the document of SqlServerJobVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            int jobVersion = 1;
            ResourceIdentifier sqlServerJobVersionResourceId = SqlServerJobVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobVersion);
            SqlServerJobVersionResource sqlServerJobVersion = client.GetSqlServerJobVersionResource(sqlServerJobVersionResourceId);

            // get the collection of this SqlServerJobVersionStepResource
            SqlServerJobVersionStepCollection collection = sqlServerJobVersion.GetSqlServerJobVersionSteps();

            // invoke the operation
            string stepName = "step1";
            SqlServerJobVersionStepResource result = await collection.GetAsync(stepName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerJobStepData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListJobStepsForTheSpecifiedVersionOfAJob()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ListJobStepsByVersion.json
            // this example is just showing the usage of "JobSteps_ListByVersion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobVersionResource created on azure
            // for more information of creating SqlServerJobVersionResource, please refer to the document of SqlServerJobVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            int jobVersion = 1;
            ResourceIdentifier sqlServerJobVersionResourceId = SqlServerJobVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobVersion);
            SqlServerJobVersionResource sqlServerJobVersion = client.GetSqlServerJobVersionResource(sqlServerJobVersionResourceId);

            // get the collection of this SqlServerJobVersionStepResource
            SqlServerJobVersionStepCollection collection = sqlServerJobVersion.GetSqlServerJobVersionSteps();

            // invoke the operation and iterate over the result
            await foreach (SqlServerJobVersionStepResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerJobStepData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetTheSpecifiedVersionOfAJobStep()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetJobStepByVersion.json
            // this example is just showing the usage of "JobSteps_GetByVersion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobVersionResource created on azure
            // for more information of creating SqlServerJobVersionResource, please refer to the document of SqlServerJobVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            int jobVersion = 1;
            ResourceIdentifier sqlServerJobVersionResourceId = SqlServerJobVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobVersion);
            SqlServerJobVersionResource sqlServerJobVersion = client.GetSqlServerJobVersionResource(sqlServerJobVersionResourceId);

            // get the collection of this SqlServerJobVersionStepResource
            SqlServerJobVersionStepCollection collection = sqlServerJobVersion.GetSqlServerJobVersionSteps();

            // invoke the operation
            string stepName = "step1";
            bool result = await collection.ExistsAsync(stepName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetTheSpecifiedVersionOfAJobStep()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetJobStepByVersion.json
            // this example is just showing the usage of "JobSteps_GetByVersion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobVersionResource created on azure
            // for more information of creating SqlServerJobVersionResource, please refer to the document of SqlServerJobVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            int jobVersion = 1;
            ResourceIdentifier sqlServerJobVersionResourceId = SqlServerJobVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobVersion);
            SqlServerJobVersionResource sqlServerJobVersion = client.GetSqlServerJobVersionResource(sqlServerJobVersionResourceId);

            // get the collection of this SqlServerJobVersionStepResource
            SqlServerJobVersionStepCollection collection = sqlServerJobVersion.GetSqlServerJobVersionSteps();

            // invoke the operation
            string stepName = "step1";
            NullableResponse<SqlServerJobVersionStepResource> response = await collection.GetIfExistsAsync(stepName);
            SqlServerJobVersionStepResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerJobStepData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
