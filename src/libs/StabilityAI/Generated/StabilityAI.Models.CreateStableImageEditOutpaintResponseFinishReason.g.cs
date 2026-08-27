
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
    public enum CreateStableImageEditOutpaintResponseFinishReason
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
    public static class CreateStableImageEditOutpaintResponseFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditOutpaintResponseFinishReason value)
        {
            return value switch
            {
                CreateStableImageEditOutpaintResponseFinishReason.ContentFiltered => "CONTENT_FILTERED",
                CreateStableImageEditOutpaintResponseFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditOutpaintResponseFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateStableImageEditOutpaintResponseFinishReason.ContentFiltered,
                "SUCCESS" => CreateStableImageEditOutpaintResponseFinishReason.Success,
                _ => null,
            };
        }
    }
}