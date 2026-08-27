
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageEditOutpaintRequestOutputFormat
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
    public static class CreateStableImageEditOutpaintRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditOutpaintRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageEditOutpaintRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageEditOutpaintRequestOutputFormat.Png => "png",
                CreateStableImageEditOutpaintRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditOutpaintRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageEditOutpaintRequestOutputFormat.Jpeg,
                "png" => CreateStableImageEditOutpaintRequestOutputFormat.Png,
                "webp" => CreateStableImageEditOutpaintRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}