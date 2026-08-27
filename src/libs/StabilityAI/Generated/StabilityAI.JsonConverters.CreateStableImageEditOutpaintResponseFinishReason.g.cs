#nullable enable

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateStableImageEditOutpaintResponseFinishReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason>
    {
        /// <inheritdoc />
        public override global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason Read(
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
                        return global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReasonExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReasonExtensions.ToValueString(value));
        }
    }
}
