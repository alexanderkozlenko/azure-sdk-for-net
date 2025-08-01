// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedDatabaseAdvancedThreatProtection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagedDatabaseAdvancedThreatProtectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedDatabaseResource"/> using the GetManagedDatabaseAdvancedThreatProtection method.
    /// </summary>
    public partial class ManagedDatabaseAdvancedThreatProtectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="managedInstanceName"> The managedInstanceName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        /// <param name="advancedThreatProtectionName"> The advancedThreatProtectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, AdvancedThreatProtectionName advancedThreatProtectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics;
        private readonly ManagedDatabaseAdvancedThreatProtectionSettingsRestOperations _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient;
        private readonly ManagedDatabaseAdvancedThreatProtectionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/advancedThreatProtectionSettings";

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> class for mocking. </summary>
        protected ManagedDatabaseAdvancedThreatProtectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedDatabaseAdvancedThreatProtectionResource(ArmClient client, ManagedDatabaseAdvancedThreatProtectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseAdvancedThreatProtectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedDatabaseAdvancedThreatProtectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsApiVersion);
            _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient = new ManagedDatabaseAdvancedThreatProtectionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedDatabaseAdvancedThreatProtectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedDatabaseAdvancedThreatProtectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionResource.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedDatabaseAdvancedThreatProtectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionResource.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The managed database Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedDatabaseAdvancedThreatProtectionResource>> UpdateAsync(WaitUntil waitUntil, ManagedDatabaseAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionResource.Update");
            scope.Start();
            try
            {
                var response = await _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<ManagedDatabaseAdvancedThreatProtectionResource>(Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a managed database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The managed database Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedDatabaseAdvancedThreatProtectionResource> Update(WaitUntil waitUntil, ManagedDatabaseAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ManagedDatabaseAdvancedThreatProtectionResource.Update");
            scope.Start();
            try
            {
                var response = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _managedDatabaseAdvancedThreatProtectionManagedDatabaseAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<ManagedDatabaseAdvancedThreatProtectionResource>(Response.FromValue(new ManagedDatabaseAdvancedThreatProtectionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
    }
}
