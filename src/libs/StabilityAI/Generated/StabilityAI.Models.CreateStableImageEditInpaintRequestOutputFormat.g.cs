
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageEditInpaintRequestOutputFormat
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
    public static class CreateStableImageEditInpaintRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditInpaintRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageEditInpaintRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageEditInpaintRequestOutputFormat.Png => "png",
                CreateStableImageEditInpaintRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditInpaintRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageEditInpaintRequestOutputFormat.Jpeg,
                "png" => CreateStableImageEditInpaintRequestOutputFormat.Png,
                "webp" => CreateStableImageEditInpaintRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}