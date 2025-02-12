// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring.Models
{
    public partial class ConfusionMatrixCell : IUtf8JsonSerializable, IJsonModel<ConfusionMatrixCell>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfusionMatrixCell>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfusionMatrixCell>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfusionMatrixCell>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfusionMatrixCell)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("normalizedValue"u8);
            writer.WriteNumberValue(NormalizedValue);
            writer.WritePropertyName("rawValue"u8);
            writer.WriteNumberValue(RawValue);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ConfusionMatrixCell IJsonModel<ConfusionMatrixCell>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfusionMatrixCell>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfusionMatrixCell)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfusionMatrixCell(document.RootElement, options);
        }

        internal static ConfusionMatrixCell DeserializeConfusionMatrixCell(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float normalizedValue = default;
            float rawValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("normalizedValue"u8))
                {
                    normalizedValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("rawValue"u8))
                {
                    rawValue = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfusionMatrixCell(normalizedValue, rawValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfusionMatrixCell>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfusionMatrixCell>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfusionMatrixCell)} does not support writing '{options.Format}' format.");
            }
        }

        ConfusionMatrixCell IPersistableModel<ConfusionMatrixCell>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfusionMatrixCell>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfusionMatrixCell(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfusionMatrixCell)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfusionMatrixCell>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConfusionMatrixCell FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConfusionMatrixCell(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
