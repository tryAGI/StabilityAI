
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The model to use for generation.<br/>
    /// - `stable-audio-2.5` requires 20 credits per generation<br/>
    /// - `stable-audio-2` requires 20 credits per generation<br/>
    /// Default Value: stable-audio-2
    /// </summary>
    public enum CreateAudioStableAudio2AudioToAudioRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        StableAudio2,
        /// <summary>
        ///
        /// </summary>
        StableAudio25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioStableAudio2AudioToAudioRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudio2AudioToAudioRequestModel value)
        {
            return value switch
            {
                CreateAudioStableAudio2AudioToAudioRequestModel.StableAudio2 => "stable-audio-2",
                CreateAudioStableAudio2AudioToAudioRequestModel.StableAudio25 => "stable-audio-2.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudio2AudioToAudioRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "stable-audio-2" => CreateAudioStableAudio2AudioToAudioRequestModel.StableAudio2,
                "stable-audio-2.5" => CreateAudioStableAudio2AudioToAudioRequestModel.StableAudio25,
                _ => null,
            };
        }
    }
}