
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStableImageEditInpaintResponse4
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
        /// Short-hand name for an error, useful for discriminating between errors with the same status code.<br/>
        /// Example: bad_request
        /// </summary>
        /// <example>bad_request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateStableImageEditInpaintResponse4" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier associated with this error. Please include this in any [support tickets](https://kb.stability.ai/knowledge-base/kb-tickets/new)<br/>
        /// you file, as it will greatly assist us in diagnosing the root cause of the problem.<br/>
        /// Example: a1b2c3d4e5f6a1b2c3d4e5f6a1b2c3d4
        /// </param>
        /// <param name="name">
        /// Short-hand name for an error, useful for discriminating between errors with the same status code.<br/>
        /// Example: bad_request
        /// </param>
        /// <param name="errors">
        /// One or more error messages indicating what went wrong.<br/>
        /// Example: [some-field: is required]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStableImageEditInpaintResponse4(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> errors)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStableImageEditInpaintResponse4" /> class.
        /// </summary>
        public CreateStableImageEditInpaintResponse4()
        {
        }

    }
}