
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
        public global::System.Collections.Generic.IList<string>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ClipGuidancePreset? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Sampler? Type8 { get; set; }
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
        public global::StabilityAI.ImageJSONResponse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AllOf<double?, object>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageJSONResponseFinishReason? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AudioJSONResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AudioJSONResponseFinishReason? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AsyncGenerationResponse? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.StylePreset? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingSearchModeRequestBody? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingSearchModeRequestBodyMode? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingSearchModeRequestBodyOutputFormat? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingMaskingModeRequestBody? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingMaskingModeRequestBodyMode? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.InpaintingMaskingModeRequestBodyOutputFormat? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AspectRatio? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequest? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageUpscaleRequestOutputFormat? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminator? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequestDiscriminatorMode? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dRequestTextureResolution? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStableFast3dRequestRemesh? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequestRemesh? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.Create3dStablePointAware3dRequestTargetType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestModel? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioRequestOutputFormat? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestModel? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioRequestOutputFormat? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestModel? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioRequestOutputFormat? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintRequestModel? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintRequestOutputFormat? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeRequest? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastRequestOutputFormat? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat? Type100 { get; set; }
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
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundRequestOutputFormat? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreRequestOutputFormat? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Request? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.AllOf<string, object>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestMode? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestModel? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureRequestOutputFormat? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleRequestOutputFormat? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferRequest? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferRequestOutputFormat? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.TextToImageAccept? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.ImageToImageAccept? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.UpscaleImageAccept? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.MaskingAccept? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsAccept? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2TextToAudioAccept? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2AudioToAudioAccept? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudio2InpaintAccept? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioAudioToAudioAccept? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateAudioStableAudioInpaintAccept? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultAccept? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleConservativeAccept? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultAccept? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleFastAccept? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditEraseAccept? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditInpaintAccept? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditOutpaintAccept? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateUltraAccept? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateCoreAccept? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageGenerateSd3Accept? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlSketchAccept? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStructureAccept? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleAccept? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageControlStyleTransferAccept? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::StabilityAI.Image>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultResponseStatus? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetResultsResponseStatus? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.FetchAudioResultResponseStatus? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.CreateStableImageUpscaleCreativeResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::StabilityAI.GetStableImageUpscaleCreativeResultResponseStatus? Type166 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.TextPrompt>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.OrganizationMembership>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.Engine>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.Image>? ListType4 { get; set; }
    }
}