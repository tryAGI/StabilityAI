
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
    /// Default Value: image/*
    /// </summary>
    public enum CreateStableImageEditSearchAndReplaceAccept
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
    public static class CreateStableImageEditSearchAndReplaceAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditSearchAndReplaceAccept value)
        {
            return value switch
            {
                CreateStableImageEditSearchAndReplaceAccept.ApplicationJson => "application/json",
                CreateStableImageEditSearchAndReplaceAccept.ImageAny => "image/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditSearchAndReplaceAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateStableImageEditSearchAndReplaceAccept.ApplicationJson,
                "image/*" => CreateStableImageEditSearchAndReplaceAccept.ImageAny,
                _ => null,
            };
        }
    }
}