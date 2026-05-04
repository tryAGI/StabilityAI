
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAudioStableAudio2TextToAudioResponse2
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
        /// The seed used as random noise for this generation.<br/>
        /// Default Value: 0<br/>
        /// Example: 343940597
        /// </summary>
        /// <example>343940597</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
        /// Example: SUCCESS
        /// </summary>
        /// <example>SUCCESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioResponseFinishReason2JsonConverter))]
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponseFinishReason2 FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudio2TextToAudioResponse2" /> class.
        /// </summary>
        /// <param name="audio">
        /// The generated audio, encoded to base64.<br/>
        /// Example: AAAAIGZ0eXBpc29tAAACAGlzb21pc28yYXZjMW1...
        /// </param>
        /// <param name="seed">
        /// The seed used as random noise for this generation.<br/>
        /// Default Value: 0<br/>
        /// Example: 343940597
        /// </param>
        /// <param name="finishReason">
        /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
        /// Example: SUCCESS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioStableAudio2TextToAudioResponse2(
            string audio,
            double? seed,
            global::StabilityAI.CreateAudioStableAudio2TextToAudioResponseFinishReason2 finishReason)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Seed = seed;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudio2TextToAudioResponse2" /> class.
        /// </summary>
        public CreateAudioStableAudio2TextToAudioResponse2()
        {
        }
    }
}