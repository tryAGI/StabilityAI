
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageJSONResponse
    {
        /// <summary>
        /// The generated image, encoded to base64.<br/>
        /// Example: AAAAIGZ0eXBpc29tAAACAGlzb21pc28yYXZjMW1...
        /// </summary>
        /// <example>AAAAIGZ0eXBpc29tAAACAGlzb21pc28yYXZjMW1...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>))]
        public global::StabilityAI.AllOf<double?, object>? Seed { get; set; }

        /// <summary>
        /// The reason the generation finished.<br/>
        /// - `SUCCESS` = successful generation.<br/>
        /// - `CONTENT_FILTERED` = successful generation, however the output violated our content moderation<br/>
        /// policy and has been blurred as a result.<br/>
        /// Example: SUCCESS
        /// </summary>
        /// <example>SUCCESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.ImageJSONResponseFinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::StabilityAI.ImageJSONResponseFinishReason FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageJSONResponse" /> class.
        /// </summary>
        /// <param name="image">
        /// The generated image, encoded to base64.<br/>
        /// Example: AAAAIGZ0eXBpc29tAAACAGlzb21pc28yYXZjMW1...
        /// </param>
        /// <param name="finishReason">
        /// The reason the generation finished.<br/>
        /// - `SUCCESS` = successful generation.<br/>
        /// - `CONTENT_FILTERED` = successful generation, however the output violated our content moderation<br/>
        /// policy and has been blurred as a result.<br/>
        /// Example: SUCCESS
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageJSONResponse(
            string image,
            global::StabilityAI.ImageJSONResponseFinishReason finishReason,
            global::StabilityAI.AllOf<double?, object>? seed)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Seed = seed;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageJSONResponse" /> class.
        /// </summary>
        public ImageJSONResponse()
        {
        }

    }
}