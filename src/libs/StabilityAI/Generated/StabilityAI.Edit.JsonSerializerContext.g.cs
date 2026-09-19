
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>), TypeInfoPropertyName = "AllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason), TypeInfoPropertyName = "ImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AsyncGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset), TypeInfoPropertyName = "StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditEraseRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditInpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditOutpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditRemoveBackgroundRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground), TypeInfoPropertyName = "CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection), TypeInfoPropertyName = "CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseAccept), TypeInfoPropertyName = "CreateStableImageEditEraseAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintAccept), TypeInfoPropertyName = "CreateStableImageEditInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept), TypeInfoPropertyName = "CreateStableImageEditOutpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept), TypeInfoPropertyName = "CreateStableImageEditRemoveBackgroundAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason?), TypeInfoPropertyName = "NullableImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset?), TypeInfoPropertyName = "NullableStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditEraseRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditInpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditOutpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndReplaceRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndRecolorRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditRemoveBackgroundRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground?), TypeInfoPropertyName = "NullableCreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection?), TypeInfoPropertyName = "NullableCreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseAccept?), TypeInfoPropertyName = "NullableCreateStableImageEditEraseAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintAccept?), TypeInfoPropertyName = "NullableCreateStableImageEditInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept?), TypeInfoPropertyName = "NullableCreateStableImageEditOutpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndReplaceAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndRecolorAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept?), TypeInfoPropertyName = "NullableCreateStableImageEditRemoveBackgroundAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class EditSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EditSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EditSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept?);
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

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundAcceptNullableJsonConverter();
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
                    0 => new EditSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}