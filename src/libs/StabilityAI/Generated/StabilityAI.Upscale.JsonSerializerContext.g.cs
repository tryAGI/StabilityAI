
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageUpscaleConservativeRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageUpscaleCreativeRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageUpscaleFastRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeAccept), TypeInfoPropertyName = "CreateStableImageUpscaleConservativeAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastAccept), TypeInfoPropertyName = "CreateStableImageUpscaleFastAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason?), TypeInfoPropertyName = "NullableImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset?), TypeInfoPropertyName = "NullableStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageUpscaleConservativeRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageUpscaleCreativeRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageUpscaleFastRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeAccept?), TypeInfoPropertyName = "NullableCreateStableImageUpscaleConservativeAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastAccept?), TypeInfoPropertyName = "NullableCreateStableImageUpscaleFastAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class UpscaleSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpscaleSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UpscaleSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UpscaleSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastAccept?);
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

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleCreativeRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleCreativeRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleConservativeAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageUpscaleFastAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastAcceptNullableJsonConverter();
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
                    0 => new UpscaleSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}