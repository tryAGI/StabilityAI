
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
    public enum GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2
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
    public static class GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2 value)
        {
            return value switch
            {
                GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2.ContentFiltered => "CONTENT_FILTERED",
                GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2.ContentFiltered,
                "SUCCESS" => GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2.Success,
                _ => null,
            };
        }
    }
}