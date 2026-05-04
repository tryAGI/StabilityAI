
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls how the model decides which areas to inpaint and which areas to leave alone.<br/>
    /// Specifying `mask` requires:<br/>
    ///   - Provide an explicit mask image in the `mask` parameter<br/>
    ///   - Use the alpha channel of the `image` parameter as the mask<br/>
    /// Specifying `search` requires:<br/>
    ///   - Provide a small description of what to inpaint in the `search_prompt` parameter
    /// </summary>
    public enum InpaintingMaskingModeRequestBodyMode
    {
        /// <summary>
        /// 
        /// </summary>
        Mask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InpaintingMaskingModeRequestBodyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintingMaskingModeRequestBodyMode value)
        {
            return value switch
            {
                InpaintingMaskingModeRequestBodyMode.Mask => "mask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintingMaskingModeRequestBodyMode? ToEnum(string value)
        {
            return value switch
            {
                "mask" => InpaintingMaskingModeRequestBodyMode.Mask,
                _ => null,
            };
        }
    }
}