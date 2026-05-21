
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageGenerateSd3Request
    {
        /// <summary>
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Controls whether this is a text-to-image or image-to-image generation, which affects which parameters are required:<br/>
        /// - **text-to-image** requires only the `prompt` parameter<br/>
        /// - **image-to-image** requires the `prompt`, `image`, and `strength` parameters<br/>
        /// Default Value: text-to-image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModeJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateSd3RequestMode? Mode { get; set; }

        /// <summary>
        /// The image to use as the starting point for the generation.<br/>
        /// Supported formats:<br/>
        ///   - jpeg<br/>
        ///   - png<br/>
        ///   - webp<br/>
        /// Supported dimensions:<br/>
        ///   - Every side must be at least 64 pixels<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to use as the starting point for the generation.<br/>
        /// Supported formats:<br/>
        ///   - jpeg<br/>
        ///   - png<br/>
        ///   - webp<br/>
        /// Supported dimensions:<br/>
        ///   - Every side must be at least 64 pixels<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the<br/>
        /// `image` parameter has on the generated image.  A value of 0 would yield an image that<br/>
        /// is identical to the input.  A value of 1 would be as if you passed in no image at all.<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests. For SD 3.5 Flash, the<br/>
        ///  best results for image-to-image generation are achieved with a `strength` between .94 - .97.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Controls the aspect ratio of the generated image. Defaults to 1:1.<br/>
        /// &gt; **Important:** This parameter is only valid for **text-to-image** requests.<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestAspectRatioJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The model to use for generation.<br/>
        /// - `sd3.5-large` requires 6.5 credits per generation<br/>
        /// - `sd3.5-large-turbo` requires 4 credits per generation<br/>
        /// - `sd3.5-medium` requires 3.5 credits per generation<br/>
        /// - `sd3.5-flash` requires 2.5 credits per generation<br/>
        /// - As of the April 17, 2025, `sd3-large`, `sd3-large-turbo` and `sd3-medium`<br/>
        ///   are re-routed to their `sd3.5-[model version]` equivalent, at the same price.<br/>
        /// Default Value: sd3.5-large
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModelJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateSd3RequestModel? Model { get; set; }

        /// <summary>
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Guides the image model towards a particular style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestStylePresetJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateSd3RequestStylePreset? StylePreset { get; set; }

        /// <summary>
        /// Keywords of what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// How strictly the diffusion process adheres to the prompt text (higher values keep your image closer to your prompt). The _Large_ and _Medium_ models use a default of `4`. The _Turbo_ and _Flash_ model uses a default of `1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageGenerateSd3Request" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.
        /// </param>
        /// <param name="mode">
        /// Controls whether this is a text-to-image or image-to-image generation, which affects which parameters are required:<br/>
        /// - **text-to-image** requires only the `prompt` parameter<br/>
        /// - **image-to-image** requires the `prompt`, `image`, and `strength` parameters<br/>
        /// Default Value: text-to-image
        /// </param>
        /// <param name="image">
        /// The image to use as the starting point for the generation.<br/>
        /// Supported formats:<br/>
        ///   - jpeg<br/>
        ///   - png<br/>
        ///   - webp<br/>
        /// Supported dimensions:<br/>
        ///   - Every side must be at least 64 pixels<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests.
        /// </param>
        /// <param name="imagename">
        /// The image to use as the starting point for the generation.<br/>
        /// Supported formats:<br/>
        ///   - jpeg<br/>
        ///   - png<br/>
        ///   - webp<br/>
        /// Supported dimensions:<br/>
        ///   - Every side must be at least 64 pixels<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests.
        /// </param>
        /// <param name="strength">
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the<br/>
        /// `image` parameter has on the generated image.  A value of 0 would yield an image that<br/>
        /// is identical to the input.  A value of 1 would be as if you passed in no image at all.<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests. For SD 3.5 Flash, the<br/>
        ///  best results for image-to-image generation are achieved with a `strength` between .94 - .97.
        /// </param>
        /// <param name="aspectRatio">
        /// Controls the aspect ratio of the generated image. Defaults to 1:1.<br/>
        /// &gt; **Important:** This parameter is only valid for **text-to-image** requests.<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="model">
        /// The model to use for generation.<br/>
        /// - `sd3.5-large` requires 6.5 credits per generation<br/>
        /// - `sd3.5-large-turbo` requires 4 credits per generation<br/>
        /// - `sd3.5-medium` requires 3.5 credits per generation<br/>
        /// - `sd3.5-flash` requires 2.5 credits per generation<br/>
        /// - As of the April 17, 2025, `sd3-large`, `sd3-large-turbo` and `sd3-medium`<br/>
        ///   are re-routed to their `sd3.5-[model version]` equivalent, at the same price.<br/>
        /// Default Value: sd3.5-large
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="negativePrompt">
        /// Keywords of what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values keep your image closer to your prompt). The _Large_ and _Medium_ models use a default of `4`. The _Turbo_ and _Flash_ model uses a default of `1`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageGenerateSd3Request(
            string prompt,
            global::StabilityAI.CreateStableImageGenerateSd3RequestMode? mode,
            byte[]? image,
            string? imagename,
            double? strength,
            global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio? aspectRatio,
            global::StabilityAI.CreateStableImageGenerateSd3RequestModel? model,
            double? seed,
            global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat? outputFormat,
            global::StabilityAI.CreateStableImageGenerateSd3RequestStylePreset? stylePreset,
            string? negativePrompt,
            double? cfgScale)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Mode = mode;
            this.Image = image;
            this.Imagename = imagename;
            this.Strength = strength;
            this.AspectRatio = aspectRatio;
            this.Model = model;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.StylePreset = stylePreset;
            this.NegativePrompt = negativePrompt;
            this.CfgScale = cfgScale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageGenerateSd3Request" /> class.
        /// </summary>
        public CreateStableImageGenerateSd3Request()
        {
        }

    }
}