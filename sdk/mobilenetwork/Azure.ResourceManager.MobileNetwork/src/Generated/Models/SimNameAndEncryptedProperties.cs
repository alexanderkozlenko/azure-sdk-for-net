// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> SIM name and encrypted properties. </summary>
    public partial class SimNameAndEncryptedProperties
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

        /// <summary> Initializes a new instance of <see cref="SimNameAndEncryptedProperties"/>. </summary>
        /// <param name="name"> The name of the SIM. </param>
        /// <param name="internationalMobileSubscriberIdentity"> The international mobile subscriber identity (IMSI) for the SIM. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="internationalMobileSubscriberIdentity"/> is null. </exception>
        public SimNameAndEncryptedProperties(string name, string internationalMobileSubscriberIdentity)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(internationalMobileSubscriberIdentity, nameof(internationalMobileSubscriberIdentity));

            Name = name;
            SiteProvisioningState = new ChangeTrackingDictionary<string, MobileNetworkSiteProvisioningState>();
            InternationalMobileSubscriberIdentity = internationalMobileSubscriberIdentity;
            StaticIPConfiguration = new ChangeTrackingList<SimStaticIPProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="SimNameAndEncryptedProperties"/>. </summary>
        /// <param name="name"> The name of the SIM. </param>
        /// <param name="provisioningState"> The provisioning state of the SIM resource. </param>
        /// <param name="simState"> The state of the SIM resource. </param>
        /// <param name="siteProvisioningState"> A dictionary of sites to the provisioning state of this SIM on that site. </param>
        /// <param name="internationalMobileSubscriberIdentity"> The international mobile subscriber identity (IMSI) for the SIM. </param>
        /// <param name="integratedCircuitCardIdentifier"> The integrated circuit card ID (ICCID) for the SIM. </param>
        /// <param name="deviceType"> An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value. </param>
        /// <param name="simPolicy"> The SIM policy used by this SIM. The SIM policy must be in the same location as the SIM. </param>
        /// <param name="staticIPConfiguration"> A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}. </param>
        /// <param name="vendorName"> The name of the SIM vendor who provided this SIM, if any. </param>
        /// <param name="vendorKeyFingerprint"> The public key fingerprint of the SIM vendor who provided this SIM, if any. </param>
        /// <param name="encryptedCredentials"> The encrypted SIM credentials. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SimNameAndEncryptedProperties(string name, MobileNetworkProvisioningState? provisioningState, MobileNetworkSimState? simState, IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> siteProvisioningState, string internationalMobileSubscriberIdentity, string integratedCircuitCardIdentifier, string deviceType, WritableSubResource simPolicy, IList<SimStaticIPProperties> staticIPConfiguration, string vendorName, string vendorKeyFingerprint, string encryptedCredentials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ProvisioningState = provisioningState;
            SimState = simState;
            SiteProvisioningState = siteProvisioningState;
            InternationalMobileSubscriberIdentity = internationalMobileSubscriberIdentity;
            IntegratedCircuitCardIdentifier = integratedCircuitCardIdentifier;
            DeviceType = deviceType;
            SimPolicy = simPolicy;
            StaticIPConfiguration = staticIPConfiguration;
            VendorName = vendorName;
            VendorKeyFingerprint = vendorKeyFingerprint;
            EncryptedCredentials = encryptedCredentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SimNameAndEncryptedProperties"/> for deserialization. </summary>
        internal SimNameAndEncryptedProperties()
        {
        }

        /// <summary> The name of the SIM. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> The provisioning state of the SIM resource. </summary>
        [WirePath("properties.provisioningState")]
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The state of the SIM resource. </summary>
        [WirePath("properties.simState")]
        public MobileNetworkSimState? SimState { get; }
        /// <summary> A dictionary of sites to the provisioning state of this SIM on that site. </summary>
        [WirePath("properties.siteProvisioningState")]
        public IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> SiteProvisioningState { get; }
        /// <summary> The international mobile subscriber identity (IMSI) for the SIM. </summary>
        [WirePath("properties.internationalMobileSubscriberIdentity")]
        public string InternationalMobileSubscriberIdentity { get; }
        /// <summary> The integrated circuit card ID (ICCID) for the SIM. </summary>
        [WirePath("properties.integratedCircuitCardIdentifier")]
        public string IntegratedCircuitCardIdentifier { get; set; }
        /// <summary> An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value. </summary>
        [WirePath("properties.deviceType")]
        public string DeviceType { get; set; }
        /// <summary> The SIM policy used by this SIM. The SIM policy must be in the same location as the SIM. </summary>
        internal WritableSubResource SimPolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        [WirePath("properties.simPolicy.id")]
        public ResourceIdentifier SimPolicyId
        {
            get => SimPolicy is null ? default : SimPolicy.Id;
            set
            {
                if (SimPolicy is null)
                    SimPolicy = new WritableSubResource();
                SimPolicy.Id = value;
            }
        }

        /// <summary> A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}. </summary>
        [WirePath("properties.staticIpConfiguration")]
        public IList<SimStaticIPProperties> StaticIPConfiguration { get; }
        /// <summary> The name of the SIM vendor who provided this SIM, if any. </summary>
        [WirePath("properties.vendorName")]
        public string VendorName { get; }
        /// <summary> The public key fingerprint of the SIM vendor who provided this SIM, if any. </summary>
        [WirePath("properties.vendorKeyFingerprint")]
        public string VendorKeyFingerprint { get; }
        /// <summary> The encrypted SIM credentials. </summary>
        [WirePath("properties.encryptedCredentials")]
        public string EncryptedCredentials { get; set; }
    }
}
