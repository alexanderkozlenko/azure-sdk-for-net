// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    internal class GalleryInVmAccessControlProfileVersionOperationSource : IOperationSource<GalleryInVmAccessControlProfileVersionResource>
    {
        private readonly ArmClient _client;

        internal GalleryInVmAccessControlProfileVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        GalleryInVmAccessControlProfileVersionResource IOperationSource<GalleryInVmAccessControlProfileVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GalleryInVmAccessControlProfileVersionData.DeserializeGalleryInVmAccessControlProfileVersionData(document.RootElement);
            return new GalleryInVmAccessControlProfileVersionResource(_client, data);
        }

        async ValueTask<GalleryInVmAccessControlProfileVersionResource> IOperationSource<GalleryInVmAccessControlProfileVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GalleryInVmAccessControlProfileVersionData.DeserializeGalleryInVmAccessControlProfileVersionData(document.RootElement);
            return new GalleryInVmAccessControlProfileVersionResource(_client, data);
        }
    }
}
