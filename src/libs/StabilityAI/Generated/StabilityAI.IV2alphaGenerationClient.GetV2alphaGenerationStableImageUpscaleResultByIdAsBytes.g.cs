#nullable enable

namespace StabilityAI
{
    public partial interface IV2alphaGenerationClient
    {
        /// <summary>
        /// stable-image/upscale/result<br/>
        /// Fetch the result of an upscale generation by ID. Make sure to use the same API key to fetch the generation result<br/>
        /// that you used to create the generation, otherwise you will receive a `404` response.<br/>
        /// ### How is progress reported?<br/>
        /// Your generation is either `in-progress` (i.e. status code `202`) or it is complete (i.e. status code `200`). <br/>
        /// We may add more fine-grained progress reporting in the future (e.g. a numerical progress).<br/>
        /// ### How long are results stored?<br/>
        /// Results are stored for 24 hours after generation. After that, the results are deleted.
        /// </summary>
        /// <param name="id">
        /// The `id` of a generation, typically used for async generations, that can be used to check the status of the generation or retrieve the result.<br/>
        /// Example: a6dc6c6e20acda010fe14d71f180658f2896ed9b4ec25aa99a6ff06c796987c4
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// generation_id = "e52772ac75b..."<br/>
        /// response = requests.request(<br/>
        ///     "GET",<br/>
        ///     f"https://api.stability.ai/v2alpha/generation/stable-image/upscale/result/{generation_id}",<br/>
        ///     headers={<br/>
        ///         'Accept': "image/*",  # Use 'application/json' to receive base64 encoded JSON<br/>
        ///         'authorization': f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 202:<br/>
        ///     print("Generation in-progress, try again in 10 seconds.")<br/>
        /// elif response.status_code == 200:<br/>
        ///     print("Generation complete!")<br/>
        ///     with open("upscaled.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> GetV2alphaGenerationStableImageUpscaleResultByIdAsBytesAsync(
            string id,
            global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// stable-image/upscale/result<br/>
        /// Fetch the result of an upscale generation by ID. Make sure to use the same API key to fetch the generation result<br/>
        /// that you used to create the generation, otherwise you will receive a `404` response.<br/>
        /// ### How is progress reported?<br/>
        /// Your generation is either `in-progress` (i.e. status code `202`) or it is complete (i.e. status code `200`). <br/>
        /// We may add more fine-grained progress reporting in the future (e.g. a numerical progress).<br/>
        /// ### How long are results stored?<br/>
        /// Results are stored for 24 hours after generation. After that, the results are deleted.
        /// </summary>
        /// <param name="id">
        /// The `id` of a generation, typically used for async generations, that can be used to check the status of the generation or retrieve the result.<br/>
        /// Example: a6dc6c6e20acda010fe14d71f180658f2896ed9b4ec25aa99a6ff06c796987c4
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// generation_id = "e52772ac75b..."<br/>
        /// response = requests.request(<br/>
        ///     "GET",<br/>
        ///     f"https://api.stability.ai/v2alpha/generation/stable-image/upscale/result/{generation_id}",<br/>
        ///     headers={<br/>
        ///         'Accept': "image/*",  # Use 'application/json' to receive base64 encoded JSON<br/>
        ///         'authorization': f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 202:<br/>
        ///     print("Generation in-progress, try again in 10 seconds.")<br/>
        /// elif response.status_code == 200:<br/>
        ///     print("Generation complete!")<br/>
        ///     with open("upscaled.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetV2alphaGenerationStableImageUpscaleResultByIdAsBytesAsStreamAsync(
            string id,
            global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// stable-image/upscale/result<br/>
        /// Fetch the result of an upscale generation by ID. Make sure to use the same API key to fetch the generation result<br/>
        /// that you used to create the generation, otherwise you will receive a `404` response.<br/>
        /// ### How is progress reported?<br/>
        /// Your generation is either `in-progress` (i.e. status code `202`) or it is complete (i.e. status code `200`). <br/>
        /// We may add more fine-grained progress reporting in the future (e.g. a numerical progress).<br/>
        /// ### How long are results stored?<br/>
        /// Results are stored for 24 hours after generation. After that, the results are deleted.
        /// </summary>
        /// <param name="id">
        /// The `id` of a generation, typically used for async generations, that can be used to check the status of the generation or retrieve the result.<br/>
        /// Example: a6dc6c6e20acda010fe14d71f180658f2896ed9b4ec25aa99a6ff06c796987c4
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// generation_id = "e52772ac75b..."<br/>
        /// response = requests.request(<br/>
        ///     "GET",<br/>
        ///     f"https://api.stability.ai/v2alpha/generation/stable-image/upscale/result/{generation_id}",<br/>
        ///     headers={<br/>
        ///         'Accept': "image/*",  # Use 'application/json' to receive base64 encoded JSON<br/>
        ///         'authorization': f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 202:<br/>
        ///     print("Generation in-progress, try again in 10 seconds.")<br/>
        /// elif response.status_code == 200:<br/>
        ///     print("Generation complete!")<br/>
        ///     with open("upscaled.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> GetV2alphaGenerationStableImageUpscaleResultByIdAsBytesAsResponseAsync(
            string id,
            global::StabilityAI.GetV2alphaGenerationStableImageUpscaleResultAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}