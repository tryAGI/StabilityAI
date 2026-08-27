
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

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingSearchModeRequestBodyOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyModeJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyModeNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.InpaintingMaskingModeRequestBodyOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageUpscaleRequestStylePresetNullableJsonConverter),

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

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleCreativeRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleCreativeRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackgroundNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirectionNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestAspectRatioJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestAspectRatioNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestAspectRatioJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestAspectRatioNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreRequestStylePresetNullableJsonConverter),

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

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3RequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureRequestStylePresetNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestAspectRatioJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestAspectRatioNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestOutputFormatJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestOutputFormatNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestStylePresetJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleRequestStylePresetNullableJsonConverter),

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

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetV2alphaGenerationStableImageUpscaleResultResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetResultsResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2TextToAudioResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2AudioToAudioResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateAudioStableAudio2InpaintResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.FetchAudioResultResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleConservativeResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseStatusJsonConverter),

            typeof(global::StabilityAI.JsonConverters.GetStableImageUpscaleCreativeResultResponseStatusNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageUpscaleFastResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateUltraResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateCoreResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3ResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3ResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3ResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3ResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3ResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageGenerateSd3ResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlSketchResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStructureResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferResponseFinishReasonJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferResponseFinishReasonNullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferResponseFinishReason2JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferResponseFinishReason2NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferResponseFinishReason3JsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateStableImageControlStyleTransferResponseFinishReason3NullableJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageUsingImageStrengthRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.ImageToImageUsingStepScheduleRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingUsingMaskImageRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.MaskingUsingInitImageAlphaRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.TextToImageRequestBodyJsonConverter),

            typeof(global::StabilityAI.JsonConverters.CreateV2alphaGenerationStableImageInpaintRequestJsonConverter),

            typeof(global::StabilityAI.JsonConverters.AllOfJsonConverter<double?, object>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName), TypeInfoPropertyName = "ContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyMode), TypeInfoPropertyName = "InpaintingSearchModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat), TypeInfoPropertyName = "InpaintingSearchModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyMode), TypeInfoPropertyName = "InpaintingMaskingModeRequestBodyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat), TypeInfoPropertyName = "InpaintingMaskingModeRequestBodyOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FalGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestStylePreset), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageUpscaleRequestStylePreset2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeRequestStylePreset), TypeInfoPropertyName = "CreateStableImageUpscaleCreativeRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageUpscaleFastRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditEraseRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditInpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset), TypeInfoPropertyName = "CreateStableImageEditInpaintRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>), TypeInfoPropertyName = "AllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditOutpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset), TypeInfoPropertyName = "CreateStableImageEditOutpaintRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestStylePreset), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestStylePreset), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditRemoveBackgroundRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground), TypeInfoPropertyName = "CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection), TypeInfoPropertyName = "CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestAspectRatio), TypeInfoPropertyName = "CreateStableImageGenerateUltraRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageGenerateUltraRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraRequestStylePreset), TypeInfoPropertyName = "CreateStableImageGenerateUltraRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestAspectRatio), TypeInfoPropertyName = "CreateStableImageGenerateCoreRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestStylePreset), TypeInfoPropertyName = "CreateStableImageGenerateCoreRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageGenerateCoreRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestMode), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestModel), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3RequestStylePreset), TypeInfoPropertyName = "CreateStableImageGenerateSd3RequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlSketchRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchRequestStylePreset), TypeInfoPropertyName = "CreateStableImageControlSketchRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStructureRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureRequestStylePreset), TypeInfoPropertyName = "CreateStableImageControlStructureRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequestAspectRatio), TypeInfoPropertyName = "CreateStableImageControlStyleRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat), TypeInfoPropertyName = "CreateStableImageControlStyleRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleRequestStylePreset), TypeInfoPropertyName = "CreateStableImageControlStyleRequestStylePreset2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason3), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus), TypeInfoPropertyName = "GetV2alphaGenerationStableImageUpscaleResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponseFinishReason), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponseFinishReason2), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponseFinishReason3), TypeInfoPropertyName = "CreateV2alphaGenerationStableImageInpaintResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStableFast3dResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStableFast3dResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStableFast3dResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStableFast3dResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.Create3dStablePointAware3dResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponseFinishReason), TypeInfoPropertyName = "GetResultsResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponseFinishReason2), TypeInfoPropertyName = "GetResultsResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponseFinishReason3), TypeInfoPropertyName = "GetResultsResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponseStatus), TypeInfoPropertyName = "GetResultsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetResultsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponseFinishReason), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponseFinishReason2), TypeInfoPropertyName = "CreateAudioStableAudio2TextToAudioResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponseFinishReason), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponseFinishReason2), TypeInfoPropertyName = "CreateAudioStableAudio2AudioToAudioResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponseFinishReason), TypeInfoPropertyName = "CreateAudioStableAudio2InpaintResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponseFinishReason2), TypeInfoPropertyName = "CreateAudioStableAudio2InpaintResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudio2InpaintResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioTextToAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateAudioStableAudioInpaintResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponseFinishReason), TypeInfoPropertyName = "FetchAudioResultResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponseFinishReason2), TypeInfoPropertyName = "FetchAudioResultResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponseStatus), TypeInfoPropertyName = "FetchAudioResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.FetchAudioResultResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponseFinishReason), TypeInfoPropertyName = "CreateStableImageUpscaleConservativeResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageUpscaleConservativeResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageUpscaleConservativeResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleConservativeResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleCreativeResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason), TypeInfoPropertyName = "GetStableImageUpscaleCreativeResultResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2), TypeInfoPropertyName = "GetStableImageUpscaleCreativeResultResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason3), TypeInfoPropertyName = "GetStableImageUpscaleCreativeResultResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponseStatus), TypeInfoPropertyName = "GetStableImageUpscaleCreativeResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.GetStableImageUpscaleCreativeResultResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponseFinishReason), TypeInfoPropertyName = "CreateStableImageUpscaleFastResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageUpscaleFastResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageUpscaleFastResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageUpscaleFastResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason), TypeInfoPropertyName = "CreateStableImageEditEraseResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageEditEraseResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageEditEraseResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason), TypeInfoPropertyName = "CreateStableImageEditInpaintResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageEditInpaintResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageEditInpaintResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason), TypeInfoPropertyName = "CreateStableImageEditOutpaintResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageEditOutpaintResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageEditOutpaintResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason), TypeInfoPropertyName = "CreateStableImageEditRemoveBackgroundResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageEditRemoveBackgroundResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponseFinishReason), TypeInfoPropertyName = "CreateStableImageGenerateUltraResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageGenerateUltraResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageGenerateUltraResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateUltraResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponseFinishReason), TypeInfoPropertyName = "CreateStableImageGenerateCoreResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageGenerateCoreResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageGenerateCoreResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateCoreResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3ResponseFinishReason), TypeInfoPropertyName = "CreateStableImageGenerateSd3ResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3ResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageGenerateSd3ResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3ResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageGenerateSd3ResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageGenerateSd3Response8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponseFinishReason), TypeInfoPropertyName = "CreateStableImageControlSketchResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageControlSketchResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageControlSketchResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlSketchResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponseFinishReason), TypeInfoPropertyName = "CreateStableImageControlStructureResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageControlStructureResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageControlStructureResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStructureResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponseFinishReason), TypeInfoPropertyName = "CreateStableImageControlStyleResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageControlStyleResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageControlStyleResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason), TypeInfoPropertyName = "CreateStableImageControlStyleTransferResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason2), TypeInfoPropertyName = "CreateStableImageControlStyleTransferResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason3), TypeInfoPropertyName = "CreateStableImageControlStyleTransferResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageControlStyleTransferResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.TextPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.Engine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StabilityAI.Image>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}