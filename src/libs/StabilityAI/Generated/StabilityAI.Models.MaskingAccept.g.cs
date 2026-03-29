
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Default Value: application/json
    /// </summary>
    public enum MaskingAccept
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividejson,
        /// <summary>
        /// 
        /// </summary>
        ImageDividepng,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MaskingAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaskingAccept value)
        {
            return value switch
            {
                MaskingAccept.ApplicationDividejson => "application/json",
                MaskingAccept.ImageDividepng => "image/png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaskingAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => MaskingAccept.ApplicationDividejson,
                "image/png" => MaskingAccept.ImageDividepng,
                _ => null,
            };
        }
    }
}