
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateV2alphaGenerationStableImageInpaintRequestDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorModeJsonConverter))]
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateV2alphaGenerationStableImageInpaintRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateV2alphaGenerationStableImageInpaintRequestDiscriminator(
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateV2alphaGenerationStableImageInpaintRequestDiscriminator" /> class.
        /// </summary>
        public CreateV2alphaGenerationStableImageInpaintRequestDiscriminator()
        {
        }

    }
}