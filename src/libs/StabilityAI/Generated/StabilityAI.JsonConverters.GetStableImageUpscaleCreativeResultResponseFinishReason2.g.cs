#nullable enable

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetStableImageUpscaleCreativeResultResponseFinishReason2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2>
    {
        /// <inheritdoc />
        public override global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2 Read(
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
                        return global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2Extensions.ToValueString(value));
        }
    }
}
