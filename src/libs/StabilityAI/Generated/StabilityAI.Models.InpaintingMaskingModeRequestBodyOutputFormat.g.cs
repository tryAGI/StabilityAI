
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum InpaintingMaskingModeRequestBodyOutputFormat
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
    public static class InpaintingMaskingModeRequestBodyOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintingMaskingModeRequestBodyOutputFormat value)
        {
            return value switch
            {
                InpaintingMaskingModeRequestBodyOutputFormat.Jpeg => "jpeg",
                InpaintingMaskingModeRequestBodyOutputFormat.Png => "png",
                InpaintingMaskingModeRequestBodyOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintingMaskingModeRequestBodyOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => InpaintingMaskingModeRequestBodyOutputFormat.Jpeg,
                "png" => InpaintingMaskingModeRequestBodyOutputFormat.Png,
                "webp" => InpaintingMaskingModeRequestBodyOutputFormat.Webp,
                _ => null,
            };
        }
    }
}