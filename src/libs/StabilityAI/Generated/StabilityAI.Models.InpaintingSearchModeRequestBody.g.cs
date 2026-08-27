
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InpaintingSearchModeRequestBody
    {
        /// <summary>
        /// Controls how the model decides which areas to inpaint and which areas to leave alone.<br/>
        /// Specifying `mask` requires:<br/>
        ///   - Provide an explicit mask image in the `mask` parameter<br/>
        ///   - Use the alpha channel of the `image` parameter as the mask<br/>
        /// Specifying `search` requires:<br/>
        ///   - Provide a small description of what to inpaint in the `search_prompt` parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyModeJsonConverter))]
        public global::StabilityAI.InpaintingSearchModeRequestBodyMode Mode { get; set; }

        /// <summary>
        /// Short description of what to inpaint in the `image`.<br/>
        /// Example: glasses
        /// </summary>
        /// <example>glasses</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchPrompt { get; set; }

        /// <summary>
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyOutputFormatJsonConverter))]
        public global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintingSearchModeRequestBody" /> class.
        /// </summary>
        /// <param name="searchPrompt">
        /// Short description of what to inpaint in the `image`.<br/>
        /// Example: glasses
        /// </param>
        /// <param name="image">
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
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
        /// <param name="mode">
        /// Controls how the model decides which areas to inpaint and which areas to leave alone.<br/>
        /// Specifying `mask` requires:<br/>
        ///   - Provide an explicit mask image in the `mask` parameter<br/>
        ///   - Use the alpha channel of the `image` parameter as the mask<br/>
        /// Specifying `search` requires:<br/>
        ///   - Provide a small description of what to inpaint in the `search_prompt` parameter
        /// </param>
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InpaintingSearchModeRequestBody(
            string searchPrompt,
            byte[] image,
            string imagename,
            string prompt,
            global::StabilityAI.InpaintingSearchModeRequestBodyMode mode,
            string? negativePrompt,
            double? seed,
            global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat? outputFormat)
        {
            this.Mode = mode;
            this.SearchPrompt = searchPrompt ?? throw new global::System.ArgumentNullException(nameof(searchPrompt));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintingSearchModeRequestBody" /> class.
        /// </summary>
        public InpaintingSearchModeRequestBody()
        {
        }

    }
}