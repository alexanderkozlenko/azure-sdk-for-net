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
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementIdentityProviderData : IUtf8JsonSerializable, IJsonModel<ApiManagementIdentityProviderData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementIdentityProviderData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiManagementIdentityProviderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityProviderType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IdentityProviderType.Value.ToString());
            }
            if (Optional.IsDefined(SignInTenant))
            {
                writer.WritePropertyName("signinTenant"u8);
                writer.WriteStringValue(SignInTenant);
            }
            if (Optional.IsCollectionDefined(AllowedTenants))
            {
                writer.WritePropertyName("allowedTenants"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedTenants)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Authority))
            {
                writer.WritePropertyName("authority"u8);
                writer.WriteStringValue(Authority);
            }
            if (Optional.IsDefined(SignUpPolicyName))
            {
                writer.WritePropertyName("signupPolicyName"u8);
                writer.WriteStringValue(SignUpPolicyName);
            }
            if (Optional.IsDefined(SignInPolicyName))
            {
                writer.WritePropertyName("signinPolicyName"u8);
                writer.WriteStringValue(SignInPolicyName);
            }
            if (Optional.IsDefined(ProfileEditingPolicyName))
            {
                writer.WritePropertyName("profileEditingPolicyName"u8);
                writer.WriteStringValue(ProfileEditingPolicyName);
            }
            if (Optional.IsDefined(PasswordResetPolicyName))
            {
                writer.WritePropertyName("passwordResetPolicyName"u8);
                writer.WriteStringValue(PasswordResetPolicyName);
            }
            if (Optional.IsDefined(ClientLibrary))
            {
                writer.WritePropertyName("clientLibrary"u8);
                writer.WriteStringValue(ClientLibrary);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            writer.WriteEndObject();
        }

        ApiManagementIdentityProviderData IJsonModel<ApiManagementIdentityProviderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementIdentityProviderData(document.RootElement, options);
        }

        internal static ApiManagementIdentityProviderData DeserializeApiManagementIdentityProviderData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IdentityProviderType? type0 = default;
            string signinTenant = default;
            IList<string> allowedTenants = default;
            string authority = default;
            string signupPolicyName = default;
            string signinPolicyName = default;
            string profileEditingPolicyName = default;
            string passwordResetPolicyName = default;
            string clientLibrary = default;
            string clientId = default;
            string clientSecret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerApiManagementContext.Default);
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
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new IdentityProviderType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("signinTenant"u8))
                        {
                            signinTenant = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowedTenants"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            allowedTenants = array;
                            continue;
                        }
                        if (property0.NameEquals("authority"u8))
                        {
                            authority = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signupPolicyName"u8))
                        {
                            signupPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signinPolicyName"u8))
                        {
                            signinPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("profileEditingPolicyName"u8))
                        {
                            profileEditingPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("passwordResetPolicyName"u8))
                        {
                            passwordResetPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientLibrary"u8))
                        {
                            clientLibrary = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
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
            return new ApiManagementIdentityProviderData(
                id,
                name,
                type,
                systemData,
                type0,
                signinTenant,
                allowedTenants ?? new ChangeTrackingList<string>(),
                authority,
                signupPolicyName,
                signinPolicyName,
                profileEditingPolicyName,
                passwordResetPolicyName,
                clientLibrary,
                clientId,
                clientSecret,
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdentityProviderType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IdentityProviderType))
                {
                    builder.Append("    type: ");
                    builder.AppendLine($"'{IdentityProviderType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SignInTenant), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    signinTenant: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SignInTenant))
                {
                    builder.Append("    signinTenant: ");
                    if (SignInTenant.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SignInTenant}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SignInTenant}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedTenants), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    allowedTenants: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AllowedTenants))
                {
                    if (AllowedTenants.Any())
                    {
                        builder.Append("    allowedTenants: ");
                        builder.AppendLine("[");
                        foreach (var item in AllowedTenants)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Authority), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    authority: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Authority))
                {
                    builder.Append("    authority: ");
                    if (Authority.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Authority}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Authority}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SignUpPolicyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    signupPolicyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SignUpPolicyName))
                {
                    builder.Append("    signupPolicyName: ");
                    if (SignUpPolicyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SignUpPolicyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SignUpPolicyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SignInPolicyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    signinPolicyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SignInPolicyName))
                {
                    builder.Append("    signinPolicyName: ");
                    if (SignInPolicyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SignInPolicyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SignInPolicyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProfileEditingPolicyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    profileEditingPolicyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProfileEditingPolicyName))
                {
                    builder.Append("    profileEditingPolicyName: ");
                    if (ProfileEditingPolicyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProfileEditingPolicyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProfileEditingPolicyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PasswordResetPolicyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    passwordResetPolicyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PasswordResetPolicyName))
                {
                    builder.Append("    passwordResetPolicyName: ");
                    if (PasswordResetPolicyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PasswordResetPolicyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PasswordResetPolicyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientLibrary), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    clientLibrary: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientLibrary))
                {
                    builder.Append("    clientLibrary: ");
                    if (ClientLibrary.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientLibrary}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientLibrary}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    clientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientId))
                {
                    builder.Append("    clientId: ");
                    if (ClientId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientSecret), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    clientSecret: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientSecret))
                {
                    builder.Append("    clientSecret: ");
                    if (ClientSecret.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientSecret}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientSecret}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApiManagementIdentityProviderData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiManagementContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementIdentityProviderData IPersistableModel<ApiManagementIdentityProviderData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiManagementIdentityProviderData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementIdentityProviderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
