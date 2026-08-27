
#nullable enable

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode
    {
        /// <summary>
        ///
        /// </summary>
        Mask,
        /// <summary>
        ///
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode value)
        {
            return value switch
            {
                CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode.Mask => "mask",
                CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "mask" => CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode.Mask,
                "search" => CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode.Search,
                _ => null,
            };
        }
    }
}