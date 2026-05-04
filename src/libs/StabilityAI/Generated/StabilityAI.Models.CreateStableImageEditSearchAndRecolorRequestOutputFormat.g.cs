
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageEditSearchAndRecolorRequestOutputFormat
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
    public static class CreateStableImageEditSearchAndRecolorRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditSearchAndRecolorRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageEditSearchAndRecolorRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageEditSearchAndRecolorRequestOutputFormat.Png => "png",
                CreateStableImageEditSearchAndRecolorRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditSearchAndRecolorRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageEditSearchAndRecolorRequestOutputFormat.Jpeg,
                "png" => CreateStableImageEditSearchAndRecolorRequestOutputFormat.Png,
                "webp" => CreateStableImageEditSearchAndRecolorRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}