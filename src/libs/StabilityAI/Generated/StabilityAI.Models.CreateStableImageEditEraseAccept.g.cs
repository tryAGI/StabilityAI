
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
    /// Default Value: image/*
    /// </summary>
    public enum CreateStableImageEditEraseAccept
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
    public static class CreateStableImageEditEraseAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditEraseAccept value)
        {
            return value switch
            {
                CreateStableImageEditEraseAccept.ApplicationJson => "application/json",
                CreateStableImageEditEraseAccept.ImageAny => "image/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditEraseAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateStableImageEditEraseAccept.ApplicationJson,
                "image/*" => CreateStableImageEditEraseAccept.ImageAny,
                _ => null,
            };
        }
    }
}