
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageGenerateUltraRequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageGenerateUltraRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateUltraRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageGenerateUltraRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageGenerateUltraRequestOutputFormat.Png => "png",
                CreateStableImageGenerateUltraRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateUltraRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageGenerateUltraRequestOutputFormat.Jpeg,
                "png" => CreateStableImageGenerateUltraRequestOutputFormat.Png,
                "webp" => CreateStableImageGenerateUltraRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}