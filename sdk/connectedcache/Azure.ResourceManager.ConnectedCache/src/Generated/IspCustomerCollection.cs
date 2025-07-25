// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedCache
{
    /// <summary>
    /// A class representing a collection of <see cref="IspCustomerResource"/> and their operations.
    /// Each <see cref="IspCustomerResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="IspCustomerCollection"/> instance call the GetIspCustomers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class IspCustomerCollection : ArmCollection, IEnumerable<IspCustomerResource>, IAsyncEnumerable<IspCustomerResource>
    {
        private readonly ClientDiagnostics _ispCustomerClientDiagnostics;
        private readonly IspCustomersRestOperations _ispCustomerRestClient;

        /// <summary> Initializes a new instance of the <see cref="IspCustomerCollection"/> class for mocking. </summary>
        protected IspCustomerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IspCustomerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IspCustomerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ispCustomerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedCache", IspCustomerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IspCustomerResource.ResourceType, out string ispCustomerApiVersion);
            _ispCustomerRestClient = new IspCustomersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ispCustomerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// This api creates an ispCustomer with the specified create parameters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IspCustomerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string customerResourceName, IspCustomerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ispCustomerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedCacheArmOperation<IspCustomerResource>(new IspCustomerOperationSource(Client), _ispCustomerClientDiagnostics, Pipeline, _ispCustomerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This api creates an ispCustomer with the specified create parameters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IspCustomerResource> CreateOrUpdate(WaitUntil waitUntil, string customerResourceName, IspCustomerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ispCustomerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, data, cancellationToken);
                var operation = new ConnectedCacheArmOperation<IspCustomerResource>(new IspCustomerOperationSource(Client), _ispCustomerClientDiagnostics, Pipeline, _ispCustomerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the ispCustomer resource information using this get call
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> is null. </exception>
        public virtual async Task<Response<IspCustomerResource>> GetAsync(string customerResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.Get");
            scope.Start();
            try
            {
                var response = await _ispCustomerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IspCustomerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the ispCustomer resource information using this get call
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> is null. </exception>
        public virtual Response<IspCustomerResource> Get(string customerResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.Get");
            scope.Start();
            try
            {
                var response = _ispCustomerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IspCustomerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This api gets the information about all ispCustomer resources under the given subscription and resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IspCustomerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IspCustomerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ispCustomerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ispCustomerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IspCustomerResource(Client, IspCustomerData.DeserializeIspCustomerData(e)), _ispCustomerClientDiagnostics, Pipeline, "IspCustomerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This api gets the information about all ispCustomer resources under the given subscription and resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IspCustomerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IspCustomerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ispCustomerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ispCustomerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IspCustomerResource(Client, IspCustomerData.DeserializeIspCustomerData(e)), _ispCustomerClientDiagnostics, Pipeline, "IspCustomerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string customerResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ispCustomerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string customerResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.Exists");
            scope.Start();
            try
            {
                var response = _ispCustomerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<IspCustomerResource>> GetIfExistsAsync(string customerResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ispCustomerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IspCustomerResource>(response.GetRawResponse());
                return Response.FromValue(new IspCustomerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedCache/ispCustomers/{customerResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IspCustomerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IspCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerResourceName"> Name of the Customer resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerResourceName"/> is null. </exception>
        public virtual NullableResponse<IspCustomerResource> GetIfExists(string customerResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerResourceName, nameof(customerResourceName));

            using var scope = _ispCustomerClientDiagnostics.CreateScope("IspCustomerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ispCustomerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customerResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IspCustomerResource>(response.GetRawResponse());
                return Response.FromValue(new IspCustomerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IspCustomerResource> IEnumerable<IspCustomerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IspCustomerResource> IAsyncEnumerable<IspCustomerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
