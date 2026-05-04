
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageGenerateUltraRequest
    {
        /// <summary>
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Controls the aspect ratio of the generated image.<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestAspectRatioJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateUltraRequestAspectRatio? AspectRatio { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The image to use as the starting point for the generation.<br/>
        /// &gt; **Important:** The `strength` parameter is required when `image` is provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,384 pixels<br/>
        /// - Height must be between 64 and 16,384 pixels<br/>
        /// - Total pixel count must be at least 4,096 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image to use as the starting point for the generation.<br/>
        /// &gt; **Important:** The `strength` parameter is required when `image` is provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,384 pixels<br/>
        /// - Height must be between 64 and 16,384 pixels<br/>
        /// - Total pixel count must be at least 4,096 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Guides the image model towards a particular style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestStylePresetJsonConverter))]
        public global::StabilityAI.CreateStableImageGenerateUltraRequestStylePreset? StylePreset { get; set; }

        /// <summary>
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the <br/>
        /// `image` parameter has on the generated image.  A value of 0 would yield an image that <br/>
        /// is identical to the input.  A value of 1 would be as if you passed in no image at all.<br/>
        /// &gt; **Important:** This parameter is required when `image` is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageGenerateUltraRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </param>
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="aspectRatio">
        /// Controls the aspect ratio of the generated image.<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="image">
        /// The image to use as the starting point for the generation.<br/>
        /// &gt; **Important:** The `strength` parameter is required when `image` is provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,384 pixels<br/>
        /// - Height must be between 64 and 16,384 pixels<br/>
        /// - Total pixel count must be at least 4,096 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image to use as the starting point for the generation.<br/>
        /// &gt; **Important:** The `strength` parameter is required when `image` is provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,384 pixels<br/>
        /// - Height must be between 64 and 16,384 pixels<br/>
        /// - Total pixel count must be at least 4,096 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="strength">
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the <br/>
        /// `image` parameter has on the generated image.  A value of 0 would yield an image that <br/>
        /// is identical to the input.  A value of 1 would be as if you passed in no image at all.<br/>
        /// &gt; **Important:** This parameter is required when `image` is provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageGenerateUltraRequest(
            string prompt,
            string? negativePrompt,
            global::StabilityAI.CreateStableImageGenerateUltraRequestAspectRatio? aspectRatio,
            double? seed,
            global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat? outputFormat,
            byte[]? image,
            string? imagename,
            global::StabilityAI.CreateStableImageGenerateUltraRequestStylePreset? stylePreset,
            double? strength)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.Image = image;
            this.Imagename = imagename;
            this.StylePreset = stylePreset;
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageGenerateUltraRequest" /> class.
        /// </summary>
        public CreateStableImageGenerateUltraRequest()
        {
        }
    }
}