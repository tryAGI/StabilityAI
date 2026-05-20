#nullable enable

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class FetchAudioResultResponseFinishReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.FetchAudioResultResponseFinishReason?>
    {
        /// <inheritdoc />
        public override global::StabilityAI.FetchAudioResultResponseFinishReason? Read(
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
                        return global::StabilityAI.FetchAudioResultResponseFinishReasonExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StabilityAI.FetchAudioResultResponseFinishReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StabilityAI.FetchAudioResultResponseFinishReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.FetchAudioResultResponseFinishReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::StabilityAI.FetchAudioResultResponseFinishReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
