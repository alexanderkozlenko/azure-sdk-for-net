// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Playwright.Models
{
    /// <summary> The free-trial state. </summary>
    public readonly partial struct PlaywrightFreeTrialState : IEquatable<PlaywrightFreeTrialState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PlaywrightFreeTrialState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PlaywrightFreeTrialState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string ExpiredValue = "Expired";
        private const string NotApplicableValue = "NotApplicable";

        /// <summary> The free-trial is Active. </summary>
        public static PlaywrightFreeTrialState Active { get; } = new PlaywrightFreeTrialState(ActiveValue);
        /// <summary> The free-trial is Expired. </summary>
        public static PlaywrightFreeTrialState Expired { get; } = new PlaywrightFreeTrialState(ExpiredValue);
        /// <summary> The free-trial is Not Applicable. </summary>
        public static PlaywrightFreeTrialState NotApplicable { get; } = new PlaywrightFreeTrialState(NotApplicableValue);
        /// <summary> Determines if two <see cref="PlaywrightFreeTrialState"/> values are the same. </summary>
        public static bool operator ==(PlaywrightFreeTrialState left, PlaywrightFreeTrialState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PlaywrightFreeTrialState"/> values are not the same. </summary>
        public static bool operator !=(PlaywrightFreeTrialState left, PlaywrightFreeTrialState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PlaywrightFreeTrialState"/>. </summary>
        public static implicit operator PlaywrightFreeTrialState(string value) => new PlaywrightFreeTrialState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PlaywrightFreeTrialState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PlaywrightFreeTrialState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
