
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
    public enum CreateStableImageUpscaleFastResponseFinishReason2
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
    public static class CreateStableImageUpscaleFastResponseFinishReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageUpscaleFastResponseFinishReason2 value)
        {
            return value switch
            {
                CreateStableImageUpscaleFastResponseFinishReason2.ContentFiltered => "CONTENT_FILTERED",
                CreateStableImageUpscaleFastResponseFinishReason2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageUpscaleFastResponseFinishReason2? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateStableImageUpscaleFastResponseFinishReason2.ContentFiltered,
                "SUCCESS" => CreateStableImageUpscaleFastResponseFinishReason2.Success,
                _ => null,
            };
        }
    }
}