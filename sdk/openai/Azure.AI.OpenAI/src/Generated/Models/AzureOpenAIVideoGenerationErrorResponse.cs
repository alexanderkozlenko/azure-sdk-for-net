// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Video
{
    internal partial class AzureOpenAIVideoGenerationErrorResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="AzureOpenAIVideoGenerationErrorResponse"/>. </summary>
        internal AzureOpenAIVideoGenerationErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureOpenAIVideoGenerationErrorResponse"/>. </summary>
        /// <param name="code"> The distinct, machine-generated identifier for the error. </param>
        /// <param name="message"> A human-readable message associated with the error. </param>
        /// <param name="param"> If applicable, the request input parameter associated with the error. </param>
        /// <param name="kind"> If applicable, the input line number associated with the error. </param>
        /// <param name="innerError"> If applicable, an upstream error that originated this error. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal AzureOpenAIVideoGenerationErrorResponse(string code, string message, string @param, string kind, AzureOpenAIVideoGenerationErrorResponseInnerError innerError, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Code = code;
            Message = message;
            Param = @param;
            Kind = kind;
            InnerError = innerError;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The distinct, machine-generated identifier for the error. </summary>
        public string Code { get; }

        /// <summary> A human-readable message associated with the error. </summary>
        public string Message { get; }

        /// <summary> If applicable, the request input parameter associated with the error. </summary>
        public string Param { get; }

        /// <summary> If applicable, the input line number associated with the error. </summary>
        public string Kind { get; }

        /// <summary> If applicable, an upstream error that originated this error. </summary>
        internal AzureOpenAIVideoGenerationErrorResponseInnerError InnerError { get; }

        /// <summary></summary>
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
