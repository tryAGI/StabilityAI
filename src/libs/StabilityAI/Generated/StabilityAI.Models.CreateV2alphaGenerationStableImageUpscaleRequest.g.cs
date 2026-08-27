
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateV2alphaGenerationStableImageUpscaleRequest
    {
        /// <summary>
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

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
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Indicates how creative the model should be when upscaling an image.<br/>
        /// Higher values will result in more details being added to the image during upscaling.<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        public double? Creativity { get; set; }

        /// <summary>
        /// Guides the image model towards a particular style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestStylePresetJsonConverter))]
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestStylePreset? StylePreset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateV2alphaGenerationStableImageUpscaleRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
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
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity">
        /// Indicates how creative the model should be when upscaling an image.<br/>
        /// Higher values will result in more details being added to the image during upscaling.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateV2alphaGenerationStableImageUpscaleRequest(
            byte[] image,
            string imagename,
            string prompt,
            string? negativePrompt,
            global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat? outputFormat,
            double? seed,
            double? creativity,
            global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestStylePreset? stylePreset)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.OutputFormat = outputFormat;
            this.Seed = seed;
            this.Creativity = creativity;
            this.StylePreset = stylePreset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateV2alphaGenerationStableImageUpscaleRequest" /> class.
        /// </summary>
        public CreateV2alphaGenerationStableImageUpscaleRequest()
        {
        }

    }
}