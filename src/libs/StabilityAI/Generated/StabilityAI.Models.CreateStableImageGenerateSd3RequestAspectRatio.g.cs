
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls the aspect ratio of the generated image. Defaults to 1:1.<br/>
    /// &gt; **Important:** This parameter is only valid for **text-to-image** requests.<br/>
    /// Default Value: 1:1
    /// </summary>
    public enum CreateStableImageGenerateSd3RequestAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        /// 1.
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
    public static class CreateStableImageGenerateSd3RequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateSd3RequestAspectRatio value)
        {
            return value switch
            {
                CreateStableImageGenerateSd3RequestAspectRatio.x16_9 => "16:9",
                CreateStableImageGenerateSd3RequestAspectRatio.x1_1 => "1:1",
                CreateStableImageGenerateSd3RequestAspectRatio.x21_9 => "21:9",
                CreateStableImageGenerateSd3RequestAspectRatio.x2_3 => "2:3",
                CreateStableImageGenerateSd3RequestAspectRatio.x3_2 => "3:2",
                CreateStableImageGenerateSd3RequestAspectRatio.x4_5 => "4:5",
                CreateStableImageGenerateSd3RequestAspectRatio.x5_4 => "5:4",
                CreateStableImageGenerateSd3RequestAspectRatio.x9_16 => "9:16",
                CreateStableImageGenerateSd3RequestAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateSd3RequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateStableImageGenerateSd3RequestAspectRatio.x16_9,
                "1:1" => CreateStableImageGenerateSd3RequestAspectRatio.x1_1,
                "21:9" => CreateStableImageGenerateSd3RequestAspectRatio.x21_9,
                "2:3" => CreateStableImageGenerateSd3RequestAspectRatio.x2_3,
                "3:2" => CreateStableImageGenerateSd3RequestAspectRatio.x3_2,
                "4:5" => CreateStableImageGenerateSd3RequestAspectRatio.x4_5,
                "5:4" => CreateStableImageGenerateSd3RequestAspectRatio.x5_4,
                "9:16" => CreateStableImageGenerateSd3RequestAspectRatio.x9_16,
                "9:21" => CreateStableImageGenerateSd3RequestAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}