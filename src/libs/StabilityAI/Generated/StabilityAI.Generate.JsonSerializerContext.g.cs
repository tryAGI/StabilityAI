
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset), TypeInfoPropertyName = "StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageGenerateUltraRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageGenerateCoreRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<string, object>), TypeInfoPropertyName = "AllOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestMode), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestModel), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraAccept), TypeInfoPropertyName = "CreateStableImageGenerateUltraAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreAccept), TypeInfoPropertyName = "CreateStableImageGenerateCoreAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Accept), TypeInfoPropertyName = "CreateStableImageGenerateSd3Accept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason?), TypeInfoPropertyName = "NullableImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset?), TypeInfoPropertyName = "NullableStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AspectRatio?), TypeInfoPropertyName = "NullableAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageGenerateUltraRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageGenerateCoreRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<string, object>?), TypeInfoPropertyName = "NullableAllOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestMode?), TypeInfoPropertyName = "NullableCreateStableImageGenerateSd3RequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio?), TypeInfoPropertyName = "NullableCreateStableImageGenerateSd3RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestModel?), TypeInfoPropertyName = "NullableCreateStableImageGenerateSd3RequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageGenerateSd3RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraAccept?), TypeInfoPropertyName = "NullableCreateStableImageGenerateUltraAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreAccept?), TypeInfoPropertyName = "NullableCreateStableImageGenerateCoreAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Accept?), TypeInfoPropertyName = "NullableCreateStableImageGenerateSd3Accept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class GenerateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenerateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenerateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::StabilityAI.AspectRatio)

                    || typeToConvert == typeof(global::StabilityAI.AspectRatio?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestMode)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestMode?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestModel)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestModel?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3Accept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3Accept?);
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

                if (typeToConvert == typeof(global::StabilityAI.AspectRatio))
                {
                    return new global::StabilityAI.JsonConverters.AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.AspectRatio?))
                {
                    return new global::StabilityAI.JsonConverters.AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestMode))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModeJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestMode?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestModel))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestModel?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateUltraAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateCoreAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3Accept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3AcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageGenerateSd3Accept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3AcceptNullableJsonConverter();
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
                    0 => new GenerateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}