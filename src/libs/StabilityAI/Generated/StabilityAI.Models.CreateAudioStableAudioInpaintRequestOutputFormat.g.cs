
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Dictates the `content-type` of the generated audio.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateAudioStableAudioInpaintRequestOutputFormat
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
    public static class CreateAudioStableAudioInpaintRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudioInpaintRequestOutputFormat value)
        {
            return value switch
            {
                CreateAudioStableAudioInpaintRequestOutputFormat.Mp3 => "mp3",
                CreateAudioStableAudioInpaintRequestOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudioInpaintRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateAudioStableAudioInpaintRequestOutputFormat.Mp3,
                "wav" => CreateAudioStableAudioInpaintRequestOutputFormat.Wav,
                _ => null,
            };
        }
    }
}