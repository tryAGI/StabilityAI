
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// If set to `vertex` or `face`, the result will have approximately `target_count` many vertices or<br/>
    /// faces in the simplified mesh, respectively.<br/>
    /// Default Value: none
    /// </summary>
    public enum Create3dStablePointAware3dRequestTargetType
    {
        /// <summary>
        /// 
        /// </summary>
        Face,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Vertex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3dStablePointAware3dRequestTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3dStablePointAware3dRequestTargetType value)
        {
            return value switch
            {
                Create3dStablePointAware3dRequestTargetType.Face => "face",
                Create3dStablePointAware3dRequestTargetType.None => "none",
                Create3dStablePointAware3dRequestTargetType.Vertex => "vertex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3dStablePointAware3dRequestTargetType? ToEnum(string value)
        {
            return value switch
            {
                "face" => Create3dStablePointAware3dRequestTargetType.Face,
                "none" => Create3dStablePointAware3dRequestTargetType.None,
                "vertex" => Create3dStablePointAware3dRequestTargetType.Vertex,
                _ => null,
            };
        }
    }
}