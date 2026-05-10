
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageUpscaleFastRequest
    {
        /// <summary>
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 32 and 1,536 pixels<br/>
        /// - Height must be between 32 and 1,536 pixels<br/>
        /// - Total pixel count must be between 1,024 and 1,048,576 pixels<br/>
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
        /// - Width must be between 32 and 1,536 pixels<br/>
        /// - Height must be between 32 and 1,536 pixels<br/>
        /// - Total pixel count must be between 1,024 and 1,048,576 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageUpscaleFastRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 32 and 1,536 pixels<br/>
        /// - Height must be between 32 and 1,536 pixels<br/>
        /// - Total pixel count must be between 1,024 and 1,048,576 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 32 and 1,536 pixels<br/>
        /// - Height must be between 32 and 1,536 pixels<br/>
        /// - Total pixel count must be between 1,024 and 1,048,576 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageUpscaleFastRequest(
            byte[] image,
            string imagename,
            global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat? outputFormat)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageUpscaleFastRequest" /> class.
        /// </summary>
        public CreateStableImageUpscaleFastRequest()
        {
        }

    }
}