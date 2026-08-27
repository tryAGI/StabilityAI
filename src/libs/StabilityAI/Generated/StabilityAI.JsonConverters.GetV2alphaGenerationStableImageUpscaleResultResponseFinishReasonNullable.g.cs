#nullable enable

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetV2alphaGenerationStableImageUpscaleResultResponseFinishReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason?>
    {
        /// <inheritdoc />
        public override global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason? Read(
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
                        return global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
