
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName), TypeInfoPropertyName = "ContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>), TypeInfoPropertyName = "AllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason), TypeInfoPropertyName = "ImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AsyncGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset), TypeInfoPropertyName = "StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode), TypeInfoPropertyName = "InpaintingSearchModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat), TypeInfoPropertyName = "InpaintingSearchModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode), TypeInfoPropertyName = "InpaintingMaskingModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat), TypeInfoPropertyName = "InpaintingMaskingModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason?), TypeInfoPropertyName = "NullableImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset?), TypeInfoPropertyName = "NullableStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode?), TypeInfoPropertyName = "NullableInpaintingSearchModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat?), TypeInfoPropertyName = "NullableInpaintingSearchModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode?), TypeInfoPropertyName = "NullableInpaintingMaskingModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat?), TypeInfoPropertyName = "NullableInpaintingMaskingModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateV2alphaGenerationStableImageUpscaleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest?), TypeInfoPropertyName = "NullableCreateV2alphaGenerationStableImageInpaintRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode?), TypeInfoPropertyName = "NullableCreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept?), TypeInfoPropertyName = "NullableGetV2alphaGenerationStableImageUpscaleResultAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept?), TypeInfoPropertyName = "NullableCreateV2alphaGenerationStableImageInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus?), TypeInfoPropertyName = "NullableGetV2alphaGenerationStableImageUpscaleResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class V2alphaGenerationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V2alphaGenerationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static V2alphaGenerationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private V2alphaGenerationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestJsonConverter());
            options.Converters.Add(new global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>());
            options.Converters.Add(new global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>());
            options.Converters.Add(new global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>());
            options.Converters.Add(new global::StabilityAI.JsonConverters.AllOfJsonConverter<string, object>());
            options.Converters.Add(new global::StabilityAI.JsonConverters.AllOfJsonConverter<string, object>());
            options.Converters.Add(new global::StabilityAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::StabilityAI.ContentModerationResponseName)

                    || typeToConvert == typeof(global::StabilityAI.ContentModerationResponseName?)

                    || typeToConvert == typeof(global::StabilityAI.ImageJSONResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.ImageJSONResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.StylePreset)

                    || typeToConvert == typeof(global::StabilityAI.StylePreset?)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode?)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode?)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode)

                    || typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode?)

                    || typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept)

                    || typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept?)

                    || typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus)

                    || typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::StabilityAI.ContentModerationResponseName))
                {
                    return new global::StabilityAI.JsonConverters.ContentModerationResponseNameJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.ContentModerationResponseName?))
                {
                    return new global::StabilityAI.JsonConverters.ContentModerationResponseNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.ImageJSONResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.ImageJSONResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.ImageJSONResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.ImageJSONResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.StylePreset))
                {
                    return new global::StabilityAI.JsonConverters.StylePresetJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.StylePreset?))
                {
                    return new global::StabilityAI.JsonConverters.StylePresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode?))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode?))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode))
                {
                    return new global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorModeJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode?))
                {
                    return new global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept))
                {
                    return new global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept?))
                {
                    return new global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus))
                {
                    return new global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus?))
                {
                    return new global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new V2alphaGenerationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}