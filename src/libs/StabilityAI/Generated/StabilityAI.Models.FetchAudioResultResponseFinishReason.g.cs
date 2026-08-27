
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
    /// Example: SUCCESS
    /// </summary>
    public enum FetchAudioResultResponseFinishReason
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FetchAudioResultResponseFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FetchAudioResultResponseFinishReason value)
        {
            return value switch
            {
                FetchAudioResultResponseFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FetchAudioResultResponseFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => FetchAudioResultResponseFinishReason.Success,
                _ => null,
            };
        }
    }
}