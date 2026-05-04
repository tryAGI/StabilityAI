
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated audio.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateAudioStableAudio2TextToAudioRequestOutputFormat
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
    public static class CreateAudioStableAudio2TextToAudioRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudio2TextToAudioRequestOutputFormat value)
        {
            return value switch
            {
                CreateAudioStableAudio2TextToAudioRequestOutputFormat.Mp3 => "mp3",
                CreateAudioStableAudio2TextToAudioRequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudio2TextToAudioRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateAudioStableAudio2TextToAudioRequestOutputFormat.Mp3,
                "wav" => CreateAudioStableAudio2TextToAudioRequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}