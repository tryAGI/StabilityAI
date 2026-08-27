#nullable enable

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class Create3dStablePointAware3dRequestRemeshJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.Create3dStablePointAware3dRequestRemesh>
    {
        /// <inheritdoc />
        public override global::StabilityAI.Create3dStablePointAware3dRequestRemesh Read(
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
                        return global::StabilityAI.Create3dStablePointAware3dRequestRemeshExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StabilityAI.Create3dStablePointAware3dRequestRemesh)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StabilityAI.Create3dStablePointAware3dRequestRemesh);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.Create3dStablePointAware3dRequestRemesh value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::StabilityAI.Create3dStablePointAware3dRequestRemeshExtensions.ToValueString(value));
        }
    }
}
