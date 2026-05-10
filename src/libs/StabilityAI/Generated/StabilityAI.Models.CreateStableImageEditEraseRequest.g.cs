
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageEditEraseRequest
    {
        /// <summary>
        /// The image you wish to erase from.<br/>
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
        /// The image you wish to erase from.<br/>
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
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// Grows the edges of the mask outward in all directions by the specified number of pixels. The expanded area around the mask will be blurred, which can help smooth the transition between inpainted content and the original image.<br/>
        /// Try this parameter if you notice seams or rough edges around the inpainted content.<br/>
        /// &gt; Note: Excessive growth may obscure fine details in the mask and/or merge nearby masked regions.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grow_mask")]
        public double? GrowMask { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageEditEraseRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image you wish to erase from.<br/>
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
        /// The image you wish to erase from.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="mask">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="maskname">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="growMask">
        /// Grows the edges of the mask outward in all directions by the specified number of pixels. The expanded area around the mask will be blurred, which can help smooth the transition between inpainted content and the original image.<br/>
        /// Try this parameter if you notice seams or rough edges around the inpainted content.<br/>
        /// &gt; Note: Excessive growth may obscure fine details in the mask and/or merge nearby masked regions.<br/>
        /// Default Value: 5
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
        public CreateStableImageEditEraseRequest(
            byte[] image,
            string imagename,
            byte[]? mask,
            string? maskname,
            double? growMask,
            double? seed,
            global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat? outputFormat)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Mask = mask;
            this.Maskname = maskname;
            this.GrowMask = growMask;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageEditEraseRequest" /> class.
        /// </summary>
        public CreateStableImageEditEraseRequest()
        {
        }

    }
}