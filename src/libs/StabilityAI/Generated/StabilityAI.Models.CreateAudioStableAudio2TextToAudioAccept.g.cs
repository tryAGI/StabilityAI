
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Specify `audio/*` to receive the bytes of the audio directly. Otherwise specify `application/json` to receive the audio as base64 encoded JSON.<br/>
    /// Default Value: audio/*
    /// </summary>
    public enum CreateAudioStableAudio2TextToAudioAccept
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
    public static class CreateAudioStableAudio2TextToAudioAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudio2TextToAudioAccept value)
        {
            return value switch
            {
                CreateAudioStableAudio2TextToAudioAccept.ApplicationJson => "application/json",
                CreateAudioStableAudio2TextToAudioAccept.AudioAny => "audio/*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudio2TextToAudioAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateAudioStableAudio2TextToAudioAccept.ApplicationJson,
                "audio/*" => CreateAudioStableAudio2TextToAudioAccept.AudioAny,
                _ => null,
            };
        }
    }
}