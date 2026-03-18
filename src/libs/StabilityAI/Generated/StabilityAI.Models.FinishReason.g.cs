
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The result of the generation process.<br/>
    /// - `SUCCESS` indicates success<br/>
    /// - `ERROR` indicates an error<br/>
    /// - `CONTENT_FILTERED` indicates the result affected by the content filter and may be blurred.<br/>
    /// This header is only present when the `Accept` is set to `image/png`.  Otherwise it is returned in the response body.
    /// </summary>
    public enum FinishReason
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
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value switch
            {
                FinishReason.Success => "SUCCESS",
                FinishReason.Error => "ERROR",
                FinishReason.ContentFiltered => "CONTENT_FILTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => FinishReason.Success,
                "ERROR" => FinishReason.Error,
                "CONTENT_FILTERED" => FinishReason.ContentFiltered,
                _ => null,
            };
        }
    }
}