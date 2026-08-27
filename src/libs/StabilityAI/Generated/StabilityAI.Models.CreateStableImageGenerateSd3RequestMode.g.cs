
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls whether this is a text-to-image or image-to-image generation, which affects which parameters are required:<br/>
    /// - **text-to-image** requires only the `prompt` parameter<br/>
    /// - **image-to-image** requires the `prompt`, `image`, and `strength` parameters<br/>
    /// Default Value: text-to-image
    /// </summary>
    public enum CreateStableImageGenerateSd3RequestMode
    {
        /// <summary>
        ///
        /// </summary>
        ImageToImage,
        /// <summary>
        ///
        /// </summary>
        TextToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageGenerateSd3RequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateSd3RequestMode value)
        {
            return value switch
            {
                CreateStableImageGenerateSd3RequestMode.ImageToImage => "image-to-image",
                CreateStableImageGenerateSd3RequestMode.TextToImage => "text-to-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateSd3RequestMode? ToEnum(string value)
        {
            return value switch
            {
                "image-to-image" => CreateStableImageGenerateSd3RequestMode.ImageToImage,
                "text-to-image" => CreateStableImageGenerateSd3RequestMode.TextToImage,
                _ => null,
            };
        }
    }
}