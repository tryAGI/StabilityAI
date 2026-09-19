
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioJSONResponse
    {
        /// <summary>
        /// The generated audio, encoded to base64.<br/>
        /// Example: AAAAIGZ0eXBpc29tAAACAGlzb21pc28yYXZjMW1...
        /// </summary>
        /// <example>AAAAIGZ0eXBpc29tAAACAGlzb21pc28yYXZjMW1...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>))]
        public global::StabilityAI.AllOf<double?, object>? Seed { get; set; }

        /// <summary>
        /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
        /// Example: SUCCESS
        /// </summary>
        /// <example>SUCCESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.AudioJSONResponseFinishReasonJsonConverter))]
        public global::StabilityAI.AudioJSONResponseFinishReason FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioJSONResponse" /> class.
        /// </summary>
        /// <param name="audio">
        /// The generated audio, encoded to base64.<br/>
        /// Example: AAAAIGZ0eXBpc29tAAACAGlzb21pc28yYXZjMW1...
        /// </param>
        /// <param name="seed"></param>
        /// <param name="finishReason">
        /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
        /// Example: SUCCESS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioJSONResponse(
            string audio,
            global::StabilityAI.AllOf<double?, object>? seed,
            global::StabilityAI.AudioJSONResponseFinishReason finishReason)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Seed = seed;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioJSONResponse" /> class.
        /// </summary>
        public AudioJSONResponse()
        {
        }

    }
}