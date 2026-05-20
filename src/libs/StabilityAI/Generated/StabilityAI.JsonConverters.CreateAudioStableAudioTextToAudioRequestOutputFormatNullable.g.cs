#nullable enable

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAudioStableAudioTextToAudioRequestOutputFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat?>
    {
        /// <inheritdoc />
        public override global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat? Read(
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
                        return global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
