
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageGenerateSd3RequestOutputFormat
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
    public static class CreateStableImageGenerateSd3RequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateSd3RequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageGenerateSd3RequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageGenerateSd3RequestOutputFormat.Png => "png",
                CreateStableImageGenerateSd3RequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateSd3RequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageGenerateSd3RequestOutputFormat.Jpeg,
                "png" => CreateStableImageGenerateSd3RequestOutputFormat.Png,
                "webp" => CreateStableImageGenerateSd3RequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}