
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlSketchRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStructureRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStyleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStyleTransferRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchAccept), TypeInfoPropertyName = "CreateStableImageControlSketchAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureAccept), TypeInfoPropertyName = "CreateStableImageControlStructureAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleAccept), TypeInfoPropertyName = "CreateStableImageControlStyleAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferAccept), TypeInfoPropertyName = "CreateStableImageControlStyleTransferAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason?), TypeInfoPropertyName = "NullableImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset?), TypeInfoPropertyName = "NullableStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AspectRatio?), TypeInfoPropertyName = "NullableAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageControlSketchRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageControlStructureRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageControlStyleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageControlStyleTransferRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchAccept?), TypeInfoPropertyName = "NullableCreateStableImageControlSketchAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureAccept?), TypeInfoPropertyName = "NullableCreateStableImageControlStructureAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleAccept?), TypeInfoPropertyName = "NullableCreateStableImageControlStyleAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferAccept?), TypeInfoPropertyName = "NullableCreateStableImageControlStyleTransferAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class ControlSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ControlSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ControlSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ControlSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferAccept?);
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

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlSketchAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlSketchAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlSketchAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStructureAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStructureAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStructureAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageControlStyleTransferAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferAcceptNullableJsonConverter();
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
                    0 => new ControlSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}