
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum InpaintingSearchModeRequestBodyOutputFormat
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
    public static class InpaintingSearchModeRequestBodyOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintingSearchModeRequestBodyOutputFormat value)
        {
            return value switch
            {
                InpaintingSearchModeRequestBodyOutputFormat.Jpeg => "jpeg",
                InpaintingSearchModeRequestBodyOutputFormat.Png => "png",
                InpaintingSearchModeRequestBodyOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintingSearchModeRequestBodyOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => InpaintingSearchModeRequestBodyOutputFormat.Jpeg,
                "png" => InpaintingSearchModeRequestBodyOutputFormat.Png,
                "webp" => InpaintingSearchModeRequestBodyOutputFormat.Webp,
                _ => null,
            };
        }
    }
}