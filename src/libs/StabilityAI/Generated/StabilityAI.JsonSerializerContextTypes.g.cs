
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace StabilityAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Engine? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.EngineType? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Error? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ClipGuidancePreset? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Sampler? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.TextPrompt? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::StabilityAI.TextPrompt>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InitImageMode? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GenerationRequestOptionalParams? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.UpscaleImageRequestBody? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageRequestBody? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageRequestBodyDiscriminator? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageRequestBodyDiscriminatorInitImageMode? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageUsingImageStrengthRequestBody? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageUsingImageStrengthRequestBodyVariant1? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageUsingStepScheduleRequestBody? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageUsingStepScheduleRequestBodyVariant1? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingRequestBody? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingRequestBodyDiscriminator? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingRequestBodyDiscriminatorMaskSource? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingUsingMaskImageRequestBody? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingUsingMaskImageRequestBodyVariant1? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingUsingInitImageAlphaRequestBody? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingUsingInitImageAlphaRequestBodyVariant1? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.TextToImageRequestBody? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.TextToImageRequestBodyVariant1? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AccountResponseBody? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::StabilityAI.OrganizationMembership>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.OrganizationMembership? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.BalanceResponseBody? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::StabilityAI.Engine>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FinishReason? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Image? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageFinishReason? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ContentModerationResponse? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ContentModerationResponseName? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingSearchModeRequestBody? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingSearchModeRequestBodyMode? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingMaskingModeRequestBody? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingMaskingModeRequestBodyMode? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FalGenerationResponse? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequest? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestStylePreset? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminator? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dRequestTextureResolution? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dRequestRemesh? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequestRemesh? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequestTargetType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintRequestModel? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeRequestStylePreset? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AllOf<double?, object>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestStylePreset? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorRequest? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestStylePreset? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundRequest? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraRequest? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraRequestAspectRatio? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraRequestStylePreset? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreRequest? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreRequestAspectRatio? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreRequestStylePreset? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Request? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestMode? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestModel? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestStylePreset? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchRequest? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchRequestStylePreset? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureRequest? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureRequestStylePreset? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleRequest? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleRequestAspectRatio? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleRequestStylePreset? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.TextToImageAccept? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageAccept? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.UpscaleImageAccept? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingAccept? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsAccept? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintAccept? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintAccept? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultAccept? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeAccept? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultAccept? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastAccept? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseAccept? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintAccept? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintAccept? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraAccept? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreAccept? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Accept? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchAccept? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureAccept? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleAccept? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferAccept? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::StabilityAI.Image>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleResponse2? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleResponse3? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse2? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason2? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse3? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseFinishReason3? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse4? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse5? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse6? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse7? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponseFinishReason? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse2? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponseFinishReason2? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse3? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponseFinishReason3? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse4? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse5? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dResponse2? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dResponse3? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dResponse4? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dResponse2? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dResponse3? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dResponse4? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponseFinishReason? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse2? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponseFinishReason2? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse3? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponseFinishReason3? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse4? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponseStatus? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse5? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse6? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse7? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponseFinishReason? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse2? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponseFinishReason2? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse3? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse4? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse5? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioResponse6? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponseFinishReason? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse2? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponseFinishReason2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse3? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse4? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse5? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioResponse6? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponseFinishReason? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponse2? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponseFinishReason2? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponse3? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponse4? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponse5? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintResponse6? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioResponse2? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioResponse3? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioResponse4? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioResponse5? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse2? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse3? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse4? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioResponse5? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintResponse2? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintResponse3? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintResponse4? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintResponse5? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponse? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponseFinishReason? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponse2? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponseFinishReason2? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponse3? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponseStatus? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponse4? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponse5? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponse6? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponseFinishReason? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse2? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponseFinishReason2? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse3? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponseFinishReason3? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse4? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse5? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse6? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse7? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeResponse8? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeResponse? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeResponse2? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeResponse3? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeResponse4? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeResponse5? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeResponse6? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse2? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason2? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse3? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponseFinishReason3? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse4? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponseStatus? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse5? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse6? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse7? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponseFinishReason? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse2? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponseFinishReason2? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse3? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponseFinishReason3? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse4? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse5? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse6? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse7? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastResponse8? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponseFinishReason? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponse2? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponseFinishReason2? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponse3? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponseFinishReason3? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponse4? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponse5? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponse6? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseResponse7? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse2? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason2? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse3? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason3? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse4? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse5? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse6? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse7? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintResponse8? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse2? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason2? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse3? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason3? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse4? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse5? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse6? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse7? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintResponse8? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse2? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason2? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse3? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason3? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse4? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse5? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse6? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse7? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceResponse8? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse2? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason2? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse3? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason3? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse4? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse5? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse6? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse7? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorResponse8? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse2? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason2? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse3? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse4? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse5? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundResponse6? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponseFinishReason? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse2? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponseFinishReason2? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse3? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponseFinishReason3? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse4? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse5? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse6? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse7? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraResponse8? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponse? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponseFinishReason? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponse2? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponseFinishReason2? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponse3? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponseFinishReason3? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponse4? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponse5? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponse6? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreResponse7? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3ResponseFinishReason? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response2? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3ResponseFinishReason2? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response3? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3ResponseFinishReason3? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response4? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response5? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response6? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response7? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Response8? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponseFinishReason? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse2? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponseFinishReason2? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse3? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponseFinishReason3? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse4? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse5? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse6? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse7? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchResponse8? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponseFinishReason? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse2? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponseFinishReason2? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse3? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponseFinishReason3? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse4? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse5? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse6? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse7? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureResponse8? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponseFinishReason? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse2? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponseFinishReason2? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse3? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponseFinishReason3? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse4? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse5? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse6? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse7? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleResponse8? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse2? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse3? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponseFinishReason3? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse4? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse5? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse6? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse7? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferResponse8? Type438 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.TextPrompt>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.OrganizationMembership>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.Engine>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.Image>? ListType4 { get; set; }
    }
}