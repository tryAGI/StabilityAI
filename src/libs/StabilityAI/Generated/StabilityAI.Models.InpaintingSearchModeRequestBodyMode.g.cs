
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
    public enum InpaintingSearchModeRequestBodyMode
    {
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InpaintingSearchModeRequestBodyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintingSearchModeRequestBodyMode value)
        {
            return value switch
            {
                InpaintingSearchModeRequestBodyMode.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintingSearchModeRequestBodyMode? ToEnum(string value)
        {
            return value switch
            {
                "search" => InpaintingSearchModeRequestBodyMode.Search,
                _ => null,
            };
        }
    }
}