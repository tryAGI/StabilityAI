
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The reason the generation finished. It is always `SUCCESS` for this endpoint.<br/>
    /// Example: SUCCESS
    /// </summary>
    public enum CreateAudioStableAudio2AudioToAudioResponseFinishReason2
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioStableAudio2AudioToAudioResponseFinishReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudio2AudioToAudioResponseFinishReason2 value)
        {
            return value switch
            {
                CreateAudioStableAudio2AudioToAudioResponseFinishReason2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudio2AudioToAudioResponseFinishReason2? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => CreateAudioStableAudio2AudioToAudioResponseFinishReason2.Success,
                _ => null,
            };
        }
    }
}