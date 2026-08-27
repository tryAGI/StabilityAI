
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat
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
    public static class CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat.Png => "png",
                CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat.Jpeg,
                "png" => CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat.Png,
                "webp" => CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}