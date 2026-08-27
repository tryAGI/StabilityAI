
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageUpscaleFastRequestOutputFormat
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
    public static class CreateStableImageUpscaleFastRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageUpscaleFastRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageUpscaleFastRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageUpscaleFastRequestOutputFormat.Png => "png",
                CreateStableImageUpscaleFastRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageUpscaleFastRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageUpscaleFastRequestOutputFormat.Jpeg,
                "png" => CreateStableImageUpscaleFastRequestOutputFormat.Png,
                "webp" => CreateStableImageUpscaleFastRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}