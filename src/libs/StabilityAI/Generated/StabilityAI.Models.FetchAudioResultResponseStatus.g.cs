
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The status of your generation.
    /// </summary>
    public enum FetchAudioResultResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FetchAudioResultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FetchAudioResultResponseStatus value)
        {
            return value switch
            {
                FetchAudioResultResponseStatus.InProgress => "in-progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FetchAudioResultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "in-progress" => FetchAudioResultResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}