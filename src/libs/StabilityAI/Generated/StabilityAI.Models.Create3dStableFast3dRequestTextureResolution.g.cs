
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Determines the resolution of the textures used for both the albedo (color) map<br/>
    /// and the normal map. The resolution is specified in pixels, and a higher value<br/>
    /// corresponds to a higher level of detail in the textures, allowing for more<br/>
    /// intricate and precise rendering of surfaces. However, increasing the resolution<br/>
    /// also results in larger asset sizes, which may impact loading times and<br/>
    /// performance. 1024 is a good default value and rarely requires changing.<br/>
    /// Default Value: 1024
    /// </summary>
    public enum Create3dStableFast3dRequestTextureResolution
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
    public static class Create3dStableFast3dRequestTextureResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3dStableFast3dRequestTextureResolution value)
        {
            return value switch
            {
                Create3dStableFast3dRequestTextureResolution.x1024 => "1024",
                Create3dStableFast3dRequestTextureResolution.x2048 => "2048",
                Create3dStableFast3dRequestTextureResolution.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3dStableFast3dRequestTextureResolution? ToEnum(string value)
        {
            return value switch
            {
                "1024" => Create3dStableFast3dRequestTextureResolution.x1024,
                "2048" => Create3dStableFast3dRequestTextureResolution.x2048,
                "512" => Create3dStableFast3dRequestTextureResolution.x512,
                _ => null,
            };
        }
    }
}