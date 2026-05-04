
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageControlStyleRequestOutputFormat
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
    public static class CreateStableImageControlStyleRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStyleRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageControlStyleRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageControlStyleRequestOutputFormat.Png => "png",
                CreateStableImageControlStyleRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStyleRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageControlStyleRequestOutputFormat.Jpeg,
                "png" => CreateStableImageControlStyleRequestOutputFormat.Png,
                "webp" => CreateStableImageControlStyleRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}