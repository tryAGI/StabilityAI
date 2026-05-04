
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Create3dStableFast3dRequest
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
        /// Determines the resolution of the textures used for both the albedo (color) map<br/>
        /// and the normal map. The resolution is specified in pixels, and a higher value<br/>
        /// corresponds to a higher level of detail in the textures, allowing for more<br/>
        /// intricate and precise rendering of surfaces. However, increasing the resolution<br/>
        /// also results in larger asset sizes, which may impact loading times and<br/>
        /// performance. 1024 is a good default value and rarely requires changing.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.Create3dStableFast3dRequestTextureResolutionJsonConverter))]
        public global::StabilityAI.Create3dStableFast3dRequestTextureResolution? TextureResolution { get; set; }

        /// <summary>
        /// Controls the amount of padding around the object to be processed within the frame.<br/>
        /// This ratio determines the relative size of the object compared to the total frame<br/>
        /// size. A higher ratio means less padding and a larger object, while a lower ratio<br/>
        /// increases the padding, effectively reducing the object’s size within the frame. This<br/>
        /// can be useful when a long and narrow object, such as a car or bus, is viewed from the<br/>
        /// front (the narrow side). Here, lowering the foreground ratio might help prevent the<br/>
        /// generated 3D assets from appearing squished or distorted. The default value of 0.85<br/>
        /// is good for most objects.<br/>
        /// Default Value: 0.85F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground_ratio")]
        public double? ForegroundRatio { get; set; }

        /// <summary>
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing<br/>
        /// algorithm determines how the 3D model is constructed from the input image. The<br/>
        /// default value of "none" means that the model is generated without remeshing,<br/>
        /// which is suitable for most use cases. The "triangle" option generates a model<br/>
        /// with triangular faces, while the "quad" option generates a model with quadrilateral<br/>
        /// faces. The "quad" option is useful when the 3D model will be used in DCC tools such<br/>
        /// as Maya or Blender.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remesh")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.Create3dStableFast3dRequestRemeshJsonConverter))]
        public global::StabilityAI.Create3dStableFast3dRequestRemesh? Remesh { get; set; }

        /// <summary>
        /// If specified, the result will have approximately this many vertices (and consequently fewer faces) in the simplified mesh.<br/>
        /// Setting this value to -1 (the default value) means that a limit is not set.<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_count")]
        public double? VertexCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3dStableFast3dRequest" /> class.
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
        /// Determines the resolution of the textures used for both the albedo (color) map<br/>
        /// and the normal map. The resolution is specified in pixels, and a higher value<br/>
        /// corresponds to a higher level of detail in the textures, allowing for more<br/>
        /// intricate and precise rendering of surfaces. However, increasing the resolution<br/>
        /// also results in larger asset sizes, which may impact loading times and<br/>
        /// performance. 1024 is a good default value and rarely requires changing.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="foregroundRatio">
        /// Controls the amount of padding around the object to be processed within the frame.<br/>
        /// This ratio determines the relative size of the object compared to the total frame<br/>
        /// size. A higher ratio means less padding and a larger object, while a lower ratio<br/>
        /// increases the padding, effectively reducing the object’s size within the frame. This<br/>
        /// can be useful when a long and narrow object, such as a car or bus, is viewed from the<br/>
        /// front (the narrow side). Here, lowering the foreground ratio might help prevent the<br/>
        /// generated 3D assets from appearing squished or distorted. The default value of 0.85<br/>
        /// is good for most objects.<br/>
        /// Default Value: 0.85F
        /// </param>
        /// <param name="remesh">
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing<br/>
        /// algorithm determines how the 3D model is constructed from the input image. The<br/>
        /// default value of "none" means that the model is generated without remeshing,<br/>
        /// which is suitable for most use cases. The "triangle" option generates a model<br/>
        /// with triangular faces, while the "quad" option generates a model with quadrilateral<br/>
        /// faces. The "quad" option is useful when the 3D model will be used in DCC tools such<br/>
        /// as Maya or Blender.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="vertexCount">
        /// If specified, the result will have approximately this many vertices (and consequently fewer faces) in the simplified mesh.<br/>
        /// Setting this value to -1 (the default value) means that a limit is not set.<br/>
        /// Default Value: -1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Create3dStableFast3dRequest(
            byte[] image,
            string imagename,
            global::StabilityAI.Create3dStableFast3dRequestTextureResolution? textureResolution,
            double? foregroundRatio,
            global::StabilityAI.Create3dStableFast3dRequestRemesh? remesh,
            double? vertexCount)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.TextureResolution = textureResolution;
            this.ForegroundRatio = foregroundRatio;
            this.Remesh = remesh;
            this.VertexCount = vertexCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create3dStableFast3dRequest" /> class.
        /// </summary>
        public Create3dStableFast3dRequest()
        {
        }
    }
}