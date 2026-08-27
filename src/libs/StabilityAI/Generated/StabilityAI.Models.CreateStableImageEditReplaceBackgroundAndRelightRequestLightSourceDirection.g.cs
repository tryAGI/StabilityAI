
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Direction of the light source.
    /// </summary>
    public enum CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection
    {
        /// <summary>
        ///
        /// </summary>
        Above,
        /// <summary>
        ///
        /// </summary>
        Below,
        /// <summary>
        ///
        /// </summary>
        Left,
        /// <summary>
        ///
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection value)
        {
            return value switch
            {
                CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Above => "above",
                CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Below => "below",
                CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Left => "left",
                CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? ToEnum(string value)
        {
            return value switch
            {
                "above" => CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Above,
                "below" => CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Below,
                "left" => CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Left,
                "right" => CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection.Right,
                _ => null,
            };
        }
    }
}