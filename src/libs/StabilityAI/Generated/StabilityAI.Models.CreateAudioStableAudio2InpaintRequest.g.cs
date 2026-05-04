
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAudioStableAudio2InpaintRequest
    {
        /// <summary>
        /// What you wish the output audio to be. A strong, descriptive prompt that clearly defines<br/>
        /// instruments, moods, styles, and genre will lead to better results.<br/>
        /// You can make a prompt as simple or complex as you like. Simple prompts are good for clean<br/>
        /// output audio. Complex prompts are good for adding texture and depth to the output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Controls the duration in seconds of the generated audio.<br/>
        /// Default Value: 190
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Controls the number of sampling steps.<br/>
        /// Default Value: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The audio to be use as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 190 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </summary>
        /// <example>./some/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// The audio to be use as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 190 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </summary>
        /// <example>./some/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_start")]
        public double? MaskStart { get; set; }

        /// <summary>
        /// Default Value: 190
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_end")]
        public double? MaskEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudio2InpaintRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What you wish the output audio to be. A strong, descriptive prompt that clearly defines<br/>
        /// instruments, moods, styles, and genre will lead to better results.<br/>
        /// You can make a prompt as simple or complex as you like. Simple prompts are good for clean<br/>
        /// output audio. Complex prompts are good for adding texture and depth to the output audio.
        /// </param>
        /// <param name="audio">
        /// The audio to be use as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 190 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </param>
        /// <param name="audioname">
        /// The audio to be use as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 190 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </param>
        /// <param name="duration">
        /// Controls the duration in seconds of the generated audio.<br/>
        /// Default Value: 190
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="steps">
        /// Controls the number of sampling steps.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="maskStart">
        /// Default Value: 30
        /// </param>
        /// <param name="maskEnd">
        /// Default Value: 190
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioStableAudio2InpaintRequest(
            string prompt,
            byte[] audio,
            string audioname,
            double? duration,
            double? seed,
            int? steps,
            global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat? outputFormat,
            double? maskStart,
            double? maskEnd)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Duration = duration;
            this.Seed = seed;
            this.Steps = steps;
            this.OutputFormat = outputFormat;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.MaskStart = maskStart;
            this.MaskEnd = maskEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudio2InpaintRequest" /> class.
        /// </summary>
        public CreateAudioStableAudio2InpaintRequest()
        {
        }
    }
}