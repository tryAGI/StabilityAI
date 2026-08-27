
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The reason the generation finished.<br/>
    /// - `SUCCESS` = successful generation.<br/>
    /// - `CONTENT_FILTERED` = successful generation, however the output violated our content moderation<br/>
    /// policy and has been blurred as a result.<br/>
    /// Example: SUCCESS
    /// </summary>
    public enum CreateStableImageEditSearchAndReplaceResponseFinishReason2
    {
        /// <summary>
        ///
        /// </summary>
        ContentFiltered,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageEditSearchAndReplaceResponseFinishReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditSearchAndReplaceResponseFinishReason2 value)
        {
            return value switch
            {
                CreateStableImageEditSearchAndReplaceResponseFinishReason2.ContentFiltered => "CONTENT_FILTERED",
                CreateStableImageEditSearchAndReplaceResponseFinishReason2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditSearchAndReplaceResponseFinishReason2? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateStableImageEditSearchAndReplaceResponseFinishReason2.ContentFiltered,
                "SUCCESS" => CreateStableImageEditSearchAndReplaceResponseFinishReason2.Success,
                _ => null,
            };
        }
    }
}