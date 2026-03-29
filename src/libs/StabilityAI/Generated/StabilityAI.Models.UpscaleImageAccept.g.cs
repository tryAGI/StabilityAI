
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Default Value: application/json
    /// </summary>
    public enum UpscaleImageAccept
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
    public static class UpscaleImageAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageAccept value)
        {
            return value switch
            {
                UpscaleImageAccept.ApplicationDividejson => "application/json",
                UpscaleImageAccept.ImageDividepng => "image/png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => UpscaleImageAccept.ApplicationDividejson,
                "image/png" => UpscaleImageAccept.ImageDividepng,
                _ => null,
            };
        }
    }
}