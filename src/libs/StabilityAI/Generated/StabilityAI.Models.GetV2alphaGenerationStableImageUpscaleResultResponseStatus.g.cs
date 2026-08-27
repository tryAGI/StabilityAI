
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The status of your generation.
    /// </summary>
    public enum GetV2alphaGenerationStableImageUpscaleResultResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetV2alphaGenerationStableImageUpscaleResultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetV2alphaGenerationStableImageUpscaleResultResponseStatus value)
        {
            return value switch
            {
                GetV2alphaGenerationStableImageUpscaleResultResponseStatus.InProgress => "in-progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetV2alphaGenerationStableImageUpscaleResultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "in-progress" => GetV2alphaGenerationStableImageUpscaleResultResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}