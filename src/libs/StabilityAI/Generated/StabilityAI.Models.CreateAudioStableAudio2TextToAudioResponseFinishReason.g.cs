
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
    /// Example: SUCCESS
    /// </summary>
    public enum CreateAudioStableAudio2TextToAudioResponseFinishReason
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioStableAudio2TextToAudioResponseFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudio2TextToAudioResponseFinishReason value)
        {
            return value switch
            {
                CreateAudioStableAudio2TextToAudioResponseFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudio2TextToAudioResponseFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => CreateAudioStableAudio2TextToAudioResponseFinishReason.Success,
                _ => null,
            };
        }
    }
}