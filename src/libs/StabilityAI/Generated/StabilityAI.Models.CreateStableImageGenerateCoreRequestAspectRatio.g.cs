
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls the aspect ratio of the generated image.<br/>
    /// Default Value: 1:1
    /// </summary>
    public enum CreateStableImageGenerateCoreRequestAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x21_9,
        /// <summary>
        ///
        /// </summary>
        x2_3,
        /// <summary>
        ///
        /// </summary>
        x3_2,
        /// <summary>
        ///
        /// </summary>
        x4_5,
        /// <summary>
        ///
        /// </summary>
        x5_4,
        /// <summary>
        ///
        /// </summary>
        x9_16,
        /// <summary>
        ///
        /// </summary>
        x9_21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageGenerateCoreRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateCoreRequestAspectRatio value)
        {
            return value switch
            {
                CreateStableImageGenerateCoreRequestAspectRatio.x16_9 => "16:9",
                CreateStableImageGenerateCoreRequestAspectRatio.x1_1 => "1:1",
                CreateStableImageGenerateCoreRequestAspectRatio.x21_9 => "21:9",
                CreateStableImageGenerateCoreRequestAspectRatio.x2_3 => "2:3",
                CreateStableImageGenerateCoreRequestAspectRatio.x3_2 => "3:2",
                CreateStableImageGenerateCoreRequestAspectRatio.x4_5 => "4:5",
                CreateStableImageGenerateCoreRequestAspectRatio.x5_4 => "5:4",
                CreateStableImageGenerateCoreRequestAspectRatio.x9_16 => "9:16",
                CreateStableImageGenerateCoreRequestAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateCoreRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateStableImageGenerateCoreRequestAspectRatio.x16_9,
                "1:1" => CreateStableImageGenerateCoreRequestAspectRatio.x1_1,
                "21:9" => CreateStableImageGenerateCoreRequestAspectRatio.x21_9,
                "2:3" => CreateStableImageGenerateCoreRequestAspectRatio.x2_3,
                "3:2" => CreateStableImageGenerateCoreRequestAspectRatio.x3_2,
                "4:5" => CreateStableImageGenerateCoreRequestAspectRatio.x4_5,
                "5:4" => CreateStableImageGenerateCoreRequestAspectRatio.x5_4,
                "9:16" => CreateStableImageGenerateCoreRequestAspectRatio.x9_16,
                "9:21" => CreateStableImageGenerateCoreRequestAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}