
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageEditRemoveBackgroundRequestOutputFormat
    {
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
    public static class CreateStableImageEditRemoveBackgroundRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditRemoveBackgroundRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageEditRemoveBackgroundRequestOutputFormat.Png => "png",
                CreateStableImageEditRemoveBackgroundRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditRemoveBackgroundRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => CreateStableImageEditRemoveBackgroundRequestOutputFormat.Png,
                "webp" => CreateStableImageEditRemoveBackgroundRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}