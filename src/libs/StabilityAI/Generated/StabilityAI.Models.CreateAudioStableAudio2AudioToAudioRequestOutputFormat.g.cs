
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated audio.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateAudioStableAudio2AudioToAudioRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioStableAudio2AudioToAudioRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudio2AudioToAudioRequestOutputFormat value)
        {
            return value switch
            {
                CreateAudioStableAudio2AudioToAudioRequestOutputFormat.Mp3 => "mp3",
                CreateAudioStableAudio2AudioToAudioRequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudio2AudioToAudioRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateAudioStableAudio2AudioToAudioRequestOutputFormat.Mp3,
                "wav" => CreateAudioStableAudio2AudioToAudioRequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}