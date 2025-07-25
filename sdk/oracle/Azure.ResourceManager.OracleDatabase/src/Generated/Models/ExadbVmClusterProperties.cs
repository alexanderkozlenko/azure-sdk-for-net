// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> ExadbVmCluster resource model. </summary>
    public partial class ExadbVmClusterProperties
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

        /// <summary> Initializes a new instance of <see cref="ExadbVmClusterProperties"/>. </summary>
        /// <param name="vnetId"> VNET for network connectivity. </param>
        /// <param name="subnetId"> Client subnet. </param>
        /// <param name="displayName"> Display Name. </param>
        /// <param name="enabledEcpuCount"> The number of ECPUs to enable for an Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="exascaleDBStorageVaultId"> The Azure Resource ID of the Exadata Database Storage Vault. </param>
        /// <param name="hostname"> The hostname for the  Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="nodeCount"> The number of nodes in the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="shape"> The shape of the Exadata VM cluster on Exascale Infrastructure resource. </param>
        /// <param name="sshPublicKeys"> The public key portion of one or more key pairs used for SSH access to the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="totalEcpuCount"> The number of Total ECPUs for an Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="vmFileSystemStorage"> Filesystem storage details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetId"/>, <paramref name="subnetId"/>, <paramref name="displayName"/>, <paramref name="exascaleDBStorageVaultId"/>, <paramref name="hostname"/>, <paramref name="shape"/>, <paramref name="sshPublicKeys"/> or <paramref name="vmFileSystemStorage"/> is null. </exception>
        public ExadbVmClusterProperties(ResourceIdentifier vnetId, ResourceIdentifier subnetId, string displayName, int enabledEcpuCount, ResourceIdentifier exascaleDBStorageVaultId, string hostname, int nodeCount, string shape, IEnumerable<string> sshPublicKeys, int totalEcpuCount, ExadbVmClusterStorageDetails vmFileSystemStorage)
        {
            Argument.AssertNotNull(vnetId, nameof(vnetId));
            Argument.AssertNotNull(subnetId, nameof(subnetId));
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(exascaleDBStorageVaultId, nameof(exascaleDBStorageVaultId));
            Argument.AssertNotNull(hostname, nameof(hostname));
            Argument.AssertNotNull(shape, nameof(shape));
            Argument.AssertNotNull(sshPublicKeys, nameof(sshPublicKeys));
            Argument.AssertNotNull(vmFileSystemStorage, nameof(vmFileSystemStorage));

            VnetId = vnetId;
            SubnetId = subnetId;
            DisplayName = displayName;
            EnabledEcpuCount = enabledEcpuCount;
            ExascaleDBStorageVaultId = exascaleDBStorageVaultId;
            Hostname = hostname;
            NodeCount = nodeCount;
            NsgCidrs = new ChangeTrackingList<CloudVmClusterNsgCidr>();
            Shape = shape;
            SshPublicKeys = sshPublicKeys.ToList();
            TotalEcpuCount = totalEcpuCount;
            VmFileSystemStorage = vmFileSystemStorage;
            ScanIPIds = new ChangeTrackingList<string>();
            VipIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ExadbVmClusterProperties"/>. </summary>
        /// <param name="ocid"> ExadbVmCluster ocid. </param>
        /// <param name="clusterName"> The cluster name for Exadata VM cluster on Exascale Infrastructure. The cluster name must begin with an alphabetic character, and may contain hyphens (-). Underscores (_) are not permitted. The cluster name can be no longer than 11 characters and is not case sensitive. </param>
        /// <param name="backupSubnetCidr"> Client OCI backup subnet CIDR, default is 192.168.252.0/22. </param>
        /// <param name="nsgUri"> HTTPS link to OCI Network Security Group exposed to Azure Customer via the Azure Interface. </param>
        /// <param name="provisioningState"> Exadata VM cluster on Exascale Infrastructure provisioning state. </param>
        /// <param name="lifecycleState"> CloudVmCluster lifecycle state. </param>
        /// <param name="vnetId"> VNET for network connectivity. </param>
        /// <param name="subnetId"> Client subnet. </param>
        /// <param name="dataCollectionOptions"> Indicates user preferences for the various diagnostic collection options for the VM cluster/Cloud VM cluster/VMBM DBCS. </param>
        /// <param name="displayName"> Display Name. </param>
        /// <param name="domain"> A domain name used for the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="enabledEcpuCount"> The number of ECPUs to enable for an Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="exascaleDBStorageVaultId"> The Azure Resource ID of the Exadata Database Storage Vault. </param>
        /// <param name="gridImageOcid"> Grid Setup will be done using this Grid Image OCID. Can be obtained using giMinorVersions API. </param>
        /// <param name="gridImageType"> The type of Grid Image. </param>
        /// <param name="giVersion"> Oracle Grid Infrastructure (GI) software version. </param>
        /// <param name="hostname"> The hostname for the  Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="licenseModel"> The Oracle license model that applies to the Exadata VM cluster on Exascale Infrastructure. The default is LICENSE_INCLUDED. </param>
        /// <param name="memorySizeInGbs"> The memory that you want to be allocated in GBs. Memory is calculated based on 11 GB per VM core reserved. </param>
        /// <param name="nodeCount"> The number of nodes in the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="nsgCidrs"> CIDR blocks for additional NSG ingress rules. The VNET CIDRs used to provision the VM Cluster will be added by default. </param>
        /// <param name="zoneOcid"> The OCID of the zone the Exadata VM cluster on Exascale Infrastructure is associated with. </param>
        /// <param name="privateZoneOcid"> The OCID of the zone the Exadata VM cluster on Exascale Infrastructure is associated with. </param>
        /// <param name="scanListenerPortTcp"> The TCP Single Client Access Name (SCAN) port. The default port is 1521. </param>
        /// <param name="scanListenerPortTcpSsl"> The TCPS Single Client Access Name (SCAN) port. The default port is 2484. </param>
        /// <param name="listenerPort"> The port number configured for the listener on the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="shape"> The shape of the Exadata VM cluster on Exascale Infrastructure resource. </param>
        /// <param name="sshPublicKeys"> The public key portion of one or more key pairs used for SSH access to the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="systemVersion"> Operating system version of the image. </param>
        /// <param name="timeZone"> The time zone of the Exadata VM cluster on Exascale Infrastructure. For details, see [Exadata Infrastructure Time Zones](/Content/Database/References/timezones.htm). </param>
        /// <param name="totalEcpuCount"> The number of Total ECPUs for an Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="vmFileSystemStorage"> Filesystem storage details. </param>
        /// <param name="lifecycleDetails"> Additional information about the current lifecycle state. </param>
        /// <param name="scanDnsName"> The FQDN of the DNS record for the SCAN IP addresses that are associated with the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="scanIPIds"> The Single Client Access Name (SCAN) IP addresses associated with the Exadata VM cluster on Exascale Infrastructure. SCAN IP addresses are typically used for load balancing and are not assigned to any interface. Oracle Clusterware directs the requests to the appropriate nodes in the cluster. **Note:** For a single-node DB system, this list is empty. </param>
        /// <param name="scanDnsRecordId"> The OCID of the DNS record for the SCAN IP addresses that are associated with the Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="snapshotFileSystemStorage"> Snapshot filesystem storage details. </param>
        /// <param name="totalFileSystemStorage"> Total file system storage details. </param>
        /// <param name="vipIds"> The virtual IP (VIP) addresses associated with the Exadata VM cluster on Exascale Infrastructure. The Cluster Ready Services (CRS) creates and maintains one VIP address for each node in the Exadata Cloud Service instance to enable failover. If one node fails, the VIP is reassigned to another active node in the cluster. **Note:** For a single-node DB system, this list is empty. </param>
        /// <param name="ociUri"> HTTPS link to OCI resources exposed to Azure Customer via Azure Interface. </param>
        /// <param name="iormConfigCache"> iormConfigCache details for Exadata VM cluster on Exascale Infrastructure. </param>
        /// <param name="backupSubnetOcid"> Cluster backup subnet ocid. </param>
        /// <param name="subnetOcid"> Cluster subnet ocid. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExadbVmClusterProperties(string ocid, string clusterName, string backupSubnetCidr, Uri nsgUri, OracleDatabaseProvisioningState? provisioningState, ExadbVmClusterLifecycleState? lifecycleState, ResourceIdentifier vnetId, ResourceIdentifier subnetId, DiagnosticCollectionConfig dataCollectionOptions, string displayName, string domain, int enabledEcpuCount, ResourceIdentifier exascaleDBStorageVaultId, string gridImageOcid, GridImageType? gridImageType, string giVersion, string hostname, OracleLicenseModel? licenseModel, int? memorySizeInGbs, int nodeCount, IList<CloudVmClusterNsgCidr> nsgCidrs, string zoneOcid, string privateZoneOcid, int? scanListenerPortTcp, int? scanListenerPortTcpSsl, int? listenerPort, string shape, IList<string> sshPublicKeys, string systemVersion, string timeZone, int totalEcpuCount, ExadbVmClusterStorageDetails vmFileSystemStorage, string lifecycleDetails, string scanDnsName, IReadOnlyList<string> scanIPIds, string scanDnsRecordId, ExadbVmClusterStorageDetails snapshotFileSystemStorage, ExadbVmClusterStorageDetails totalFileSystemStorage, IReadOnlyList<string> vipIds, Uri ociUri, ExadataIormConfig iormConfigCache, string backupSubnetOcid, string subnetOcid, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Ocid = ocid;
            ClusterName = clusterName;
            BackupSubnetCidr = backupSubnetCidr;
            NsgUri = nsgUri;
            ProvisioningState = provisioningState;
            LifecycleState = lifecycleState;
            VnetId = vnetId;
            SubnetId = subnetId;
            DataCollectionOptions = dataCollectionOptions;
            DisplayName = displayName;
            Domain = domain;
            EnabledEcpuCount = enabledEcpuCount;
            ExascaleDBStorageVaultId = exascaleDBStorageVaultId;
            GridImageOcid = gridImageOcid;
            GridImageType = gridImageType;
            GiVersion = giVersion;
            Hostname = hostname;
            LicenseModel = licenseModel;
            MemorySizeInGbs = memorySizeInGbs;
            NodeCount = nodeCount;
            NsgCidrs = nsgCidrs;
            ZoneOcid = zoneOcid;
            PrivateZoneOcid = privateZoneOcid;
            ScanListenerPortTcp = scanListenerPortTcp;
            ScanListenerPortTcpSsl = scanListenerPortTcpSsl;
            ListenerPort = listenerPort;
            Shape = shape;
            SshPublicKeys = sshPublicKeys;
            SystemVersion = systemVersion;
            TimeZone = timeZone;
            TotalEcpuCount = totalEcpuCount;
            VmFileSystemStorage = vmFileSystemStorage;
            LifecycleDetails = lifecycleDetails;
            ScanDnsName = scanDnsName;
            ScanIPIds = scanIPIds;
            ScanDnsRecordId = scanDnsRecordId;
            SnapshotFileSystemStorage = snapshotFileSystemStorage;
            TotalFileSystemStorage = totalFileSystemStorage;
            VipIds = vipIds;
            OciUri = ociUri;
            IormConfigCache = iormConfigCache;
            BackupSubnetOcid = backupSubnetOcid;
            SubnetOcid = subnetOcid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExadbVmClusterProperties"/> for deserialization. </summary>
        internal ExadbVmClusterProperties()
        {
        }

        /// <summary> ExadbVmCluster ocid. </summary>
        public string Ocid { get; }
        /// <summary> The cluster name for Exadata VM cluster on Exascale Infrastructure. The cluster name must begin with an alphabetic character, and may contain hyphens (-). Underscores (_) are not permitted. The cluster name can be no longer than 11 characters and is not case sensitive. </summary>
        public string ClusterName { get; set; }
        /// <summary> Client OCI backup subnet CIDR, default is 192.168.252.0/22. </summary>
        public string BackupSubnetCidr { get; set; }
        /// <summary> HTTPS link to OCI Network Security Group exposed to Azure Customer via the Azure Interface. </summary>
        public Uri NsgUri { get; }
        /// <summary> Exadata VM cluster on Exascale Infrastructure provisioning state. </summary>
        public OracleDatabaseProvisioningState? ProvisioningState { get; }
        /// <summary> CloudVmCluster lifecycle state. </summary>
        public ExadbVmClusterLifecycleState? LifecycleState { get; }
        /// <summary> VNET for network connectivity. </summary>
        public ResourceIdentifier VnetId { get; set; }
        /// <summary> Client subnet. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Indicates user preferences for the various diagnostic collection options for the VM cluster/Cloud VM cluster/VMBM DBCS. </summary>
        public DiagnosticCollectionConfig DataCollectionOptions { get; set; }
        /// <summary> Display Name. </summary>
        public string DisplayName { get; set; }
        /// <summary> A domain name used for the Exadata VM cluster on Exascale Infrastructure. </summary>
        public string Domain { get; set; }
        /// <summary> The number of ECPUs to enable for an Exadata VM cluster on Exascale Infrastructure. </summary>
        public int EnabledEcpuCount { get; set; }
        /// <summary> The Azure Resource ID of the Exadata Database Storage Vault. </summary>
        public ResourceIdentifier ExascaleDBStorageVaultId { get; set; }
        /// <summary> Grid Setup will be done using this Grid Image OCID. Can be obtained using giMinorVersions API. </summary>
        public string GridImageOcid { get; set; }
        /// <summary> The type of Grid Image. </summary>
        public GridImageType? GridImageType { get; }
        /// <summary> Oracle Grid Infrastructure (GI) software version. </summary>
        public string GiVersion { get; }
        /// <summary> The hostname for the  Exadata VM cluster on Exascale Infrastructure. </summary>
        public string Hostname { get; set; }
        /// <summary> The Oracle license model that applies to the Exadata VM cluster on Exascale Infrastructure. The default is LICENSE_INCLUDED. </summary>
        public OracleLicenseModel? LicenseModel { get; set; }
        /// <summary> The memory that you want to be allocated in GBs. Memory is calculated based on 11 GB per VM core reserved. </summary>
        public int? MemorySizeInGbs { get; }
        /// <summary> The number of nodes in the Exadata VM cluster on Exascale Infrastructure. </summary>
        public int NodeCount { get; set; }
        /// <summary> CIDR blocks for additional NSG ingress rules. The VNET CIDRs used to provision the VM Cluster will be added by default. </summary>
        public IList<CloudVmClusterNsgCidr> NsgCidrs { get; }
        /// <summary> The OCID of the zone the Exadata VM cluster on Exascale Infrastructure is associated with. </summary>
        public string ZoneOcid { get; }
        /// <summary> The OCID of the zone the Exadata VM cluster on Exascale Infrastructure is associated with. </summary>
        public string PrivateZoneOcid { get; set; }
        /// <summary> The TCP Single Client Access Name (SCAN) port. The default port is 1521. </summary>
        public int? ScanListenerPortTcp { get; set; }
        /// <summary> The TCPS Single Client Access Name (SCAN) port. The default port is 2484. </summary>
        public int? ScanListenerPortTcpSsl { get; set; }
        /// <summary> The port number configured for the listener on the Exadata VM cluster on Exascale Infrastructure. </summary>
        public int? ListenerPort { get; }
        /// <summary> The shape of the Exadata VM cluster on Exascale Infrastructure resource. </summary>
        public string Shape { get; set; }
        /// <summary> The public key portion of one or more key pairs used for SSH access to the Exadata VM cluster on Exascale Infrastructure. </summary>
        public IList<string> SshPublicKeys { get; }
        /// <summary> Operating system version of the image. </summary>
        public string SystemVersion { get; set; }
        /// <summary> The time zone of the Exadata VM cluster on Exascale Infrastructure. For details, see [Exadata Infrastructure Time Zones](/Content/Database/References/timezones.htm). </summary>
        public string TimeZone { get; set; }
        /// <summary> The number of Total ECPUs for an Exadata VM cluster on Exascale Infrastructure. </summary>
        public int TotalEcpuCount { get; set; }
        /// <summary> Filesystem storage details. </summary>
        internal ExadbVmClusterStorageDetails VmFileSystemStorage { get; set; }
        /// <summary> Total Capacity. </summary>
        public int? VmFileSystemStorageTotalSizeInGbs
        {
            get => VmFileSystemStorage is null ? default(int?) : VmFileSystemStorage.TotalSizeInGbs;
            set
            {
                VmFileSystemStorage = value.HasValue ? new ExadbVmClusterStorageDetails(value.Value) : null;
            }
        }

        /// <summary> Additional information about the current lifecycle state. </summary>
        public string LifecycleDetails { get; }
        /// <summary> The FQDN of the DNS record for the SCAN IP addresses that are associated with the Exadata VM cluster on Exascale Infrastructure. </summary>
        public string ScanDnsName { get; }
        /// <summary> The Single Client Access Name (SCAN) IP addresses associated with the Exadata VM cluster on Exascale Infrastructure. SCAN IP addresses are typically used for load balancing and are not assigned to any interface. Oracle Clusterware directs the requests to the appropriate nodes in the cluster. **Note:** For a single-node DB system, this list is empty. </summary>
        public IReadOnlyList<string> ScanIPIds { get; }
        /// <summary> The OCID of the DNS record for the SCAN IP addresses that are associated with the Exadata VM cluster on Exascale Infrastructure. </summary>
        public string ScanDnsRecordId { get; }
        /// <summary> Snapshot filesystem storage details. </summary>
        internal ExadbVmClusterStorageDetails SnapshotFileSystemStorage { get; }
        /// <summary> Total Capacity. </summary>
        public int? SnapshotFileSystemStorageTotalSizeInGbs
        {
            get => SnapshotFileSystemStorage?.TotalSizeInGbs;
        }

        /// <summary> Total file system storage details. </summary>
        internal ExadbVmClusterStorageDetails TotalFileSystemStorage { get; }
        /// <summary> Total Capacity. </summary>
        public int? TotalSizeInGbs
        {
            get => TotalFileSystemStorage?.TotalSizeInGbs;
        }

        /// <summary> The virtual IP (VIP) addresses associated with the Exadata VM cluster on Exascale Infrastructure. The Cluster Ready Services (CRS) creates and maintains one VIP address for each node in the Exadata Cloud Service instance to enable failover. If one node fails, the VIP is reassigned to another active node in the cluster. **Note:** For a single-node DB system, this list is empty. </summary>
        public IReadOnlyList<string> VipIds { get; }
        /// <summary> HTTPS link to OCI resources exposed to Azure Customer via Azure Interface. </summary>
        public Uri OciUri { get; }
        /// <summary> iormConfigCache details for Exadata VM cluster on Exascale Infrastructure. </summary>
        public ExadataIormConfig IormConfigCache { get; }
        /// <summary> Cluster backup subnet ocid. </summary>
        public string BackupSubnetOcid { get; }
        /// <summary> Cluster subnet ocid. </summary>
        public string SubnetOcid { get; }
    }
}
