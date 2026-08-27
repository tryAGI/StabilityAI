
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `audio/*` to receive the bytes of the audio directly. Otherwise specify `application/json` to receive the audio as base64 encoded JSON.<br/>
    /// Default Value: audio/*
    /// </summary>
    public enum FetchAudioResultAccept
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationJson,
        /// <summary>
        ///
        /// </summary>
        AudioAny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FetchAudioResultAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FetchAudioResultAccept value)
        {
            return value switch
            {
                FetchAudioResultAccept.ApplicationJson => "application/json",
                FetchAudioResultAccept.AudioAny => "audio/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FetchAudioResultAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => FetchAudioResultAccept.ApplicationJson,
                "audio/*" => FetchAudioResultAccept.AudioAny,
                _ => null,
            };
        }
    }
}