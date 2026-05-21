
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Your request was flagged by our content moderation system.<br/>
    /// Example: {"id":"ed14db44362126aab3cbd25cca51ffe3","name":"content_moderation","errors":["Your request was flagged by our content moderation system, as a result your request was denied and you were not charged."]}
    /// </summary>
    public sealed partial class ContentModerationResponse
    {
        /// <summary>
        /// A unique identifier associated with this error. Please include this in any [support tickets](https://kb.stability.ai/knowledge-base/kb-tickets/new)<br/>
        /// you file, as it will greatly assist us in diagnosing the root cause of the problem.<br/>
        /// Example: a1b2c3d4e5f6a1b2c3d4e5f6a1b2c3d4
        /// </summary>
        /// <example>a1b2c3d4e5f6a1b2c3d4e5f6a1b2c3d4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Our content moderation system has flagged some part of your request and subsequently denied it.  You were not charged for this request.  While this may at times be frustrating, it is necessary to maintain the integrity of our platform and ensure a safe experience for all users.<br/>
        /// If you would like to provide feedback, please use the [Support Form](https://kb.stability.ai/knowledge-base/kb-tickets/new).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StabilityAI.JsonConverters.ContentModerationResponseNameJsonConverter))]
        public global::StabilityAI.ContentModerationResponseName Name { get; set; }

        /// <summary>
        /// One or more error messages indicating what went wrong.<br/>
        /// Example: [some-field: is required]
        /// </summary>
        /// <example>[some-field: is required]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentModerationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier associated with this error. Please include this in any [support tickets](https://kb.stability.ai/knowledge-base/kb-tickets/new)<br/>
        /// you file, as it will greatly assist us in diagnosing the root cause of the problem.<br/>
        /// Example: a1b2c3d4e5f6a1b2c3d4e5f6a1b2c3d4
        /// </param>
        /// <param name="errors">
        /// One or more error messages indicating what went wrong.<br/>
        /// Example: [some-field: is required]
        /// </param>
        /// <param name="name">
        /// Our content moderation system has flagged some part of your request and subsequently denied it.  You were not charged for this request.  While this may at times be frustrating, it is necessary to maintain the integrity of our platform and ensure a safe experience for all users.<br/>
        /// If you would like to provide feedback, please use the [Support Form](https://kb.stability.ai/knowledge-base/kb-tickets/new).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentModerationResponse(
            string id,
            global::System.Collections.Generic.IList<string> errors,
            global::StabilityAI.ContentModerationResponseName name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentModerationResponse" /> class.
        /// </summary>
        public ContentModerationResponse()
        {
        }

    }
}