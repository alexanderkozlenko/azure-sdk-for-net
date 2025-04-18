// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AgriculturePlatform.Models
{
    /// <summary> Details of the Agriculture AgriDataManager. </summary>
    public partial class AgricultureServiceProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AgricultureServiceProperties"/>. </summary>
        public AgricultureServiceProperties()
        {
            DataConnectorCredentials = new ChangeTrackingList<DataConnectorCredentialMap>();
            InstalledSolutions = new ChangeTrackingList<InstalledSolutionMap>();
        }

        /// <summary> Initializes a new instance of <see cref="AgricultureServiceProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="config"> Config of the AgriService instance. </param>
        /// <param name="managedOnBehalfOfConfiguration"> Managed On Behalf Of Configuration. </param>
        /// <param name="dataConnectorCredentials"> Data connector credentials of AgriService instance. </param>
        /// <param name="installedSolutions"> AgriService installed solutions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgricultureServiceProperties(AgriculturePlatformProvisioningState? provisioningState, AgricultureServiceConfig config, ManagedOnBehalfOfConfiguration managedOnBehalfOfConfiguration, IList<DataConnectorCredentialMap> dataConnectorCredentials, IList<InstalledSolutionMap> installedSolutions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Config = config;
            ManagedOnBehalfOfConfiguration = managedOnBehalfOfConfiguration;
            DataConnectorCredentials = dataConnectorCredentials;
            InstalledSolutions = installedSolutions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the last operation. </summary>
        public AgriculturePlatformProvisioningState? ProvisioningState { get; }
        /// <summary> Config of the AgriService instance. </summary>
        public AgricultureServiceConfig Config { get; set; }
        /// <summary> Managed On Behalf Of Configuration. </summary>
        internal ManagedOnBehalfOfConfiguration ManagedOnBehalfOfConfiguration { get; }
        /// <summary> Associated MoboBrokerResources. </summary>
        public IReadOnlyList<SubResource> ManagedOnBehalfOfMoboBrokerResources
        {
            get => ManagedOnBehalfOfConfiguration?.MoboBrokerResources;
        }

        /// <summary> Data connector credentials of AgriService instance. </summary>
        public IList<DataConnectorCredentialMap> DataConnectorCredentials { get; }
        /// <summary> AgriService installed solutions. </summary>
        public IList<InstalledSolutionMap> InstalledSolutions { get; }
    }
}
