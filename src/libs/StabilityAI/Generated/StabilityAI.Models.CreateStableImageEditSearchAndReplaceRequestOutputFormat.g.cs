
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageEditSearchAndReplaceRequestOutputFormat
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
    public static class CreateStableImageEditSearchAndReplaceRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditSearchAndReplaceRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageEditSearchAndReplaceRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageEditSearchAndReplaceRequestOutputFormat.Png => "png",
                CreateStableImageEditSearchAndReplaceRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditSearchAndReplaceRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageEditSearchAndReplaceRequestOutputFormat.Jpeg,
                "png" => CreateStableImageEditSearchAndReplaceRequestOutputFormat.Png,
                "webp" => CreateStableImageEditSearchAndReplaceRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}