
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The status of your generation.
    /// </summary>
    public enum GetResultsResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResultsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResultsResponseStatus value)
        {
            return value switch
            {
                GetResultsResponseStatus.InProgress => "in-progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResultsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "in-progress" => GetResultsResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}