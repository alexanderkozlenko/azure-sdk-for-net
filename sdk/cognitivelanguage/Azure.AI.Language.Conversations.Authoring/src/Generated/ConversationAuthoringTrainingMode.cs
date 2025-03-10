// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> The ConversationAuthoringTrainingMode. </summary>
    public readonly partial struct ConversationAuthoringTrainingMode : IEquatable<ConversationAuthoringTrainingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringTrainingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConversationAuthoringTrainingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AdvancedValue = "advanced";
        private const string StandardValue = "standard";

        /// <summary> Trains using fine-tuned neural network transformer models. Can train multilingual projects. </summary>
        public static ConversationAuthoringTrainingMode Advanced { get; } = new ConversationAuthoringTrainingMode(AdvancedValue);
        /// <summary> Faster training times for quicker iterations. </summary>
        public static ConversationAuthoringTrainingMode Standard { get; } = new ConversationAuthoringTrainingMode(StandardValue);
        /// <summary> Determines if two <see cref="ConversationAuthoringTrainingMode"/> values are the same. </summary>
        public static bool operator ==(ConversationAuthoringTrainingMode left, ConversationAuthoringTrainingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConversationAuthoringTrainingMode"/> values are not the same. </summary>
        public static bool operator !=(ConversationAuthoringTrainingMode left, ConversationAuthoringTrainingMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConversationAuthoringTrainingMode"/>. </summary>
        public static implicit operator ConversationAuthoringTrainingMode(string value) => new ConversationAuthoringTrainingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationAuthoringTrainingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConversationAuthoringTrainingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
