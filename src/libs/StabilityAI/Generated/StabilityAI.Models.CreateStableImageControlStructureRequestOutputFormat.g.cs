
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageControlStructureRequestOutputFormat
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
    public static class CreateStableImageControlStructureRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStructureRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageControlStructureRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageControlStructureRequestOutputFormat.Png => "png",
                CreateStableImageControlStructureRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStructureRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageControlStructureRequestOutputFormat.Jpeg,
                "png" => CreateStableImageControlStructureRequestOutputFormat.Png,
                "webp" => CreateStableImageControlStructureRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}