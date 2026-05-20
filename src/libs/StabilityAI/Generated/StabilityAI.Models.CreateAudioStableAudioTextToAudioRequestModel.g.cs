
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The model to use for generation.<br/>
    /// - `stable-audio-3` requires 26 credits per generation<br/>
    /// Default Value: stable-audio-3
    /// </summary>
    public enum CreateAudioStableAudioTextToAudioRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        StableAudio3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioStableAudioTextToAudioRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudioTextToAudioRequestModel value)
        {
            return value switch
            {
                CreateAudioStableAudioTextToAudioRequestModel.StableAudio3 => "stable-audio-3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudioTextToAudioRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "stable-audio-3" => CreateAudioStableAudioTextToAudioRequestModel.StableAudio3,
                _ => null,
            };
        }
    }
}