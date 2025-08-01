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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerKeyResource"/> and their operations.
    /// Each <see cref="SqlServerKeyResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SqlServerKeyCollection"/> instance call the GetSqlServerKeys method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SqlServerKeyCollection : ArmCollection, IEnumerable<SqlServerKeyResource>, IAsyncEnumerable<SqlServerKeyResource>
    {
        private readonly ClientDiagnostics _sqlServerKeyServerKeysClientDiagnostics;
        private readonly ServerKeysRestOperations _sqlServerKeyServerKeysRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerKeyCollection"/> class for mocking. </summary>
        protected SqlServerKeyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerKeyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerKeyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerKeyServerKeysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerKeyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerKeyResource.ResourceType, out string sqlServerKeyServerKeysApiVersion);
            _sqlServerKeyServerKeysRestClient = new ServerKeysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerKeyServerKeysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the server key to be operated on (updated or created). The key name is required to be in the format of 'vault_key_version'. For example, if the keyId is https://YourVaultName.vault.azure.net/keys/YourKeyName/YourKeyVersion, then the server key name should be formatted as: YourVaultName_YourKeyName_YourKeyVersion. </param>
        /// <param name="data"> The requested server key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerKeyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyName, SqlServerKeyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerKeyServerKeysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerKeyResource>(new SqlServerKeyOperationSource(Client), _sqlServerKeyServerKeysClientDiagnostics, Pipeline, _sqlServerKeyServerKeysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyName"> The name of the server key to be operated on (updated or created). The key name is required to be in the format of 'vault_key_version'. For example, if the keyId is https://YourVaultName.vault.azure.net/keys/YourKeyName/YourKeyVersion, then the server key name should be formatted as: YourVaultName_YourKeyName_YourKeyVersion. </param>
        /// <param name="data"> The requested server key resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerKeyResource> CreateOrUpdate(WaitUntil waitUntil, string keyName, SqlServerKeyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerKeyServerKeysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerKeyResource>(new SqlServerKeyOperationSource(Client), _sqlServerKeyServerKeysClientDiagnostics, Pipeline, _sqlServerKeyServerKeysRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<SqlServerKeyResource>> GetAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerKeyServerKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server key.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<SqlServerKeyResource> Get(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerKeyServerKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerKeyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerKeyServerKeysRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerKeyServerKeysRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerKeyResource(Client, SqlServerKeyData.DeserializeSqlServerKeyData(e)), _sqlServerKeyServerKeysClientDiagnostics, Pipeline, "SqlServerKeyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of server keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerKeyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerKeyServerKeysRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerKeyServerKeysRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerKeyResource(Client, SqlServerKeyData.DeserializeSqlServerKeyData(e)), _sqlServerKeyServerKeysClientDiagnostics, Pipeline, "SqlServerKeyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerKeyServerKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerKeyServerKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerKeyResource>> GetIfExistsAsync(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerKeyServerKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerKeyResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerKeyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/keys/{keyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyName"> The name of the server key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public virtual NullableResponse<SqlServerKeyResource> GetIfExists(string keyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyName, nameof(keyName));

            using var scope = _sqlServerKeyServerKeysClientDiagnostics.CreateScope("SqlServerKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerKeyServerKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerKeyResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerKeyResource> IEnumerable<SqlServerKeyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerKeyResource> IAsyncEnumerable<SqlServerKeyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
