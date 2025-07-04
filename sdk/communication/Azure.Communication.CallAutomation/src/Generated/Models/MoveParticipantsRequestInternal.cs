// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for moving participant to the call. </summary>
    internal partial class MoveParticipantsRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="MoveParticipantsRequestInternal"/>. </summary>
        /// <param name="targetParticipants"> The participant to Move. </param>
        /// <param name="fromCall"> The CallConnectionId for the call you want to move the participant from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipants"/> or <paramref name="fromCall"/> is null. </exception>
        public MoveParticipantsRequestInternal(IEnumerable<CommunicationIdentifierModel> targetParticipants, string fromCall)
        {
            Argument.AssertNotNull(targetParticipants, nameof(targetParticipants));
            Argument.AssertNotNull(fromCall, nameof(fromCall));

            TargetParticipants = targetParticipants.ToList();
            FromCall = fromCall;
        }

        /// <summary> Initializes a new instance of <see cref="MoveParticipantsRequestInternal"/>. </summary>
        /// <param name="targetParticipants"> The participant to Move. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="operationCallbackUri">
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </param>
        /// <param name="fromCall"> The CallConnectionId for the call you want to move the participant from. </param>
        internal MoveParticipantsRequestInternal(IList<CommunicationIdentifierModel> targetParticipants, string operationContext, string operationCallbackUri, string fromCall)
        {
            TargetParticipants = targetParticipants;
            OperationContext = operationContext;
            OperationCallbackUri = operationCallbackUri;
            FromCall = fromCall;
        }

        /// <summary> The participant to Move. </summary>
        public IList<CommunicationIdentifierModel> TargetParticipants { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary>
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </summary>
        public string OperationCallbackUri { get; set; }
        /// <summary> The CallConnectionId for the call you want to move the participant from. </summary>
        public string FromCall { get; }
    }
}
