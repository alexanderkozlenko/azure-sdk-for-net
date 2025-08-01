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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstanceDtcResource"/> and their operations.
    /// Each <see cref="ManagedInstanceDtcResource"/> in the collection will belong to the same instance of <see cref="ManagedInstanceResource"/>.
    /// To get a <see cref="ManagedInstanceDtcCollection"/> instance call the GetManagedInstanceDtcs method from an instance of <see cref="ManagedInstanceResource"/>.
    /// </summary>
    public partial class ManagedInstanceDtcCollection : ArmCollection, IEnumerable<ManagedInstanceDtcResource>, IAsyncEnumerable<ManagedInstanceDtcResource>
    {
        private readonly ClientDiagnostics _managedInstanceDtcClientDiagnostics;
        private readonly ManagedInstanceDtcsRestOperations _managedInstanceDtcRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDtcCollection"/> class for mocking. </summary>
        protected ManagedInstanceDtcCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDtcCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceDtcCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDtcClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceDtcResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceDtcResource.ResourceType, out string managedInstanceDtcApiVersion);
            _managedInstanceDtcRestClient = new ManagedInstanceDtcsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceDtcApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates managed instance DTC settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="data"> Managed instance DTC settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceDtcResource>> CreateOrUpdateAsync(WaitUntil waitUntil, DtcName dtcName, ManagedInstanceDtcData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceDtcRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceDtcResource>(new ManagedInstanceDtcOperationSource(Client), _managedInstanceDtcClientDiagnostics, Pipeline, _managedInstanceDtcRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates managed instance DTC settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="data"> Managed instance DTC settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceDtcResource> CreateOrUpdate(WaitUntil waitUntil, DtcName dtcName, ManagedInstanceDtcData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceDtcRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceDtcResource>(new ManagedInstanceDtcOperationSource(Client), _managedInstanceDtcClientDiagnostics, Pipeline, _managedInstanceDtcRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets managed instance DTC settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceDtcResource>> GetAsync(DtcName dtcName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDtcRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDtcResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets managed instance DTC settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDtcResource> Get(DtcName dtcName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDtcRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDtcResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of managed instance DTC settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_ListByManagedInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceDtcResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceDtcResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceDtcRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceDtcRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedInstanceDtcResource(Client, ManagedInstanceDtcData.DeserializeManagedInstanceDtcData(e)), _managedInstanceDtcClientDiagnostics, Pipeline, "ManagedInstanceDtcCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of managed instance DTC settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_ListByManagedInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceDtcResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceDtcResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceDtcRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceDtcRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedInstanceDtcResource(Client, ManagedInstanceDtcData.DeserializeManagedInstanceDtcData(e)), _managedInstanceDtcClientDiagnostics, Pipeline, "ManagedInstanceDtcCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(DtcName dtcName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstanceDtcRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(DtcName dtcName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstanceDtcRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ManagedInstanceDtcResource>> GetIfExistsAsync(DtcName dtcName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceDtcRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedInstanceDtcResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDtcResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dtc/{dtcName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstanceDtcs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceDtcResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dtcName"> The name of the managed instance DTC. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ManagedInstanceDtcResource> GetIfExists(DtcName dtcName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDtcClientDiagnostics.CreateScope("ManagedInstanceDtcCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceDtcRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dtcName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedInstanceDtcResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDtcResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceDtcResource> IEnumerable<ManagedInstanceDtcResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceDtcResource> IAsyncEnumerable<ManagedInstanceDtcResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
