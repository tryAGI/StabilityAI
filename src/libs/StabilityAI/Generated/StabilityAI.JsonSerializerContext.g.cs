
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

            typeof(global::StabilityAI.JsonConverters.ContentModerationResponseNameJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ContentModerationResponseNameNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageJSONResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageJSONResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.AudioJSONResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.AudioJSONResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.StylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.StylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.AspectRatioJsonConverter),

            typeof(global::StabilityAI.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStableFast3dRequestTextureResolutionJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStableFast3dRequestTextureResolutionNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStableFast3dRequestRemeshJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStableFast3dRequestRemeshNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestTextureResolutionJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestTextureResolutionNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestRemeshJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestRemeshNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestTargetTypeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.Create3dStablePointAware3dRequestTargetTypeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestModelJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestModelNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestModelJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestModelNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestModelJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestModelNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestModelJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestModelNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestModelJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestModelNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleCreativeRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleCreativeRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestAspectRatioJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestAspectRatioNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModelJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestModelNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.TextToImageAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.TextToImageAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.UpscaleImageAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.UpscaleImageAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioTextToAudioAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioAudioToAudioAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudioInpaintAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3AcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3AcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferAcceptJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferAcceptNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageUsingImageStrengthRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageUsingStepScheduleRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingUsingMaskImageRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingUsingInitImageAlphaRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.TextToImageRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestJsonConverter),

            typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>),

            typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>),

            typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>),

            typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<string, object>),

            typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<string, object>),

            typeof(global::StabilityAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Engine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.EngineType), TypeInfoPropertyName = "EngineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ClipGuidancePreset), TypeInfoPropertyName = "ClipGuidancePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Sampler), TypeInfoPropertyName = "Sampler2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName), TypeInfoPropertyName = "ContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>), TypeInfoPropertyName = "AllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageJSONResponseFinishReason), TypeInfoPropertyName = "ImageJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AudioJSONResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AudioJSONResponseFinishReason), TypeInfoPropertyName = "AudioJSONResponseFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AsyncGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.StylePreset), TypeInfoPropertyName = "StylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode), TypeInfoPropertyName = "InpaintingSearchModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat), TypeInfoPropertyName = "InpaintingSearchModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode), TypeInfoPropertyName = "InpaintingMaskingModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat), TypeInfoPropertyName = "InpaintingMaskingModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStableFast3dRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStableFast3dRequestTextureResolution), TypeInfoPropertyName = "Create3dStableFast3dRequestTextureResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStableFast3dRequestRemesh), TypeInfoPropertyName = "Create3dStableFast3dRequestRemesh2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution), TypeInfoPropertyName = "Create3dStablePointAware3dRequestTextureResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dRequestRemesh), TypeInfoPropertyName = "Create3dStablePointAware3dRequestRemesh2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dRequestTargetType), TypeInfoPropertyName = "Create3dStablePointAware3dRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudio2InpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudioTextToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudioTextToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel), TypeInfoPropertyName = "CreateAudioStableAudioAudioToAudioRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudioAudioToAudioRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestModel), TypeInfoPropertyName = "CreateAudioStableAudioInpaintRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat), TypeInfoPropertyName = "CreateAudioStableAudioInpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageUpscaleConservativeRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageUpscaleCreativeRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageUpscaleFastRequestOutputFormat2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlSketchRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStructureRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStyleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStyleTransferRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.TextToImageAccept), TypeInfoPropertyName = "TextToImageAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ImageToImageAccept), TypeInfoPropertyName = "ImageToImageAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.UpscaleImageAccept), TypeInfoPropertyName = "UpscaleImageAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.MaskingAccept), TypeInfoPropertyName = "MaskingAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsAccept), TypeInfoPropertyName = "GetResultsAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintAccept), TypeInfoPropertyName = "CreateAudioStableAudio2InpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudioTextToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept), TypeInfoPropertyName = "CreateAudioStableAudioAudioToAudioAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintAccept), TypeInfoPropertyName = "CreateAudioStableAudioInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultAccept), TypeInfoPropertyName = "FetchAudioResultAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeAccept), TypeInfoPropertyName = "CreateStableImageUpscaleConservativeAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultAccept), TypeInfoPropertyName = "GetStableImageUpscaleCreativeResultAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastAccept), TypeInfoPropertyName = "CreateStableImageUpscaleFastAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseAccept), TypeInfoPropertyName = "CreateStableImageEditEraseAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintAccept), TypeInfoPropertyName = "CreateStableImageEditInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept), TypeInfoPropertyName = "CreateStableImageEditOutpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept), TypeInfoPropertyName = "CreateStableImageEditRemoveBackgroundAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraAccept), TypeInfoPropertyName = "CreateStableImageGenerateUltraAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreAccept), TypeInfoPropertyName = "CreateStableImageGenerateCoreAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Accept), TypeInfoPropertyName = "CreateStableImageGenerateSd3Accept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchAccept), TypeInfoPropertyName = "CreateStableImageControlSketchAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureAccept), TypeInfoPropertyName = "CreateStableImageControlStructureAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleAccept), TypeInfoPropertyName = "CreateStableImageControlStyleAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferAccept), TypeInfoPropertyName = "CreateStableImageControlStyleTransferAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StabilityAI.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponseStatus), TypeInfoPropertyName = "GetResultsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponseStatus), TypeInfoPropertyName = "FetchAudioResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponseStatus), TypeInfoPropertyName = "GetStableImageUpscaleCreativeResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.TextPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.Engine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.Image>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}