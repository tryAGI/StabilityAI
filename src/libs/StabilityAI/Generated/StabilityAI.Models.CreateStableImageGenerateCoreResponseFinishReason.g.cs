
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
    public enum CreateStableImageGenerateCoreResponseFinishReason
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
    public static class CreateStableImageGenerateCoreResponseFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateCoreResponseFinishReason value)
        {
            return value switch
            {
                CreateStableImageGenerateCoreResponseFinishReason.ContentFiltered => "CONTENT_FILTERED",
                CreateStableImageGenerateCoreResponseFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateCoreResponseFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateStableImageGenerateCoreResponseFinishReason.ContentFiltered,
                "SUCCESS" => CreateStableImageGenerateCoreResponseFinishReason.Success,
                _ => null,
            };
        }
    }
}