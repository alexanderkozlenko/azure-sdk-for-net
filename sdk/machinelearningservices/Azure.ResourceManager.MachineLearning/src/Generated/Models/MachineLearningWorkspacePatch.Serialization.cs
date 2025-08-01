// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspacePatch : IUtf8JsonSerializable, IJsonModel<MachineLearningWorkspacePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWorkspacePatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningWorkspacePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, ModelSerializationExtensions.WireV3Options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ImageBuildCompute))
            {
                writer.WritePropertyName("imageBuildCompute"u8);
                writer.WriteStringValue(ImageBuildCompute);
            }
            if (Optional.IsDefined(ServiceManagedResourcesSettings))
            {
                writer.WritePropertyName("serviceManagedResourcesSettings"u8);
                writer.WriteObjectValue(ServiceManagedResourcesSettings, options);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentity))
            {
                writer.WritePropertyName("primaryUserAssignedIdentity"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentity);
            }
            if (Optional.IsDefined(ServerlessComputeSettings))
            {
                writer.WritePropertyName("serverlessComputeSettings"u8);
                writer.WriteObjectValue(ServerlessComputeSettings, options);
            }
            if (Optional.IsDefined(PublicNetworkAccessType))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccessType.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationInsights))
            {
                writer.WritePropertyName("applicationInsights"u8);
                writer.WriteStringValue(ApplicationInsights);
            }
            if (Optional.IsDefined(ContainerRegistry))
            {
                writer.WritePropertyName("containerRegistry"u8);
                writer.WriteStringValue(ContainerRegistry);
            }
            if (Optional.IsDefined(FeatureStoreSettings))
            {
                writer.WritePropertyName("featureStoreSettings"u8);
                writer.WriteObjectValue(FeatureStoreSettings, options);
            }
            if (Optional.IsDefined(ManagedNetwork))
            {
                writer.WritePropertyName("managedNetwork"u8);
                writer.WriteObjectValue(ManagedNetwork, options);
            }
            if (Optional.IsDefined(EnableDataIsolation))
            {
                writer.WritePropertyName("enableDataIsolation"u8);
                writer.WriteBooleanValue(EnableDataIsolation.Value);
            }
            if (Optional.IsDefined(V1LegacyMode))
            {
                writer.WritePropertyName("v1LegacyMode"u8);
                writer.WriteBooleanValue(V1LegacyMode.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MachineLearningWorkspacePatch IJsonModel<MachineLearningWorkspacePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspacePatch(document.RootElement, options);
        }

        internal static MachineLearningWorkspacePatch DeserializeMachineLearningWorkspacePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            MachineLearningSku sku = default;
            ManagedServiceIdentity identity = default;
            string description = default;
            string friendlyName = default;
            string imageBuildCompute = default;
            ServiceManagedResourcesSettings serviceManagedResourcesSettings = default;
            string primaryUserAssignedIdentity = default;
            ServerlessComputeSettings serverlessComputeSettings = default;
            PublicNetworkAccess? publicNetworkAccess = default;
            string applicationInsights = default;
            string containerRegistry = default;
            FeatureStoreSettings featureStoreSettings = default;
            ManagedNetworkSettings managedNetwork = default;
            bool? enableDataIsolation = default;
            bool? v1LegacyMode = default;
            EncryptionUpdateProperties encryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = MachineLearningSku.DeserializeMachineLearningSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireV3Options, AzureResourceManagerMachineLearningContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageBuildCompute"u8))
                        {
                            imageBuildCompute = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceManagedResourcesSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceManagedResourcesSettings = ServiceManagedResourcesSettings.DeserializeServiceManagedResourcesSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("primaryUserAssignedIdentity"u8))
                        {
                            primaryUserAssignedIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverlessComputeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverlessComputeSettings = ServerlessComputeSettings.DeserializeServerlessComputeSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationInsights"u8))
                        {
                            applicationInsights = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerRegistry"u8))
                        {
                            containerRegistry = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("featureStoreSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            featureStoreSettings = FeatureStoreSettings.DeserializeFeatureStoreSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managedNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedNetwork = ManagedNetworkSettings.DeserializeManagedNetworkSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableDataIsolation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDataIsolation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("v1LegacyMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            v1LegacyMode = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = EncryptionUpdateProperties.DeserializeEncryptionUpdateProperties(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningWorkspacePatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                sku,
                identity,
                description,
                friendlyName,
                imageBuildCompute,
                serviceManagedResourcesSettings,
                primaryUserAssignedIdentity,
                serverlessComputeSettings,
                publicNetworkAccess,
                applicationInsights,
                containerRegistry,
                featureStoreSettings,
                managedNetwork,
                enableDataIsolation,
                v1LegacyMode,
                encryption,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningWorkspacePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningWorkspacePatch IPersistableModel<MachineLearningWorkspacePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspacePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningWorkspacePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspacePatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWorkspacePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
