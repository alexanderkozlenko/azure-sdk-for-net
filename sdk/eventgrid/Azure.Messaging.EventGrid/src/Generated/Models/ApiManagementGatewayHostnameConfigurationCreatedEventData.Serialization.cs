// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementGatewayHostnameConfigurationCreatedEventDataConverter))]
    public partial class ApiManagementGatewayHostnameConfigurationCreatedEventData
    {
        internal static ApiManagementGatewayHostnameConfigurationCreatedEventData DeserializeApiManagementGatewayHostnameConfigurationCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementGatewayHostnameConfigurationCreatedEventData(resourceUri);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ApiManagementGatewayHostnameConfigurationCreatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeApiManagementGatewayHostnameConfigurationCreatedEventData(document.RootElement);
        }

        internal partial class ApiManagementGatewayHostnameConfigurationCreatedEventDataConverter : JsonConverter<ApiManagementGatewayHostnameConfigurationCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementGatewayHostnameConfigurationCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ApiManagementGatewayHostnameConfigurationCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementGatewayHostnameConfigurationCreatedEventData(document.RootElement);
            }
        }
    }
}
