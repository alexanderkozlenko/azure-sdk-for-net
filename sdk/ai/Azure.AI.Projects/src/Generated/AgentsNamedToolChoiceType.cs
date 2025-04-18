// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> Available tool types for agents named tools. </summary>
    public readonly partial struct AgentsNamedToolChoiceType : IEquatable<AgentsNamedToolChoiceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgentsNamedToolChoiceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgentsNamedToolChoiceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";
        private const string CodeInterpreterValue = "code_interpreter";
        private const string FileSearchValue = "file_search";
        private const string BingGroundingValue = "bing_grounding";
        private const string MicrosoftFabricValue = "fabric_dataagent";
        private const string SharepointValue = "sharepoint_grounding";
        private const string AzureAISearchValue = "azure_ai_search";
        private const string BingCustomSearchValue = "bing_custom_search";
        private const string ConnectedAgentValue = "connected_agent";

        /// <summary> Tool type `function`. </summary>
        public static AgentsNamedToolChoiceType Function { get; } = new AgentsNamedToolChoiceType(FunctionValue);
        /// <summary> Tool type `code_interpreter`. </summary>
        public static AgentsNamedToolChoiceType CodeInterpreter { get; } = new AgentsNamedToolChoiceType(CodeInterpreterValue);
        /// <summary> Tool type `file_search`. </summary>
        public static AgentsNamedToolChoiceType FileSearch { get; } = new AgentsNamedToolChoiceType(FileSearchValue);
        /// <summary> Tool type `bing_grounding`. </summary>
        public static AgentsNamedToolChoiceType BingGrounding { get; } = new AgentsNamedToolChoiceType(BingGroundingValue);
        /// <summary> Tool type `fabric_dataagent`. </summary>
        public static AgentsNamedToolChoiceType MicrosoftFabric { get; } = new AgentsNamedToolChoiceType(MicrosoftFabricValue);
        /// <summary> Tool type `sharepoint_grounding`. </summary>
        public static AgentsNamedToolChoiceType Sharepoint { get; } = new AgentsNamedToolChoiceType(SharepointValue);
        /// <summary> Tool type `azure_ai_search`. </summary>
        public static AgentsNamedToolChoiceType AzureAISearch { get; } = new AgentsNamedToolChoiceType(AzureAISearchValue);
        /// <summary> Tool type `bing_custom_search`. </summary>
        public static AgentsNamedToolChoiceType BingCustomSearch { get; } = new AgentsNamedToolChoiceType(BingCustomSearchValue);
        /// <summary> Tool type `connected_agent`. </summary>
        public static AgentsNamedToolChoiceType ConnectedAgent { get; } = new AgentsNamedToolChoiceType(ConnectedAgentValue);
        /// <summary> Determines if two <see cref="AgentsNamedToolChoiceType"/> values are the same. </summary>
        public static bool operator ==(AgentsNamedToolChoiceType left, AgentsNamedToolChoiceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgentsNamedToolChoiceType"/> values are not the same. </summary>
        public static bool operator !=(AgentsNamedToolChoiceType left, AgentsNamedToolChoiceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AgentsNamedToolChoiceType"/>. </summary>
        public static implicit operator AgentsNamedToolChoiceType(string value) => new AgentsNamedToolChoiceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgentsNamedToolChoiceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgentsNamedToolChoiceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
