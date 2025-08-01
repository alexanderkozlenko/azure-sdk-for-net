// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class ManagementLockResource : IJsonModel<ManagementLockData>
    {
        private static ManagementLockData s_dataDeserializationInstance;
        private static ManagementLockData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ManagementLockData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagementLockData>)Data).Write(writer, options);

        ManagementLockData IJsonModel<ManagementLockData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagementLockData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ManagementLockData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options, AzureResourceManagerContext.Default);

        ManagementLockData IPersistableModel<ManagementLockData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagementLockData>(data, options, AzureResourceManagerContext.Default);

        string IPersistableModel<ManagementLockData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagementLockData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
