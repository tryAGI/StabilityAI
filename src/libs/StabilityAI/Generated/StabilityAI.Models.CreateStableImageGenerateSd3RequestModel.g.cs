
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The model to use for generation.<br/>
    /// - `sd3.5-large` requires 6.5 credits per generation<br/>
    /// - `sd3.5-large-turbo` requires 4 credits per generation<br/>
    /// - `sd3.5-medium` requires 3.5 credits per generation<br/>
    /// - `sd3.5-flash` requires 2.5 credits per generation<br/>
    /// - As of the April 17, 2025, `sd3-large`, `sd3-large-turbo` and `sd3-medium`<br/>
    ///   are re-routed to their `sd3.5-[model version]` equivalent, at the same price.<br/>
    /// Default Value: sd3.5-large
    /// </summary>
    public enum CreateStableImageGenerateSd3RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Sd35Large,
        /// <summary>
        /// 
        /// </summary>
        Sd35LargeTurbo,
        /// <summary>
        /// 
        /// </summary>
        Sd35Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageGenerateSd3RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateSd3RequestModel value)
        {
            return value switch
            {
                CreateStableImageGenerateSd3RequestModel.Sd35Large => "sd3.5-large",
                CreateStableImageGenerateSd3RequestModel.Sd35LargeTurbo => "sd3.5-large-turbo",
                CreateStableImageGenerateSd3RequestModel.Sd35Medium => "sd3.5-medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateSd3RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "sd3.5-large" => CreateStableImageGenerateSd3RequestModel.Sd35Large,
                "sd3.5-large-turbo" => CreateStableImageGenerateSd3RequestModel.Sd35LargeTurbo,
                "sd3.5-medium" => CreateStableImageGenerateSd3RequestModel.Sd35Medium,
                _ => null,
            };
        }
    }
}