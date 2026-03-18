#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public class MaskingUsingInitImageAlphaRequestBodyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.MaskingUsingInitImageAlphaRequestBody>
    {
        /// <inheritdoc />
        public override global::StabilityAI.MaskingUsingInitImageAlphaRequestBody Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::StabilityAI.GenerationRequestOptionalParams? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.GenerationRequestOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.GenerationRequestOptionalParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.GenerationRequestOptionalParams).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::StabilityAI.MaskingUsingInitImageAlphaRequestBody(
                value1,

                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.GenerationRequestOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.GenerationRequestOptionalParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.GenerationRequestOptionalParams).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.MaskingUsingInitImageAlphaRequestBody value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.GenerationRequestOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.GenerationRequestOptionalParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.GenerationRequestOptionalParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}