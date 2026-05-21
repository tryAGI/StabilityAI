#nullable enable

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAudioStableAudioTextToAudioAcceptJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.CreateAudioStableAudioTextToAudioAccept>
    {
        /// <inheritdoc />
        public override global::StabilityAI.CreateAudioStableAudioTextToAudioAccept Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::StabilityAI.CreateAudioStableAudioTextToAudioAcceptExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StabilityAI.CreateAudioStableAudioTextToAudioAccept)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::StabilityAI.CreateAudioStableAudioTextToAudioAcceptExtensions.ToValueString(value));
        }
    }
}
