
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FalGenerationResponse
    {
        /// <summary>
        /// An S3 object URL in the form `s3://bucket/key` pointing to the generated asset.<br/>
        /// Internal callers can fetch this object from S3 to download the bytes. `null` when<br/>
        /// the output was withheld (e.g. it failed content moderation — see the `finish-reason` header).<br/>
        /// Example: s3://stabilityapi-outputs-123456789012-us-west-2/fal/engine/output-id
        /// </summary>
        /// <example>s3://stabilityapi-outputs-123456789012-us-west-2/fal/engine/output-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3Url")]
        public string? S3Url { get; set; }

        /// <summary>
        /// The MIME type of the generated asset.<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FalGenerationResponse" /> class.
        /// </summary>
        /// <param name="contentType">
        /// The MIME type of the generated asset.<br/>
        /// Example: image/png
        /// </param>
        /// <param name="s3Url">
        /// An S3 object URL in the form `s3://bucket/key` pointing to the generated asset.<br/>
        /// Internal callers can fetch this object from S3 to download the bytes. `null` when<br/>
        /// the output was withheld (e.g. it failed content moderation — see the `finish-reason` header).<br/>
        /// Example: s3://stabilityapi-outputs-123456789012-us-west-2/fal/engine/output-id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FalGenerationResponse(
            string contentType,
            string? s3Url)
        {
            this.S3Url = s3Url;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FalGenerationResponse" /> class.
        /// </summary>
        public FalGenerationResponse()
        {
        }

    }
}