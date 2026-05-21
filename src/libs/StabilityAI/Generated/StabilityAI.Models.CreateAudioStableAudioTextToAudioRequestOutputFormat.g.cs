
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated audio.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateAudioStableAudioTextToAudioRequestOutputFormat
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
    public static class CreateAudioStableAudioTextToAudioRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudioTextToAudioRequestOutputFormat value)
        {
            return value switch
            {
                CreateAudioStableAudioTextToAudioRequestOutputFormat.Mp3 => "mp3",
                CreateAudioStableAudioTextToAudioRequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudioTextToAudioRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateAudioStableAudioTextToAudioRequestOutputFormat.Mp3,
                "wav" => CreateAudioStableAudioTextToAudioRequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}