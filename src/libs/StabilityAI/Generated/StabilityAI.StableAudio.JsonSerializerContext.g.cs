
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AsyncGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudioTextToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudioTextToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudioAudioToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudioAudioToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestModel), TypeInfoPropertyName = "CreateAudioStableAudioInpaintRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudioInpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudioTextToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudioAudioToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintAccept), TypeInfoPropertyName = "CreateAudioStableAudioInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultAccept), TypeInfoPropertyName = "FetchAudioResultAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponseStatus), TypeInfoPropertyName = "FetchAudioResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AudioJSONResponseFinishReason?), TypeInfoPropertyName = "NullableAudioJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel?), TypeInfoPropertyName = "NullableCreateAudioStableAudioTextToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateAudioStableAudioTextToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel?), TypeInfoPropertyName = "NullableCreateAudioStableAudioAudioToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateAudioStableAudioAudioToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestModel?), TypeInfoPropertyName = "NullableCreateAudioStableAudioInpaintRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateAudioStableAudioInpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept?), TypeInfoPropertyName = "NullableCreateAudioStableAudioTextToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept?), TypeInfoPropertyName = "NullableCreateAudioStableAudioAudioToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintAccept?), TypeInfoPropertyName = "NullableCreateAudioStableAudioInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultAccept?), TypeInfoPropertyName = "NullableFetchAudioResultAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponseStatus?), TypeInfoPropertyName = "NullableFetchAudioResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class StableAudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StableAudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StableAudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StableAudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestModel)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestModel?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintAccept?)

                    || typeToConvert == typeof(global::StabilityAI.FetchAudioResultAccept)

                    || typeToConvert == typeof(global::StabilityAI.FetchAudioResultAccept?)

                    || typeToConvert == typeof(global::StabilityAI.FetchAudioResultResponseStatus)

                    || typeToConvert == typeof(global::StabilityAI.FetchAudioResultResponseStatus?);
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

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestModel))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestModel?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateAudioStableAudioInpaintAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.FetchAudioResultAccept))
                {
                    return new global::StabilityAI.JsonConverters.FetchAudioResultAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.FetchAudioResultAccept?))
                {
                    return new global::StabilityAI.JsonConverters.FetchAudioResultAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.FetchAudioResultResponseStatus))
                {
                    return new global::StabilityAI.JsonConverters.FetchAudioResultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.FetchAudioResultResponseStatus?))
                {
                    return new global::StabilityAI.JsonConverters.FetchAudioResultResponseStatusNullableJsonConverter();
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
                    0 => new StableAudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}