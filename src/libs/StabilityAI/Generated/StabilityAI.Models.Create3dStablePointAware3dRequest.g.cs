
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Create3dStablePointAware3dRequest
    {
        /// <summary>
        /// The image to generate a 3D model from.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 4,194,304 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image to generate a 3D model from.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 4,194,304 pixels<br/>
        /// Example: ./some/image.png
        /// </summary>
        /// <example>./some/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Determines the resolution of the textures used for both the albedo (color) map and the<br/>
        /// normal map. The resolution is specified in pixels, and a higher value corresponds to a<br/>
        /// higher level of detail in the textures, allowing for more intricate and precise rendering<br/>
        /// of surfaces. However, increasing the resolution also results in larger asset sizes, which<br/>
        /// may impact loading times and performance. `1024` is a good default value and rarely requires<br/>
        /// changing.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestTextureResolutionJsonConverter))]
        public global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? TextureResolution { get; set; }

        /// <summary>
        /// Controls the amount of padding around the object to be processed within the frame. This<br/>
        /// ratio determines the relative size of the object compared to the total frame size. A<br/>
        /// higher ratio means less padding and a larger object, while a lower ratio increases the<br/>
        /// padding, effectively reducing the object’s size within the frame. This can be useful when<br/>
        /// a long and narrow object, such as a car or bus, is viewed from the front (the narrow<br/>
        /// side). Here, lowering the foreground ratio might help prevent the generated 3D assets from<br/>
        /// appearing squished or distorted. The default value of `1.3` is good for most objects.<br/>
        /// Default Value: 1.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground_ratio")]
        public double? ForegroundRatio { get; set; }

        /// <summary>
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing algorithm<br/>
        /// determines how the 3D model is constructed from the input image. The default value of<br/>
        /// "none" means that the model is generated without remeshing, which is suitable for most use<br/>
        /// cases. The "triangle" option generates a model with triangular faces, while the "quad"<br/>
        /// option generates a model with quadrilateral faces. The "quad" option is useful when the 3D<br/>
        /// model will be used in DCC tools such as Maya or Blender.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remesh")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestRemeshJsonConverter))]
        public global::StabilityAI.Create3dStablePointAware3dRequestRemesh? Remesh { get; set; }

        /// <summary>
        /// If set to `vertex` or `face`, the result will have approximately `target_count` many vertices or<br/>
        /// faces in the simplified mesh, respectively.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestTargetTypeJsonConverter))]
        public global::StabilityAI.Create3dStablePointAware3dRequestTargetType? TargetType { get; set; }

        /// <summary>
        /// This sets the target vertex or face count defined by `target_type`. Selecting extremely low<br/>
        /// counts reduces the quality of the mesh severely and values of 1,000 - 10,000 are recommended.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_count")]
        public double? TargetCount { get; set; }

        /// <summary>
        /// This sets the guidance scaling of the point diffusion module. Lower values produce less<br/>
        /// detail and higher can introduce artifacts. The default of `3` produces best results.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3dStablePointAware3dRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image to generate a 3D model from.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 4,194,304 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image to generate a 3D model from.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 4,194,304 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="textureResolution">
        /// Determines the resolution of the textures used for both the albedo (color) map and the<br/>
        /// normal map. The resolution is specified in pixels, and a higher value corresponds to a<br/>
        /// higher level of detail in the textures, allowing for more intricate and precise rendering<br/>
        /// of surfaces. However, increasing the resolution also results in larger asset sizes, which<br/>
        /// may impact loading times and performance. `1024` is a good default value and rarely requires<br/>
        /// changing.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="foregroundRatio">
        /// Controls the amount of padding around the object to be processed within the frame. This<br/>
        /// ratio determines the relative size of the object compared to the total frame size. A<br/>
        /// higher ratio means less padding and a larger object, while a lower ratio increases the<br/>
        /// padding, effectively reducing the object’s size within the frame. This can be useful when<br/>
        /// a long and narrow object, such as a car or bus, is viewed from the front (the narrow<br/>
        /// side). Here, lowering the foreground ratio might help prevent the generated 3D assets from<br/>
        /// appearing squished or distorted. The default value of `1.3` is good for most objects.<br/>
        /// Default Value: 1.3F
        /// </param>
        /// <param name="remesh">
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing algorithm<br/>
        /// determines how the 3D model is constructed from the input image. The default value of<br/>
        /// "none" means that the model is generated without remeshing, which is suitable for most use<br/>
        /// cases. The "triangle" option generates a model with triangular faces, while the "quad"<br/>
        /// option generates a model with quadrilateral faces. The "quad" option is useful when the 3D<br/>
        /// model will be used in DCC tools such as Maya or Blender.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetType">
        /// If set to `vertex` or `face`, the result will have approximately `target_count` many vertices or<br/>
        /// faces in the simplified mesh, respectively.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetCount">
        /// This sets the target vertex or face count defined by `target_type`. Selecting extremely low<br/>
        /// counts reduces the quality of the mesh severely and values of 1,000 - 10,000 are recommended.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="guidanceScale">
        /// This sets the guidance scaling of the point diffusion module. Lower values produce less<br/>
        /// detail and higher can introduce artifacts. The default of `3` produces best results.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Create3dStablePointAware3dRequest(
            byte[] image,
            string imagename,
            global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? textureResolution,
            double? foregroundRatio,
            global::StabilityAI.Create3dStablePointAware3dRequestRemesh? remesh,
            global::StabilityAI.Create3dStablePointAware3dRequestTargetType? targetType,
            double? targetCount,
            double? guidanceScale,
            double? seed)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.TextureResolution = textureResolution;
            this.ForegroundRatio = foregroundRatio;
            this.Remesh = remesh;
            this.TargetType = targetType;
            this.TargetCount = targetCount;
            this.GuidanceScale = guidanceScale;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3dStablePointAware3dRequest" /> class.
        /// </summary>
        public Create3dStablePointAware3dRequest()
        {
        }

    }
}