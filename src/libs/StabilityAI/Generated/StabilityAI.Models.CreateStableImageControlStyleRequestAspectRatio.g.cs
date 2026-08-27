
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Controls the aspect ratio of the generated image.<br/>
    /// Default Value: 1:1
    /// </summary>
    public enum CreateStableImageControlStyleRequestAspectRatio
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
    public static class CreateStableImageControlStyleRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStyleRequestAspectRatio value)
        {
            return value switch
            {
                CreateStableImageControlStyleRequestAspectRatio.x16_9 => "16:9",
                CreateStableImageControlStyleRequestAspectRatio.x1_1 => "1:1",
                CreateStableImageControlStyleRequestAspectRatio.x21_9 => "21:9",
                CreateStableImageControlStyleRequestAspectRatio.x2_3 => "2:3",
                CreateStableImageControlStyleRequestAspectRatio.x3_2 => "3:2",
                CreateStableImageControlStyleRequestAspectRatio.x4_5 => "4:5",
                CreateStableImageControlStyleRequestAspectRatio.x5_4 => "5:4",
                CreateStableImageControlStyleRequestAspectRatio.x9_16 => "9:16",
                CreateStableImageControlStyleRequestAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStyleRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateStableImageControlStyleRequestAspectRatio.x16_9,
                "1:1" => CreateStableImageControlStyleRequestAspectRatio.x1_1,
                "21:9" => CreateStableImageControlStyleRequestAspectRatio.x21_9,
                "2:3" => CreateStableImageControlStyleRequestAspectRatio.x2_3,
                "3:2" => CreateStableImageControlStyleRequestAspectRatio.x3_2,
                "4:5" => CreateStableImageControlStyleRequestAspectRatio.x4_5,
                "5:4" => CreateStableImageControlStyleRequestAspectRatio.x5_4,
                "9:16" => CreateStableImageControlStyleRequestAspectRatio.x9_16,
                "9:21" => CreateStableImageControlStyleRequestAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}