
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Determines the resolution of the textures used for both the albedo (color) map and the<br/>
    /// normal map. The resolution is specified in pixels, and a higher value corresponds to a<br/>
    /// higher level of detail in the textures, allowing for more intricate and precise rendering<br/>
    /// of surfaces. However, increasing the resolution also results in larger asset sizes, which<br/>
    /// may impact loading times and performance. `1024` is a good default value and rarely requires<br/>
    /// changing.<br/>
    /// Default Value: 1024
    /// </summary>
    public enum Create3dStablePointAware3dRequestTextureResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1024,
        /// <summary>
        /// 
        /// </summary>
        x2048,
        /// <summary>
        /// 
        /// </summary>
        x512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3dStablePointAware3dRequestTextureResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3dStablePointAware3dRequestTextureResolution value)
        {
            return value switch
            {
                Create3dStablePointAware3dRequestTextureResolution.x1024 => "1024",
                Create3dStablePointAware3dRequestTextureResolution.x2048 => "2048",
                Create3dStablePointAware3dRequestTextureResolution.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3dStablePointAware3dRequestTextureResolution? ToEnum(string value)
        {
            return value switch
            {
                "1024" => Create3dStablePointAware3dRequestTextureResolution.x1024,
                "2048" => Create3dStablePointAware3dRequestTextureResolution.x2048,
                "512" => Create3dStablePointAware3dRequestTextureResolution.x512,
                _ => null,
            };
        }
    }
}