
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageUpscaleCreativeRequestOutputFormat
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
    public static class CreateStableImageUpscaleCreativeRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageUpscaleCreativeRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageUpscaleCreativeRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageUpscaleCreativeRequestOutputFormat.Png => "png",
                CreateStableImageUpscaleCreativeRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageUpscaleCreativeRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageUpscaleCreativeRequestOutputFormat.Jpeg,
                "png" => CreateStableImageUpscaleCreativeRequestOutputFormat.Png,
                "webp" => CreateStableImageUpscaleCreativeRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}