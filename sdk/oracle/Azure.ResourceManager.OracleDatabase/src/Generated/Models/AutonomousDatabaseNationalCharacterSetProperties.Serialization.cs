// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    internal partial class AutonomousDatabaseNationalCharacterSetProperties : IUtf8JsonSerializable, IJsonModel<AutonomousDatabaseNationalCharacterSetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutonomousDatabaseNationalCharacterSetProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutonomousDatabaseNationalCharacterSetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseNationalCharacterSetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutonomousDatabaseNationalCharacterSetProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("characterSet"u8);
            writer.WriteStringValue(CharacterSet);
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

        AutonomousDatabaseNationalCharacterSetProperties IJsonModel<AutonomousDatabaseNationalCharacterSetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseNationalCharacterSetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutonomousDatabaseNationalCharacterSetProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutonomousDatabaseNationalCharacterSetProperties(document.RootElement, options);
        }

        internal static AutonomousDatabaseNationalCharacterSetProperties DeserializeAutonomousDatabaseNationalCharacterSetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string characterSet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("characterSet"u8))
                {
                    characterSet = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutonomousDatabaseNationalCharacterSetProperties(characterSet, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutonomousDatabaseNationalCharacterSetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseNationalCharacterSetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerOracleDatabaseContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AutonomousDatabaseNationalCharacterSetProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AutonomousDatabaseNationalCharacterSetProperties IPersistableModel<AutonomousDatabaseNationalCharacterSetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseNationalCharacterSetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutonomousDatabaseNationalCharacterSetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutonomousDatabaseNationalCharacterSetProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutonomousDatabaseNationalCharacterSetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
