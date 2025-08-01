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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlLocationCapabilities : IUtf8JsonSerializable, IJsonModel<SqlLocationCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlLocationCapabilities>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlLocationCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlLocationCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlLocationCapabilities)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedServerVersions))
            {
                writer.WritePropertyName("supportedServerVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedServerVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedManagedInstanceVersions))
            {
                writer.WritePropertyName("supportedManagedInstanceVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedManagedInstanceVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedJobAgentVersions))
            {
                writer.WritePropertyName("supportedJobAgentVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedJobAgentVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsZoneResilientProvisioningAllowed))
            {
                writer.WritePropertyName("isZoneResilientProvisioningAllowed"u8);
                writer.WriteBooleanValue(IsZoneResilientProvisioningAllowed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
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

        SqlLocationCapabilities IJsonModel<SqlLocationCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlLocationCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlLocationCapabilities)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlLocationCapabilities(document.RootElement, options);
        }

        internal static SqlLocationCapabilities DeserializeSqlLocationCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<SqlServerVersionCapability> supportedServerVersions = default;
            IReadOnlyList<ManagedInstanceVersionCapability> supportedManagedInstanceVersions = default;
            IReadOnlyList<JobAgentVersionCapability> supportedJobAgentVersions = default;
            bool? isZoneResilientProvisioningAllowed = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedServerVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlServerVersionCapability> array = new List<SqlServerVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlServerVersionCapability.DeserializeSqlServerVersionCapability(item, options));
                    }
                    supportedServerVersions = array;
                    continue;
                }
                if (property.NameEquals("supportedManagedInstanceVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceVersionCapability> array = new List<ManagedInstanceVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceVersionCapability.DeserializeManagedInstanceVersionCapability(item, options));
                    }
                    supportedManagedInstanceVersions = array;
                    continue;
                }
                if (property.NameEquals("supportedJobAgentVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobAgentVersionCapability> array = new List<JobAgentVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobAgentVersionCapability.DeserializeJobAgentVersionCapability(item, options));
                    }
                    supportedJobAgentVersions = array;
                    continue;
                }
                if (property.NameEquals("isZoneResilientProvisioningAllowed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isZoneResilientProvisioningAllowed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlLocationCapabilities(
                name,
                supportedServerVersions ?? new ChangeTrackingList<SqlServerVersionCapability>(),
                supportedManagedInstanceVersions ?? new ChangeTrackingList<ManagedInstanceVersionCapability>(),
                supportedJobAgentVersions ?? new ChangeTrackingList<JobAgentVersionCapability>(),
                isZoneResilientProvisioningAllowed,
                status,
                reason,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedServerVersions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedServerVersions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedServerVersions))
                {
                    if (SupportedServerVersions.Any())
                    {
                        builder.Append("  supportedServerVersions: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedServerVersions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedServerVersions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedManagedInstanceVersions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedManagedInstanceVersions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedManagedInstanceVersions))
                {
                    if (SupportedManagedInstanceVersions.Any())
                    {
                        builder.Append("  supportedManagedInstanceVersions: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedManagedInstanceVersions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedManagedInstanceVersions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedJobAgentVersions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedJobAgentVersions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedJobAgentVersions))
                {
                    if (SupportedJobAgentVersions.Any())
                    {
                        builder.Append("  supportedJobAgentVersions: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedJobAgentVersions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  supportedJobAgentVersions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsZoneResilientProvisioningAllowed), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isZoneResilientProvisioningAllowed: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsZoneResilientProvisioningAllowed))
                {
                    builder.Append("  isZoneResilientProvisioningAllowed: ");
                    var boolValue = IsZoneResilientProvisioningAllowed.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reason), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  reason: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Reason))
                {
                    builder.Append("  reason: ");
                    if (Reason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Reason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Reason}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SqlLocationCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlLocationCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSqlContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SqlLocationCapabilities)} does not support writing '{options.Format}' format.");
            }
        }

        SqlLocationCapabilities IPersistableModel<SqlLocationCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlLocationCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSqlLocationCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlLocationCapabilities)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlLocationCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
