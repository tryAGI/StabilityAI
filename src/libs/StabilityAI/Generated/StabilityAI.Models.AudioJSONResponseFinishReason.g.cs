
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
    /// Example: SUCCESS
    /// </summary>
    public enum AudioJSONResponseFinishReason
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioJSONResponseFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioJSONResponseFinishReason value)
        {
            return value switch
            {
                AudioJSONResponseFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioJSONResponseFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => AudioJSONResponseFinishReason.Success,
                _ => null,
            };
        }
    }
}