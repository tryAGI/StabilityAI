
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// The model to use for generation.<br/>
    /// - `stable-audio-3` requires 26 credits per generation<br/>
    /// Default Value: stable-audio-3
    /// </summary>
    public enum CreateAudioStableAudioInpaintRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        StableAudio3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAudioStableAudioInpaintRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAudioStableAudioInpaintRequestModel value)
        {
            return value switch
            {
                CreateAudioStableAudioInpaintRequestModel.StableAudio3 => "stable-audio-3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAudioStableAudioInpaintRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "stable-audio-3" => CreateAudioStableAudioInpaintRequestModel.StableAudio3,
                _ => null,
            };
        }
    }
}