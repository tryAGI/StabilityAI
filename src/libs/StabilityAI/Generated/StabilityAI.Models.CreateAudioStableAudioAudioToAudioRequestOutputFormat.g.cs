
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated audio.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateAudioStableAudioAudioToAudioRequestOutputFormat
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
    public static class CreateAudioStableAudioAudioToAudioRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudioAudioToAudioRequestOutputFormat value)
        {
            return value switch
            {
                CreateAudioStableAudioAudioToAudioRequestOutputFormat.Mp3 => "mp3",
                CreateAudioStableAudioAudioToAudioRequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudioAudioToAudioRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateAudioStableAudioAudioToAudioRequestOutputFormat.Mp3,
                "wav" => CreateAudioStableAudioAudioToAudioRequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}