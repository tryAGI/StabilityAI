
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageUpscaleConservativeRequestOutputFormat
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
    public static class CreateStableImageUpscaleConservativeRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageUpscaleConservativeRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageUpscaleConservativeRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageUpscaleConservativeRequestOutputFormat.Png => "png",
                CreateStableImageUpscaleConservativeRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageUpscaleConservativeRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageUpscaleConservativeRequestOutputFormat.Jpeg,
                "png" => CreateStableImageUpscaleConservativeRequestOutputFormat.Png,
                "webp" => CreateStableImageUpscaleConservativeRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}