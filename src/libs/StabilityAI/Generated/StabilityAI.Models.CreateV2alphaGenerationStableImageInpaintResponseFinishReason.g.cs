
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
    public enum CreateV2alphaGenerationStableImageInpaintResponseFinishReason
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
    public static class CreateV2alphaGenerationStableImageInpaintResponseFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateV2alphaGenerationStableImageInpaintResponseFinishReason value)
        {
            return value switch
            {
                CreateV2alphaGenerationStableImageInpaintResponseFinishReason.ContentFiltered => "CONTENT_FILTERED",
                CreateV2alphaGenerationStableImageInpaintResponseFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateV2alphaGenerationStableImageInpaintResponseFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateV2alphaGenerationStableImageInpaintResponseFinishReason.ContentFiltered,
                "SUCCESS" => CreateV2alphaGenerationStableImageInpaintResponseFinishReason.Success,
                _ => null,
            };
        }
    }
}