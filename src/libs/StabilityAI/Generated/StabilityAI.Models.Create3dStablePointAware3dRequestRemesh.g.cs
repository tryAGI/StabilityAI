
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls the remeshing algorithm used to generate the 3D model. The remeshing algorithm<br/>
    /// determines how the 3D model is constructed from the input image. The default value of<br/>
    /// "none" means that the model is generated without remeshing, which is suitable for most use<br/>
    /// cases. The "triangle" option generates a model with triangular faces, while the "quad"<br/>
    /// option generates a model with quadrilateral faces. The "quad" option is useful when the 3D<br/>
    /// model will be used in DCC tools such as Maya or Blender.<br/>
    /// Default Value: none
    /// </summary>
    public enum Create3dStablePointAware3dRequestRemesh
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Quad,
        /// <summary>
        /// 
        /// </summary>
        Triangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3dStablePointAware3dRequestRemeshExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3dStablePointAware3dRequestRemesh value)
        {
            return value switch
            {
                Create3dStablePointAware3dRequestRemesh.None => "none",
                Create3dStablePointAware3dRequestRemesh.Quad => "quad",
                Create3dStablePointAware3dRequestRemesh.Triangle => "triangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3dStablePointAware3dRequestRemesh? ToEnum(string value)
        {
            return value switch
            {
                "none" => Create3dStablePointAware3dRequestRemesh.None,
                "quad" => Create3dStablePointAware3dRequestRemesh.Quad,
                "triangle" => Create3dStablePointAware3dRequestRemesh.Triangle,
                _ => null,
            };
        }
    }
}