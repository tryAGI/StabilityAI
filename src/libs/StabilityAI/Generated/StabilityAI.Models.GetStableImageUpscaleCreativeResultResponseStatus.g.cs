
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The status of your generation.
    /// </summary>
    public enum GetStableImageUpscaleCreativeResultResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStableImageUpscaleCreativeResultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStableImageUpscaleCreativeResultResponseStatus value)
        {
            return value switch
            {
                GetStableImageUpscaleCreativeResultResponseStatus.InProgress => "in-progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStableImageUpscaleCreativeResultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "in-progress" => GetStableImageUpscaleCreativeResultResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}