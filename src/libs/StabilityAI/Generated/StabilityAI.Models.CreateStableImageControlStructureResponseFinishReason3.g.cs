
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
    public enum CreateStableImageControlStructureResponseFinishReason3
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
    public static class CreateStableImageControlStructureResponseFinishReason3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStructureResponseFinishReason3 value)
        {
            return value switch
            {
                CreateStableImageControlStructureResponseFinishReason3.ContentFiltered => "CONTENT_FILTERED",
                CreateStableImageControlStructureResponseFinishReason3.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStructureResponseFinishReason3? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => CreateStableImageControlStructureResponseFinishReason3.ContentFiltered,
                "SUCCESS" => CreateStableImageControlStructureResponseFinishReason3.Success,
                _ => null,
            };
        }
    }
}