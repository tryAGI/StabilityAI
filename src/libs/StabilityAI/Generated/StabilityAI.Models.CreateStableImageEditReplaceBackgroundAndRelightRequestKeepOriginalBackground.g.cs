
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Whether to keep the background of the original image. When this is on, the background<br/>
    /// will have different lighting than the original image that changes based on the other<br/>
    /// parameters in this API.<br/>
    /// Default Value: false
    /// </summary>
    public enum CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground value)
        {
            return value switch
            {
                CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground.False => "false",
                CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? ToEnum(string value)
        {
            return value switch
            {
                "false" => CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground.False,
                "true" => CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground.True,
                _ => null,
            };
        }
    }
}