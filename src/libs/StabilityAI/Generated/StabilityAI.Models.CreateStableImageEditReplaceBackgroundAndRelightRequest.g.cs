
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageEditReplaceBackgroundAndRelightRequest
    {
        /// <summary>
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] SubjectImage { get; set; }

        /// <summary>
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectImagename { get; set; }

        /// <summary>
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("background_reference")]
        public byte[]? BackgroundReference { get; set; }

        /// <summary>
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("background_referencename")]
        public string? BackgroundReferencename { get; set; }

        /// <summary>
        /// What you wish to see in the background of the output image. This could be a description<br/>
        /// of the desired background scene, or just a description of the lighting if modifying the<br/>
        /// light source through `light_source_direction` or `light_reference`.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_prompt")]
        public string? BackgroundPrompt { get; set; }

        /// <summary>
        /// Description of the subject. Use this to prevent elements of the background from<br/>
        /// bleeding into the subject. For example, if you find your subject is turning<br/>
        /// green with a forest in the background, try putting a short description of the<br/>
        /// subject in this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground_prompt")]
        public string? ForegroundPrompt { get; set; }

        /// <summary>
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// How much to overlay the original subject to exactly match the original image. A<br/>
        /// 1.0 is an exact pixel match for the subject, and 0.0 is a close match but will<br/>
        /// have new lighting qualities. This is an advanced feature.<br/>
        /// Default Value: 0.6F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_original_subject")]
        public double? PreserveOriginalSubject { get; set; }

        /// <summary>
        /// Controls the generated background to have the same depth as the original subject image. This is an advanced feature.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_background_depth")]
        public double? OriginalBackgroundDepth { get; set; }

        /// <summary>
        /// Whether to keep the background of the original image. When this is on, the background<br/>
        /// will have different lighting than the original image that changes based on the other<br/>
        /// parameters in this API.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_original_background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundJsonConverter))]
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? KeepOriginalBackground { get; set; }

        /// <summary>
        /// Direction of the light source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("light_source_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionJsonConverter))]
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? LightSourceDirection { get; set; }

        /// <summary>
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("light_reference")]
        public byte[]? LightReference { get; set; }

        /// <summary>
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("light_referencename")]
        public string? LightReferencename { get; set; }

        /// <summary>
        /// If using `light_reference_image` or `light_source_direction`, controls the strength<br/>
        /// of the light source. 1.0 is brighter and 0.0 is dimmer. This is an advanced feature.<br/>
        /// &gt; **Important:** Use of this parameter requires `light_reference` or `light_source_direction` to be provided.<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("light_source_strength")]
        public double? LightSourceStrength { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatJsonConverter))]
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageEditReplaceBackgroundAndRelightRequest" /> class.
        /// </summary>
        /// <param name="subjectImage">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="subjectImagename">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="backgroundReference">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundReferencename">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundPrompt">
        /// What you wish to see in the background of the output image. This could be a description<br/>
        /// of the desired background scene, or just a description of the lighting if modifying the<br/>
        /// light source through `light_source_direction` or `light_reference`.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.
        /// </param>
        /// <param name="foregroundPrompt">
        /// Description of the subject. Use this to prevent elements of the background from<br/>
        /// bleeding into the subject. For example, if you find your subject is turning<br/>
        /// green with a forest in the background, try putting a short description of the<br/>
        /// subject in this field.
        /// </param>
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="preserveOriginalSubject">
        /// How much to overlay the original subject to exactly match the original image. A<br/>
        /// 1.0 is an exact pixel match for the subject, and 0.0 is a close match but will<br/>
        /// have new lighting qualities. This is an advanced feature.<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="originalBackgroundDepth">
        /// Controls the generated background to have the same depth as the original subject image. This is an advanced feature.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="keepOriginalBackground">
        /// Whether to keep the background of the original image. When this is on, the background<br/>
        /// will have different lighting than the original image that changes based on the other<br/>
        /// parameters in this API.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="lightSourceDirection">
        /// Direction of the light source.
        /// </param>
        /// <param name="lightReference">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightReferencename">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightSourceStrength">
        /// If using `light_reference_image` or `light_source_direction`, controls the strength<br/>
        /// of the light source. 1.0 is brighter and 0.0 is dimmer. This is an advanced feature.<br/>
        /// &gt; **Important:** Use of this parameter requires `light_reference` or `light_source_direction` to be provided.<br/>
        /// Default Value: 0.3F
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
        public CreateStableImageEditReplaceBackgroundAndRelightRequest(
            byte[] subjectImage,
            string subjectImagename,
            byte[]? backgroundReference,
            string? backgroundReferencename,
            string? backgroundPrompt,
            string? foregroundPrompt,
            string? negativePrompt,
            double? preserveOriginalSubject,
            double? originalBackgroundDepth,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? keepOriginalBackground,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? lightSourceDirection,
            byte[]? lightReference,
            string? lightReferencename,
            double? lightSourceStrength,
            double? seed,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? outputFormat)
        {
            this.SubjectImage = subjectImage ?? throw new global::System.ArgumentNullException(nameof(subjectImage));
            this.SubjectImagename = subjectImagename ?? throw new global::System.ArgumentNullException(nameof(subjectImagename));
            this.BackgroundReference = backgroundReference;
            this.BackgroundReferencename = backgroundReferencename;
            this.BackgroundPrompt = backgroundPrompt;
            this.ForegroundPrompt = foregroundPrompt;
            this.NegativePrompt = negativePrompt;
            this.PreserveOriginalSubject = preserveOriginalSubject;
            this.OriginalBackgroundDepth = originalBackgroundDepth;
            this.KeepOriginalBackground = keepOriginalBackground;
            this.LightSourceDirection = lightSourceDirection;
            this.LightReference = lightReference;
            this.LightReferencename = lightReferencename;
            this.LightSourceStrength = lightSourceStrength;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageEditReplaceBackgroundAndRelightRequest" /> class.
        /// </summary>
        public CreateStableImageEditReplaceBackgroundAndRelightRequest()
        {
        }

    }
}