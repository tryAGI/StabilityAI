
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Example: CONTENT_FILTERED
    /// </summary>
    public enum ImageFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ContentFiltered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageFinishReason value)
        {
            return value switch
            {
                ImageFinishReason.Success => "SUCCESS",
                ImageFinishReason.Error => "ERROR",
                ImageFinishReason.ContentFiltered => "CONTENT_FILTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => ImageFinishReason.Success,
                "ERROR" => ImageFinishReason.Error,
                "CONTENT_FILTERED" => ImageFinishReason.ContentFiltered,
                _ => null,
            };
        }
    }
}