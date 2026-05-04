
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
    /// Default Value: image/*
    /// </summary>
    public enum CreateV2alphaGenerationStableImageInpaintAccept
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
    public static class CreateV2alphaGenerationStableImageInpaintAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateV2alphaGenerationStableImageInpaintAccept value)
        {
            return value switch
            {
                CreateV2alphaGenerationStableImageInpaintAccept.ApplicationJson => "application/json",
                CreateV2alphaGenerationStableImageInpaintAccept.ImageAny => "image/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateV2alphaGenerationStableImageInpaintAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateV2alphaGenerationStableImageInpaintAccept.ApplicationJson,
                "image/*" => CreateV2alphaGenerationStableImageInpaintAccept.ImageAny,
                _ => null,
            };
        }
    }
}