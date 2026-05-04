
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
    public enum GetStableImageUpscaleCreativeResultResponseFinishReason
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
    public static class GetStableImageUpscaleCreativeResultResponseFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStableImageUpscaleCreativeResultResponseFinishReason value)
        {
            return value switch
            {
                GetStableImageUpscaleCreativeResultResponseFinishReason.ContentFiltered => "CONTENT_FILTERED",
                GetStableImageUpscaleCreativeResultResponseFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStableImageUpscaleCreativeResultResponseFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => GetStableImageUpscaleCreativeResultResponseFinishReason.ContentFiltered,
                "SUCCESS" => GetStableImageUpscaleCreativeResultResponseFinishReason.Success,
                _ => null,
            };
        }
    }
}