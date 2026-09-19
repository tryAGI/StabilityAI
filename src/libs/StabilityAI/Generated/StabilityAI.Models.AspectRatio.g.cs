
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls the aspect ratio of the generated image.<br/>
    /// Default Value: 1:1
    /// </summary>
    public enum AspectRatio
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
    public static class AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatio value)
        {
            return value switch
            {
                AspectRatio.x16_9 => "16:9",
                AspectRatio.x1_1 => "1:1",
                AspectRatio.x21_9 => "21:9",
                AspectRatio.x2_3 => "2:3",
                AspectRatio.x3_2 => "3:2",
                AspectRatio.x4_5 => "4:5",
                AspectRatio.x5_4 => "5:4",
                AspectRatio.x9_16 => "9:16",
                AspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => AspectRatio.x16_9,
                "1:1" => AspectRatio.x1_1,
                "21:9" => AspectRatio.x21_9,
                "2:3" => AspectRatio.x2_3,
                "3:2" => AspectRatio.x3_2,
                "4:5" => AspectRatio.x4_5,
                "5:4" => AspectRatio.x5_4,
                "9:16" => AspectRatio.x9_16,
                "9:21" => AspectRatio.x9_21,
                _ => null,
            };
        }
    }
}