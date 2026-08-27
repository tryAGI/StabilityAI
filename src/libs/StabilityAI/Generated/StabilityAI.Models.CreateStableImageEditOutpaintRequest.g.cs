
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateStableImageEditOutpaintRequest
    {
        /// <summary>
        /// The image you wish to outpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image you wish to outpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// The number of pixels to outpaint on the left side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        public int? Left { get; set; }

        /// <summary>
        /// The number of pixels to outpaint on the right side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        public int? Right { get; set; }

        /// <summary>
        /// The number of pixels to outpaint on the top of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("up")]
        public int? Up { get; set; }

        /// <summary>
        /// The number of pixels to outpaint on the bottom of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("down")]
        public int? Down { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>))]
        public global::StabilityAI.AllOf<double?, object>? Creativity { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Guides the image model towards a particular style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestStylePresetJsonConverter))]
        public global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset? StylePreset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageEditOutpaintRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image you wish to outpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to outpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="left">
        /// The number of pixels to outpaint on the left side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="right">
        /// The number of pixels to outpaint on the right side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="up">
        /// The number of pixels to outpaint on the top of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="down">
        /// The number of pixels to outpaint on the bottom of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity"></param>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageEditOutpaintRequest(
            byte[] image,
            string imagename,
            int? left,
            int? right,
            int? up,
            int? down,
            global::StabilityAI.AllOf<double?, object>? creativity,
            string? prompt,
            double? seed,
            global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? outputFormat,
            global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset? stylePreset)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Left = left;
            this.Right = right;
            this.Up = up;
            this.Down = down;
            this.Creativity = creativity;
            this.Prompt = prompt;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.StylePreset = stylePreset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageEditOutpaintRequest" /> class.
        /// </summary>
        public CreateStableImageEditOutpaintRequest()
        {
        }

    }
}