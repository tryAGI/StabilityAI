
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageControlSketchRequestOutputFormat
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
    public static class CreateStableImageControlSketchRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlSketchRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageControlSketchRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageControlSketchRequestOutputFormat.Png => "png",
                CreateStableImageControlSketchRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlSketchRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageControlSketchRequestOutputFormat.Jpeg,
                "png" => CreateStableImageControlSketchRequestOutputFormat.Png,
                "webp" => CreateStableImageControlSketchRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}