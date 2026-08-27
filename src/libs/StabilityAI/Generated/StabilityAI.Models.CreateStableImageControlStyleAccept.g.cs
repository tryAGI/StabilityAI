
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
    /// Default Value: image/*
    /// </summary>
    public enum CreateStableImageControlStyleAccept
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
    public static class CreateStableImageControlStyleAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageControlStyleAccept value)
        {
            return value switch
            {
                CreateStableImageControlStyleAccept.ApplicationJson => "application/json",
                CreateStableImageControlStyleAccept.ImageAny => "image/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageControlStyleAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateStableImageControlStyleAccept.ApplicationJson,
                "image/*" => CreateStableImageControlStyleAccept.ImageAny,
                _ => null,
            };
        }
    }
}