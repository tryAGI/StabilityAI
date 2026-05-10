
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageControlStyleTransferRequest
    {
        /// <summary>
        /// An image containing the subject you wish to restyle.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] InitImage { get; set; }

        /// <summary>
        /// An image containing the subject you wish to restyle.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InitImagename { get; set; }

        /// <summary>
        /// An image containing the new style.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] StyleImage { get; set; }

        /// <summary>
        /// An image containing the new style.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StyleImagename { get; set; }

        /// <summary>
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

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
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the<br/>
        /// `style_image` parameter has on the generated image. A value of 0 would yield an image that<br/>
        /// is identical to the input. A value of 1 would be as if you passed in no image at all.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_strength")]
        public double? StyleStrength { get; set; }

        /// <summary>
        /// How closely the output image's style resembles the input image's style.<br/>
        /// Default Value: 0.9F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_fidelity")]
        public double? CompositionFidelity { get; set; }

        /// <summary>
        /// How much the original image should change<br/>
        /// Default Value: 0.9F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_strength")]
        public double? ChangeStrength { get; set; }

        /// <summary>
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageControlStyleTransferRequest" /> class.
        /// </summary>
        /// <param name="initImage">
        /// An image containing the subject you wish to restyle.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="initImagename">
        /// An image containing the subject you wish to restyle.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="styleImage">
        /// An image containing the new style.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="styleImagename">
        /// An image containing the new style.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,383 pixels<br/>
        /// - Height must be between 64 and 16,383 pixels<br/>
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
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="styleStrength">
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the<br/>
        /// `style_image` parameter has on the generated image. A value of 0 would yield an image that<br/>
        /// is identical to the input. A value of 1 would be as if you passed in no image at all.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="compositionFidelity">
        /// How closely the output image's style resembles the input image's style.<br/>
        /// Default Value: 0.9F
        /// </param>
        /// <param name="changeStrength">
        /// How much the original image should change<br/>
        /// Default Value: 0.9F
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageControlStyleTransferRequest(
            byte[] initImage,
            string initImagename,
            byte[] styleImage,
            string styleImagename,
            string? prompt,
            string? negativePrompt,
            double? seed,
            double? styleStrength,
            double? compositionFidelity,
            double? changeStrength,
            global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat? outputFormat)
        {
            this.InitImage = initImage ?? throw new global::System.ArgumentNullException(nameof(initImage));
            this.InitImagename = initImagename ?? throw new global::System.ArgumentNullException(nameof(initImagename));
            this.StyleImage = styleImage ?? throw new global::System.ArgumentNullException(nameof(styleImage));
            this.StyleImagename = styleImagename ?? throw new global::System.ArgumentNullException(nameof(styleImagename));
            this.Prompt = prompt;
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.StyleStrength = styleStrength;
            this.CompositionFidelity = compositionFidelity;
            this.ChangeStrength = changeStrength;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageControlStyleTransferRequest" /> class.
        /// </summary>
        public CreateStableImageControlStyleTransferRequest()
        {
        }

    }
}