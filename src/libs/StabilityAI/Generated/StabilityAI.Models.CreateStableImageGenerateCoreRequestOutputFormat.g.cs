
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageGenerateCoreRequestOutputFormat
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
    public static class CreateStableImageGenerateCoreRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateCoreRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageGenerateCoreRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageGenerateCoreRequestOutputFormat.Png => "png",
                CreateStableImageGenerateCoreRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateCoreRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageGenerateCoreRequestOutputFormat.Jpeg,
                "png" => CreateStableImageGenerateCoreRequestOutputFormat.Png,
                "webp" => CreateStableImageGenerateCoreRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}