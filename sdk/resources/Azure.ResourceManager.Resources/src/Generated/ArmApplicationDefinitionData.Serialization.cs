// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ArmApplicationDefinitionData : IUtf8JsonSerializable, IJsonModel<ArmApplicationDefinitionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmApplicationDefinitionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmApplicationDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationDefinitionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("lockLevel"u8);
            writer.WriteStringValue(LockLevel.ToSerialString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations"u8);
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(PackageFileUri))
            {
                writer.WritePropertyName("packageFileUri"u8);
                writer.WriteStringValue(PackageFileUri.AbsoluteUri);
            }
            if (Optional.IsDefined(MainTemplate))
            {
                writer.WritePropertyName("mainTemplate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MainTemplate);
#else
                using (JsonDocument document = JsonDocument.Parse(MainTemplate, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(CreateUiDefinition))
            {
                writer.WritePropertyName("createUiDefinition"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CreateUiDefinition);
#else
                using (JsonDocument document = JsonDocument.Parse(CreateUiDefinition, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(NotificationPolicy))
            {
                writer.WritePropertyName("notificationPolicy"u8);
                writer.WriteObjectValue(NotificationPolicy, options);
            }
            if (Optional.IsDefined(LockingPolicy))
            {
                writer.WritePropertyName("lockingPolicy"u8);
                writer.WriteObjectValue(LockingPolicy, options);
            }
            if (Optional.IsDefined(DeploymentPolicy))
            {
                writer.WritePropertyName("deploymentPolicy"u8);
                writer.WriteObjectValue(DeploymentPolicy, options);
            }
            if (Optional.IsDefined(ManagementPolicy))
            {
                writer.WritePropertyName("managementPolicy"u8);
                writer.WriteObjectValue(ManagementPolicy, options);
            }
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStartArray();
                foreach (var item in Policies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        ArmApplicationDefinitionData IJsonModel<ArmApplicationDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationDefinitionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmApplicationDefinitionData(document.RootElement, options);
        }

        internal static ArmApplicationDefinitionData DeserializeArmApplicationDefinitionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string managedBy = default;
            ArmApplicationSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ArmApplicationLockLevel lockLevel = default;
            string displayName = default;
            bool? isEnabled = default;
            IList<ArmApplicationAuthorization> authorizations = default;
            IList<ArmApplicationDefinitionArtifact> artifacts = default;
            string description = default;
            Uri packageFileUri = default;
            BinaryData mainTemplate = default;
            BinaryData createUiDefinition = default;
            ArmApplicationNotificationPolicy notificationPolicy = default;
            ArmApplicationPackageLockingPolicy lockingPolicy = default;
            ArmApplicationDeploymentPolicy deploymentPolicy = default;
            ArmApplicationManagementPolicy managementPolicy = default;
            IList<ArmApplicationPolicy> policies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ArmApplicationSku.DeserializeArmApplicationSku(property.Value, options);
                    continue;
                }
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerResourcesContext.Default);
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
                        if (property0.NameEquals("lockLevel"u8))
                        {
                            lockLevel = property0.Value.GetString().ToArmApplicationLockLevel();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationAuthorization> array = new List<ArmApplicationAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationAuthorization.DeserializeArmApplicationAuthorization(item, options));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationDefinitionArtifact> array = new List<ArmApplicationDefinitionArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationDefinitionArtifact.DeserializeArmApplicationDefinitionArtifact(item, options));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFileUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageFileUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mainTemplate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mainTemplate = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("createUiDefinition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createUiDefinition = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("notificationPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationPolicy = ArmApplicationNotificationPolicy.DeserializeArmApplicationNotificationPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("lockingPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lockingPolicy = ArmApplicationPackageLockingPolicy.DeserializeArmApplicationPackageLockingPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("deploymentPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentPolicy = ArmApplicationDeploymentPolicy.DeserializeArmApplicationDeploymentPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managementPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementPolicy = ArmApplicationManagementPolicy.DeserializeArmApplicationManagementPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("policies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationPolicy> array = new List<ArmApplicationPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationPolicy.DeserializeArmApplicationPolicy(item, options));
                            }
                            policies = array;
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
            return new ArmApplicationDefinitionData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                managedBy,
                sku,
                serializedAdditionalRawData,
                lockLevel,
                displayName,
                isEnabled,
                authorizations ?? new ChangeTrackingList<ArmApplicationAuthorization>(),
                artifacts ?? new ChangeTrackingList<ArmApplicationDefinitionArtifact>(),
                description,
                packageFileUri,
                mainTemplate,
                createUiDefinition,
                notificationPolicy,
                lockingPolicy,
                deploymentPolicy,
                managementPolicy,
                policies ?? new ChangeTrackingList<ArmApplicationPolicy>());
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  managedBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ManagedBy))
                {
                    builder.Append("  managedBy: ");
                    if (ManagedBy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ManagedBy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ManagedBy}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sku), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sku: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("  sku: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 2, false, "  sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LockLevel), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lockLevel: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("    lockLevel: ");
                builder.AppendLine($"'{LockLevel.ToSerialString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("    displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("    isEnabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Authorizations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    authorizations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Authorizations))
                {
                    if (Authorizations.Any())
                    {
                        builder.Append("    authorizations: ");
                        builder.AppendLine("[");
                        foreach (var item in Authorizations)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    authorizations: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Artifacts), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    artifacts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Artifacts))
                {
                    if (Artifacts.Any())
                    {
                        builder.Append("    artifacts: ");
                        builder.AppendLine("[");
                        foreach (var item in Artifacts)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    artifacts: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PackageFileUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    packageFileUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PackageFileUri))
                {
                    builder.Append("    packageFileUri: ");
                    builder.AppendLine($"'{PackageFileUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MainTemplate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    mainTemplate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MainTemplate))
                {
                    builder.Append("    mainTemplate: ");
                    builder.AppendLine($"'{MainTemplate.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreateUiDefinition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    createUiDefinition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreateUiDefinition))
                {
                    builder.Append("    createUiDefinition: ");
                    builder.AppendLine($"'{CreateUiDefinition.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("NotificationEndpoints", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    notificationPolicy: ");
                builder.AppendLine("{");
                builder.AppendLine("      notificationPolicy: {");
                builder.Append("        notificationEndpoints: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(NotificationPolicy))
                {
                    builder.Append("    notificationPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NotificationPolicy, options, 4, false, "    notificationPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LockingPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lockingPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LockingPolicy))
                {
                    builder.Append("    lockingPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LockingPolicy, options, 4, false, "    lockingPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("DeploymentMode", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deploymentPolicy: ");
                builder.AppendLine("{");
                builder.AppendLine("      deploymentPolicy: {");
                builder.Append("        deploymentMode: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(DeploymentPolicy))
                {
                    builder.Append("    deploymentPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DeploymentPolicy, options, 4, false, "    deploymentPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ManagementMode", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    managementPolicy: ");
                builder.AppendLine("{");
                builder.AppendLine("      managementPolicy: {");
                builder.Append("        mode: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(ManagementPolicy))
                {
                    builder.Append("    managementPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ManagementPolicy, options, 4, false, "    managementPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Policies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    policies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Policies))
                {
                    if (Policies.Any())
                    {
                        builder.Append("    policies: ");
                        builder.AppendLine("[");
                        foreach (var item in Policies)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    policies: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ArmApplicationDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourcesContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationDefinitionData)} does not support writing '{options.Format}' format.");
            }
        }

        ArmApplicationDefinitionData IPersistableModel<ArmApplicationDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeArmApplicationDefinitionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationDefinitionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmApplicationDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
