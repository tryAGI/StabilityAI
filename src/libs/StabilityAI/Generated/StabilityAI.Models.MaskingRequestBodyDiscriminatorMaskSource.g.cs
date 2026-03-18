
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MaskingRequestBodyDiscriminatorMaskSource
    {
        /// <summary>
        /// 
        /// </summary>
        MaskImageBlack,
        /// <summary>
        /// 
        /// </summary>
        MaskImageWhite,
        /// <summary>
        /// 
        /// </summary>
        InitImageAlpha,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MaskingRequestBodyDiscriminatorMaskSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaskingRequestBodyDiscriminatorMaskSource value)
        {
            return value switch
            {
                MaskingRequestBodyDiscriminatorMaskSource.MaskImageBlack => "MASK_IMAGE_BLACK",
                MaskingRequestBodyDiscriminatorMaskSource.MaskImageWhite => "MASK_IMAGE_WHITE",
                MaskingRequestBodyDiscriminatorMaskSource.InitImageAlpha => "INIT_IMAGE_ALPHA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaskingRequestBodyDiscriminatorMaskSource? ToEnum(string value)
        {
            return value switch
            {
                "MASK_IMAGE_BLACK" => MaskingRequestBodyDiscriminatorMaskSource.MaskImageBlack,
                "MASK_IMAGE_WHITE" => MaskingRequestBodyDiscriminatorMaskSource.MaskImageWhite,
                "INIT_IMAGE_ALPHA" => MaskingRequestBodyDiscriminatorMaskSource.InitImageAlpha,
                _ => null,
            };
        }
    }
}