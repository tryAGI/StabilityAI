
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
    public enum CreateStableImageEditEraseResponseFinishReason2
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
    public static class CreateStableImageEditEraseResponseFinishReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditEraseResponseFinishReason2 value)
        {
            return value switch
            {
                CreateStableImageEditEraseResponseFinishReason2.ContentFiltered => "CONTENT_FILTERED",
                CreateStableImageEditEraseResponseFinishReason2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditEraseResponseFinishReason2? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateStableImageEditEraseResponseFinishReason2.ContentFiltered,
                "SUCCESS" => CreateStableImageEditEraseResponseFinishReason2.Success,
                _ => null,
            };
        }
    }
}