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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionUsageResource"/> and their operations.
    /// Each <see cref="SubscriptionUsageResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SubscriptionUsageCollection"/> instance call the GetSubscriptionUsages method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SubscriptionUsageCollection : ArmCollection, IEnumerable<SubscriptionUsageResource>, IAsyncEnumerable<SubscriptionUsageResource>
    {
        private readonly ClientDiagnostics _subscriptionUsageClientDiagnostics;
        private readonly SubscriptionUsagesRestOperations _subscriptionUsageRestClient;
        private readonly AzureLocation _locationName;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageCollection"/> class for mocking. </summary>
        protected SubscriptionUsageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        internal SubscriptionUsageCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName) : base(client, id)
        {
            _locationName = locationName;
            _subscriptionUsageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SubscriptionUsageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionUsageResource.ResourceType, out string subscriptionUsageApiVersion);
            _subscriptionUsageRestClient = new SubscriptionUsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionUsageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a subscription usage metric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionUsageResource>> GetAsync(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionUsageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), usageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a subscription usage metric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual Response<SubscriptionUsageResource> Get(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionUsageRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), usageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all subscription usage metrics in a given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionUsageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionUsageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionUsageRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionUsageRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SubscriptionUsageResource(Client, SubscriptionUsageData.DeserializeSubscriptionUsageData(e)), _subscriptionUsageClientDiagnostics, Pipeline, "SubscriptionUsageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all subscription usage metrics in a given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionUsageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionUsageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionUsageRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionUsageRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SubscriptionUsageResource(Client, SubscriptionUsageData.DeserializeSubscriptionUsageData(e)), _subscriptionUsageClientDiagnostics, Pipeline, "SubscriptionUsageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionUsageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), usageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual Response<bool> Exists(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionUsageRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), usageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual async Task<NullableResponse<SubscriptionUsageResource>> GetIfExistsAsync(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionUsageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), usageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionUsageResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual NullableResponse<SubscriptionUsageResource> GetIfExists(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionUsageRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), usageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionUsageResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionUsageResource> IEnumerable<SubscriptionUsageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionUsageResource> IAsyncEnumerable<SubscriptionUsageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
