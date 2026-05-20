
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAudioStableAudioInpaintRequest
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
        /// The model to use for generation.<br/>
        /// - `stable-audio-3` requires 26 credits per generation<br/>
        /// Default Value: stable-audio-3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestModelJsonConverter))]
        public global::StabilityAI.CreateAudioStableAudioInpaintRequestModel? Model { get; set; }

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
        /// How strictly the diffusion process adheres to the prompt text (higher values make your audio closer to your prompt). Defaults to 1 if not specified.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_start")]
        public double? MaskStart { get; set; }

        /// <summary>
        /// Default Value: 380
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_end")]
        public double? MaskEnd { get; set; }

        /// <summary>
        /// The audio to be used as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 380 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </summary>
        /// <example>./some/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// The audio to be used as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 380 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </summary>
        /// <example>./some/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudioInpaintRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What you wish the output audio to be. A strong, descriptive prompt that clearly defines<br/>
        /// instruments, moods, styles, and genre will lead to better results.<br/>
        /// You can make a prompt as simple or complex as you like. Simple prompts are good for clean<br/>
        /// output audio. Complex prompts are good for adding texture and depth to the output audio.
        /// </param>
        /// <param name="audio">
        /// The audio to be used as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 380 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </param>
        /// <param name="audioname">
        /// The audio to be used as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 380 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </param>
        /// <param name="model">
        /// The model to use for generation.<br/>
        /// - `stable-audio-3` requires 26 credits per generation<br/>
        /// Default Value: stable-audio-3
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
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values make your audio closer to your prompt). Defaults to 1 if not specified.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="maskStart">
        /// Default Value: 30
        /// </param>
        /// <param name="maskEnd">
        /// Default Value: 380
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioStableAudioInpaintRequest(
            string prompt,
            byte[] audio,
            string audioname,
            global::StabilityAI.CreateAudioStableAudioInpaintRequestModel? model,
            double? duration,
            double? seed,
            int? steps,
            double? cfgScale,
            global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat? outputFormat,
            double? maskStart,
            double? maskEnd)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Duration = duration;
            this.Seed = seed;
            this.Steps = steps;
            this.CfgScale = cfgScale;
            this.OutputFormat = outputFormat;
            this.MaskStart = maskStart;
            this.MaskEnd = maskEnd;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudioInpaintRequest" /> class.
        /// </summary>
        public CreateAudioStableAudioInpaintRequest()
        {
        }

    }
}