
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat
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
    public static class CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat value)
        {
            return value switch
            {
                CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat.Jpeg => "jpeg",
                CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat.Png => "png",
                CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat.Jpeg,
                "png" => CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat.Png,
                "webp" => CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}