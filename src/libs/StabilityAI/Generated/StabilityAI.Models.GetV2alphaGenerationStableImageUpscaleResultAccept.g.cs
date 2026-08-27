
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
    /// Default Value: image/*
    /// </summary>
    public enum GetV2alphaGenerationStableImageUpscaleResultAccept
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
    public static class GetV2alphaGenerationStableImageUpscaleResultAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetV2alphaGenerationStableImageUpscaleResultAccept value)
        {
            return value switch
            {
                GetV2alphaGenerationStableImageUpscaleResultAccept.ApplicationJson => "application/json",
                GetV2alphaGenerationStableImageUpscaleResultAccept.ImageAny => "image/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetV2alphaGenerationStableImageUpscaleResultAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => GetV2alphaGenerationStableImageUpscaleResultAccept.ApplicationJson,
                "image/*" => GetV2alphaGenerationStableImageUpscaleResultAccept.ImageAny,
                _ => null,
            };
        }
    }
}