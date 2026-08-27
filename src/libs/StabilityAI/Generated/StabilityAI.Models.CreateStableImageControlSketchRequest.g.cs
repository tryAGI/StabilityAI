
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateStableImageControlSketchRequest
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
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// How much influence, or control, the `image` has on the generation. Represented as a float between 0 and 1, where 0 is the least influence and 1 is the maximum.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_strength")]
        public double? ControlStrength { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Guides the image model towards a particular style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestStylePresetJsonConverter))]
        public global::StabilityAI.CreateStableImageControlSketchRequestStylePreset? StylePreset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageControlSketchRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </param>
        /// <param name="image">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="controlStrength">
        /// How much influence, or control, the `image` has on the generation. Represented as a float between 0 and 1, where 0 is the least influence and 1 is the maximum.<br/>
        /// Default Value: 0.7F
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
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageControlSketchRequest(
            string prompt,
            byte[] image,
            string imagename,
            double? controlStrength,
            string? negativePrompt,
            double? seed,
            global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat? outputFormat,
            global::StabilityAI.CreateStableImageControlSketchRequestStylePreset? stylePreset)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.ControlStrength = controlStrength;
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.StylePreset = stylePreset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageControlSketchRequest" /> class.
        /// </summary>
        public CreateStableImageControlSketchRequest()
        {
        }

    }
}