
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageControlStyleTransferResponse
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
        /// The seed used as random noise for this generation.<br/>
        /// Default Value: 0<br/>
        /// Example: 343940597
        /// </summary>
        /// <example>343940597</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// The reason the generation finished.<br/>
        /// - `SUCCESS` = successful generation.<br/>
        /// - `CONTENT_FILTERED` = successful generation, however the output violated our content moderation<br/>
        /// policy and has been blurred as a result.<br/>
        /// Example: SUCCESS
        /// </summary>
        /// <example>SUCCESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferResponseFinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageControlStyleTransferResponse" /> class.
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
        /// <param name="seed">
        /// The seed used as random noise for this generation.<br/>
        /// Default Value: 0<br/>
        /// Example: 343940597
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageControlStyleTransferResponse(
            string image,
            global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason finishReason,
            double? seed)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Seed = seed;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageControlStyleTransferResponse" /> class.
        /// </summary>
        public CreateStableImageControlStyleTransferResponse()
        {
        }

    }
}