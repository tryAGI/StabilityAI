
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
    public enum CreateStableImageGenerateSd3ResponseFinishReason3
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
    public static class CreateStableImageGenerateSd3ResponseFinishReason3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateSd3ResponseFinishReason3 value)
        {
            return value switch
            {
                CreateStableImageGenerateSd3ResponseFinishReason3.ContentFiltered => "CONTENT_FILTERED",
                CreateStableImageGenerateSd3ResponseFinishReason3.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateSd3ResponseFinishReason3? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateStableImageGenerateSd3ResponseFinishReason3.ContentFiltered,
                "SUCCESS" => CreateStableImageGenerateSd3ResponseFinishReason3.Success,
                _ => null,
            };
        }
    }
}