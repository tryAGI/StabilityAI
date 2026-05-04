
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls the remeshing algorithm used to generate the 3D model. The remeshing<br/>
    /// algorithm determines how the 3D model is constructed from the input image. The<br/>
    /// default value of "none" means that the model is generated without remeshing,<br/>
    /// which is suitable for most use cases. The "triangle" option generates a model<br/>
    /// with triangular faces, while the "quad" option generates a model with quadrilateral<br/>
    /// faces. The "quad" option is useful when the 3D model will be used in DCC tools such<br/>
    /// as Maya or Blender.<br/>
    /// Default Value: none
    /// </summary>
    public enum Create3dStableFast3dRequestRemesh
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
    public static class Create3dStableFast3dRequestRemeshExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3dStableFast3dRequestRemesh value)
        {
            return value switch
            {
                Create3dStableFast3dRequestRemesh.None => "none",
                Create3dStableFast3dRequestRemesh.Quad => "quad",
                Create3dStableFast3dRequestRemesh.Triangle => "triangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3dStableFast3dRequestRemesh? ToEnum(string value)
        {
            return value switch
            {
                "none" => Create3dStableFast3dRequestRemesh.None,
                "quad" => Create3dStableFast3dRequestRemesh.Quad,
                "triangle" => Create3dStableFast3dRequestRemesh.Triangle,
                _ => null,
            };
        }
    }
}