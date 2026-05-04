
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
    /// Default Value: image/*
    /// </summary>
    public enum CreateStableImageEditInpaintAccept
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
    public static class CreateStableImageEditInpaintAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageEditInpaintAccept value)
        {
            return value switch
            {
                CreateStableImageEditInpaintAccept.ApplicationJson => "application/json",
                CreateStableImageEditInpaintAccept.ImageAny => "image/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageEditInpaintAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateStableImageEditInpaintAccept.ApplicationJson,
                "image/*" => CreateStableImageEditInpaintAccept.ImageAny,
                _ => null,
            };
        }
    }
}