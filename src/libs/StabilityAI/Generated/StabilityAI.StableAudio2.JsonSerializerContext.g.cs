
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName), TypeInfoPropertyName = "ContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>), TypeInfoPropertyName = "AllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AudioJSONResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AudioJSONResponseFinishReason), TypeInfoPropertyName = "AudioJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudio2InpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintAccept), TypeInfoPropertyName = "CreateAudioStableAudio2InpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AudioJSONResponseFinishReason?), TypeInfoPropertyName = "NullableAudioJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2TextToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2TextToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2AudioToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2AudioToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2InpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2TextToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2AudioToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintAccept?), TypeInfoPropertyName = "NullableCreateAudioStableAudio2InpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class StableAudio2SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StableAudio2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StableAudio2SourceGenerationContext Default { get; } = new(DefaultOptions);

        private StableAudio2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::StabilityAI.AudioJSONResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.AudioJSONResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintAccept?);
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

                if (typeToConvert == typeof(global::StabilityAI.AudioJSONResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.AudioJSONResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.AudioJSONResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.AudioJSONResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudio2InpaintAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintAcceptNullableJsonConverter();
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
                    0 => new StableAudio2SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}