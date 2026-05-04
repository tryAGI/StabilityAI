
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAudioStableAudio2AudioToAudioRequest
    {
        /// <summary>
        /// What you wish the output audio to be. A strong, descriptive prompt that clearly defines<br/>
        /// instruments, moods, styles, and genre will lead to better results.<br/>
        /// You can make a prompt as simple or complex as you like. Simple prompts are good for clean<br/>
        /// output audio. Complex prompts are good for adding texture and depth to the output audio.<br/>
        /// Check our [prompt guide](https://www.stableaudio.com/user-guide/audio-to-audio) for tips.
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
        /// - For `stable-audio-2`: accepts steps between `30` and `100` (defaults to `50`).<br/>
        /// - For `stable-audio-2.5`: accepts steps between `4` and `8` (defaults to `8`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// How strictly the diffusion process adheres to the prompt text (higher values make your<br/>
        /// audio closer to your prompt). <br/>
        /// Defaults to 7 for `stable-audio-2` and 1 for `stable-audio-2.5` if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// The model to use for generation.<br/>
        /// - `stable-audio-2.5` requires 20 credits per generation<br/>
        /// - `stable-audio-2` requires 20 credits per generation<br/>
        /// Default Value: stable-audio-2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestModelJsonConverter))]
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel? Model { get; set; }

        /// <summary>
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat? OutputFormat { get; set; }

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
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the<br/>
        /// `audio` parameter has on the generated audio.<br/>
        /// A value of 0 would yield audio that is identical to the input.<br/>
        /// A value of 1 would be as if you passed in no audio at all.<br/>
        /// Minimum value for `stable-audio-2.5` is 0.01.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudio2AudioToAudioRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What you wish the output audio to be. A strong, descriptive prompt that clearly defines<br/>
        /// instruments, moods, styles, and genre will lead to better results.<br/>
        /// You can make a prompt as simple or complex as you like. Simple prompts are good for clean<br/>
        /// output audio. Complex prompts are good for adding texture and depth to the output audio.<br/>
        /// Check our [prompt guide](https://www.stableaudio.com/user-guide/audio-to-audio) for tips.
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
        /// - For `stable-audio-2`: accepts steps between `30` and `100` (defaults to `50`).<br/>
        /// - For `stable-audio-2.5`: accepts steps between `4` and `8` (defaults to `8`).
        /// </param>
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values make your<br/>
        /// audio closer to your prompt). <br/>
        /// Defaults to 7 for `stable-audio-2` and 1 for `stable-audio-2.5` if not specified.
        /// </param>
        /// <param name="model">
        /// The model to use for generation.<br/>
        /// - `stable-audio-2.5` requires 20 credits per generation<br/>
        /// - `stable-audio-2` requires 20 credits per generation<br/>
        /// Default Value: stable-audio-2
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="strength">
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the<br/>
        /// `audio` parameter has on the generated audio.<br/>
        /// A value of 0 would yield audio that is identical to the input.<br/>
        /// A value of 1 would be as if you passed in no audio at all.<br/>
        /// Minimum value for `stable-audio-2.5` is 0.01.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioStableAudio2AudioToAudioRequest(
            string prompt,
            byte[] audio,
            string audioname,
            double? duration,
            double? seed,
            int? steps,
            double? cfgScale,
            global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel? model,
            global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat? outputFormat,
            double? strength)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Duration = duration;
            this.Seed = seed;
            this.Steps = steps;
            this.CfgScale = cfgScale;
            this.Model = model;
            this.OutputFormat = outputFormat;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioStableAudio2AudioToAudioRequest" /> class.
        /// </summary>
        public CreateAudioStableAudio2AudioToAudioRequest()
        {
        }
    }
}