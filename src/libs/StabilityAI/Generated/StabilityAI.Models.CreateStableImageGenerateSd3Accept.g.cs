
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
    /// Default Value: image/*
    /// </summary>
    public enum CreateStableImageGenerateSd3Accept
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationJson,
        /// <summary>
        ///
        /// </summary>
        ImageAny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStableImageGenerateSd3AcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateSd3Accept value)
        {
            return value switch
            {
                CreateStableImageGenerateSd3Accept.ApplicationJson => "application/json",
                CreateStableImageGenerateSd3Accept.ImageAny => "image/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateSd3Accept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateStableImageGenerateSd3Accept.ApplicationJson,
                "image/*" => CreateStableImageGenerateSd3Accept.ImageAny,
                _ => null,
            };
        }
    }
}