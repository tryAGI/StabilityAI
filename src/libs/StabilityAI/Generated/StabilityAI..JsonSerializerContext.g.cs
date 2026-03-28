
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
            typeof(global::StabilityAI.JsonConverters.EngineTypeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.EngineTypeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ClipGuidancePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ClipGuidancePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.SamplerJsonConverter),

            typeof(global::StabilityAI.JsonConverters.SamplerNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InitImageModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InitImageModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageRequestBodyDiscriminatorInitImageModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageRequestBodyDiscriminatorInitImageModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingRequestBodyDiscriminatorMaskSourceJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingRequestBodyDiscriminatorMaskSourceNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.TextToImageAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.TextToImageAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.UpscaleImageAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.UpscaleImageAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageUsingImageStrengthRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageUsingStepScheduleRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingUsingMaskImageRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingUsingInitImageAlphaRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.TextToImageRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Engine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.EngineType), TypeInfoPropertyName = "EngineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ClipGuidancePreset), TypeInfoPropertyName = "ClipGuidancePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Sampler), TypeInfoPropertyName = "Sampler2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.TextPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StabilityAI.TextPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InitImageMode), TypeInfoPropertyName = "InitImageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GenerationRequestOptionalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.UpscaleImageRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageRequestBodyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageRequestBodyDiscriminatorInitImageMode), TypeInfoPropertyName = "ImageToImageRequestBodyDiscriminatorInitImageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageUsingImageStrengthRequestBody), TypeInfoPropertyName = "ImageToImageUsingImageStrengthRequestBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageUsingImageStrengthRequestBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageUsingStepScheduleRequestBody), TypeInfoPropertyName = "ImageToImageUsingStepScheduleRequestBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageUsingStepScheduleRequestBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingRequestBodyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingRequestBodyDiscriminatorMaskSource), TypeInfoPropertyName = "MaskingRequestBodyDiscriminatorMaskSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingUsingMaskImageRequestBody), TypeInfoPropertyName = "MaskingUsingMaskImageRequestBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingUsingMaskImageRequestBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBody), TypeInfoPropertyName = "MaskingUsingInitImageAlphaRequestBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.TextToImageRequestBody), TypeInfoPropertyName = "TextToImageRequestBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.TextToImageRequestBodyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AccountResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StabilityAI.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.OrganizationMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.BalanceResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StabilityAI.Engine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageFinishReason), TypeInfoPropertyName = "ImageFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.TextToImageAccept), TypeInfoPropertyName = "TextToImageAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageAccept), TypeInfoPropertyName = "ImageToImageAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.UpscaleImageAccept), TypeInfoPropertyName = "UpscaleImageAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingAccept), TypeInfoPropertyName = "MaskingAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StabilityAI.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.TextPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.Engine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.Image>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}