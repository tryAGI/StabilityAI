
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageEditEraseRequestOutputFormat
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
    public static class CreateStableImageEditEraseRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditEraseRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageEditEraseRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageEditEraseRequestOutputFormat.Png => "png",
                CreateStableImageEditEraseRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditEraseRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageEditEraseRequestOutputFormat.Jpeg,
                "png" => CreateStableImageEditEraseRequestOutputFormat.Png,
                "webp" => CreateStableImageEditEraseRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}