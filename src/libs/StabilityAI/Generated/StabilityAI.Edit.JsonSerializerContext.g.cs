
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName), TypeInfoPropertyName = "ContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseAccept), TypeInfoPropertyName = "CreateStableImageEditEraseAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintAccept), TypeInfoPropertyName = "CreateStableImageEditInpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintAccept), TypeInfoPropertyName = "CreateStableImageEditOutpaintAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceAccept), TypeInfoPropertyName = "CreateStableImageEditSearchAndReplaceAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorAccept), TypeInfoPropertyName = "CreateStableImageEditSearchAndRecolorAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept), TypeInfoPropertyName = "CreateStableImageEditRemoveBackgroundAccept2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.ContentModerationResponseName?), TypeInfoPropertyName = "NullableContentModerationResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditEraseRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditInpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset?), TypeInfoPropertyName = "NullableCreateStableImageEditInpaintRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.AllOf<double?, object>?), TypeInfoPropertyName = "NullableAllOfDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditOutpaintRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset?), TypeInfoPropertyName = "NullableCreateStableImageEditOutpaintRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndReplaceRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestStylePreset?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndReplaceRequestStylePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndRecolorRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestStylePreset?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndRecolorRequestStylePreset2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason?), TypeInfoPropertyName = "NullableCreateStableImageEditEraseResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason2?), TypeInfoPropertyName = "NullableCreateStableImageEditEraseResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason3?), TypeInfoPropertyName = "NullableCreateStableImageEditEraseResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason?), TypeInfoPropertyName = "NullableCreateStableImageEditInpaintResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason2?), TypeInfoPropertyName = "NullableCreateStableImageEditInpaintResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason3?), TypeInfoPropertyName = "NullableCreateStableImageEditInpaintResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason?), TypeInfoPropertyName = "NullableCreateStableImageEditOutpaintResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason2?), TypeInfoPropertyName = "NullableCreateStableImageEditOutpaintResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason3?), TypeInfoPropertyName = "NullableCreateStableImageEditOutpaintResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndReplaceResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason2?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndReplaceResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason3?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndReplaceResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndRecolorResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason2?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndRecolorResponseFinishReason22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason3?), TypeInfoPropertyName = "NullableCreateStableImageEditSearchAndRecolorResponseFinishReason32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason?), TypeInfoPropertyName = "NullableCreateStableImageEditRemoveBackgroundResponseFinishReason2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason2?), TypeInfoPropertyName = "NullableCreateStableImageEditRemoveBackgroundResponseFinishReason22")]
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

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestStylePreset)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestStylePreset?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestStylePreset)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestStylePreset?)

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

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundAccept?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason2)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason2?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason3)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason3?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason2)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason2?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason3)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason3?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason2)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason2?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason3)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason3?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason2)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason2?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason3)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason3?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason2)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason2?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason3)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason3?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason?)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason2)

                    || typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason2?);
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

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestStylePresetJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintRequestStylePresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestStylePresetJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintRequestStylePresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestStylePreset))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestStylePresetJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceRequestStylePreset?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceRequestStylePresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestOutputFormat?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestStylePreset))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestStylePresetJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorRequestStylePreset?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorRequestStylePresetNullableJsonConverter();
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

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason2))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason2JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason2?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason3))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason3JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditEraseResponseFinishReason3?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditEraseResponseFinishReason3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason2))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason2JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason2?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason3))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason3JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditInpaintResponseFinishReason3?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditInpaintResponseFinishReason3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason2))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason2JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason2?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason3))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason3JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditOutpaintResponseFinishReason3?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditOutpaintResponseFinishReason3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason2))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason2JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason2?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason3))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason3JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndReplaceResponseFinishReason3?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndReplaceResponseFinishReason3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason2))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason2JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason2?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason3))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason3JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditSearchAndRecolorResponseFinishReason3?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditSearchAndRecolorResponseFinishReason3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason2))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReason2JsonConverter();
                }

                if (typeToConvert == typeof(global::StabilityAI.CreateStableImageEditRemoveBackgroundResponseFinishReason2?))
                {
                    return new global::StabilityAI.JsonConverters.CreateStableImageEditRemoveBackgroundResponseFinishReason2NullableJsonConverter();
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