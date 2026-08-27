
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated image.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateStableImageControlStyleTransferRequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageControlStyleTransferRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStyleTransferRequestOutputFormat value)
        {
            return value switch
            {
                CreateStableImageControlStyleTransferRequestOutputFormat.Jpeg => "jpeg",
                CreateStableImageControlStyleTransferRequestOutputFormat.Png => "png",
                CreateStableImageControlStyleTransferRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStyleTransferRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateStableImageControlStyleTransferRequestOutputFormat.Jpeg,
                "png" => CreateStableImageControlStyleTransferRequestOutputFormat.Png,
                "webp" => CreateStableImageControlStyleTransferRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}