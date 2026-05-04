#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace StabilityAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateV2alphaGenerationStableImageInpaintRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest>
    {
        /// <inheritdoc />
        public override global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::StabilityAI.InpaintingSearchModeRequestBody? search = default;
            if (discriminator?.Mode == global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode.Search)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.InpaintingSearchModeRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.InpaintingSearchModeRequestBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::StabilityAI.InpaintingSearchModeRequestBody)}");
                search = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::StabilityAI.InpaintingMaskingModeRequestBody? mask = default;
            if (discriminator?.Mode == global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode.Mask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.InpaintingMaskingModeRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.InpaintingMaskingModeRequestBody> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::StabilityAI.InpaintingMaskingModeRequestBody)}");
                mask = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest(
                discriminator?.Mode,
                search,

                mask
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.InpaintingSearchModeRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.InpaintingSearchModeRequestBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.InpaintingSearchModeRequestBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search!, typeInfo);
            }
            else if (value.IsMask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::StabilityAI.InpaintingMaskingModeRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::StabilityAI.InpaintingMaskingModeRequestBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::StabilityAI.InpaintingMaskingModeRequestBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mask!, typeInfo);
            }
        }
    }
}