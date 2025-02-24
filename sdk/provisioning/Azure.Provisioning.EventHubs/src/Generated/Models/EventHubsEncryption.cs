// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// Properties to configure Encryption.
/// </summary>
public partial class EventHubsEncryption : ProvisionableConstruct
{
    /// <summary>
    /// Properties of KeyVault.
    /// </summary>
    public BicepList<EventHubsKeyVaultProperties> KeyVaultProperties 
    {
        get { Initialize(); return _keyVaultProperties!; }
        set { Initialize(); _keyVaultProperties!.Assign(value); }
    }
    private BicepList<EventHubsKeyVaultProperties>? _keyVaultProperties;

    /// <summary>
    /// Enumerates the possible value of keySource for Encryption.
    /// </summary>
    public BicepValue<EventHubsKeySource> KeySource 
    {
        get { Initialize(); return _keySource!; }
        set { Initialize(); _keySource!.Assign(value); }
    }
    private BicepValue<EventHubsKeySource>? _keySource;

    /// <summary>
    /// Enable Infrastructure Encryption (Double Encryption).
    /// </summary>
    public BicepValue<bool> RequireInfrastructureEncryption 
    {
        get { Initialize(); return _requireInfrastructureEncryption!; }
        set { Initialize(); _requireInfrastructureEncryption!.Assign(value); }
    }
    private BicepValue<bool>? _requireInfrastructureEncryption;

    /// <summary>
    /// Creates a new EventHubsEncryption.
    /// </summary>
    public EventHubsEncryption()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventHubsEncryption.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _keyVaultProperties = DefineListProperty<EventHubsKeyVaultProperties>("KeyVaultProperties", ["keyVaultProperties"]);
        _keySource = DefineProperty<EventHubsKeySource>("KeySource", ["keySource"]);
        _requireInfrastructureEncryption = DefineProperty<bool>("RequireInfrastructureEncryption", ["requireInfrastructureEncryption"]);
    }
}
