#nullable enable

namespace StabilityAI
{
    public partial interface IV2alphaGenerationClient
    {
        /// <summary>
        /// stable-image/inpaint<br/>
        /// Inpaint an existing image, with or without a mask, using our latest-and-greatest inpainting model.<br/>
        /// ### Search-and-Replace Mode<br/>
        /// This mode is ideal for individuals of all levels of skill in design. It can be used for straightforward<br/>
        /// adjustments to images. The service will automatically mask the most appropriate object based on the contents<br/>
        /// of the `search_prompt`, and replace it with a generated result based on the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `search` and provide a short description of what to<br/>
        /// search-and-replace in the `search_prompt` parameter.<br/>
        /// ### Mask Mode<br/>
        /// This mode allows for precise control of generative fill tasks on an image, down to the level of<br/>
        /// individual pixels. Design professionals can provide a `mask` for the section of the image to be replaced,<br/>
        /// and use standard image prompting to describe the full image as it should appear after the editing.<br/>
        /// The resulting image will incorporate all of the elements described in the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `mask` and either pass in an `image` with an alpha channel<br/>
        /// or provide an explicit mask image to the `mask` parameter. If both are present the `mask` parameter will<br/>
        /// take precedence.<br/>
        /// ### Price<br/>
        /// - Requests with `mode` set to `search` cost 4 cents.<br/>
        /// - Requests with `mode` set to `mask` cost 3 cents.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2alpha/generation/stable-image/inpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "golden retriever in a field",<br/>
        ///         "mode": "search",<br/>
        ///         "search_prompt": "dog",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./golden-retriever-in-a-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> CreateV2alphaGenerationStableImageInpaintAsBytesAsync(
            string contentType,

            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest request,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// stable-image/inpaint<br/>
        /// Inpaint an existing image, with or without a mask, using our latest-and-greatest inpainting model.<br/>
        /// ### Search-and-Replace Mode<br/>
        /// This mode is ideal for individuals of all levels of skill in design. It can be used for straightforward<br/>
        /// adjustments to images. The service will automatically mask the most appropriate object based on the contents<br/>
        /// of the `search_prompt`, and replace it with a generated result based on the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `search` and provide a short description of what to<br/>
        /// search-and-replace in the `search_prompt` parameter.<br/>
        /// ### Mask Mode<br/>
        /// This mode allows for precise control of generative fill tasks on an image, down to the level of<br/>
        /// individual pixels. Design professionals can provide a `mask` for the section of the image to be replaced,<br/>
        /// and use standard image prompting to describe the full image as it should appear after the editing.<br/>
        /// The resulting image will incorporate all of the elements described in the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `mask` and either pass in an `image` with an alpha channel<br/>
        /// or provide an explicit mask image to the `mask` parameter. If both are present the `mask` parameter will<br/>
        /// take precedence.<br/>
        /// ### Price<br/>
        /// - Requests with `mode` set to `search` cost 4 cents.<br/>
        /// - Requests with `mode` set to `mask` cost 3 cents.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2alpha/generation/stable-image/inpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "golden retriever in a field",<br/>
        ///         "mode": "search",<br/>
        ///         "search_prompt": "dog",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./golden-retriever-in-a-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateV2alphaGenerationStableImageInpaintAsBytesAsStreamAsync(
            string contentType,

            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest request,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// stable-image/inpaint<br/>
        /// Inpaint an existing image, with or without a mask, using our latest-and-greatest inpainting model.<br/>
        /// ### Search-and-Replace Mode<br/>
        /// This mode is ideal for individuals of all levels of skill in design. It can be used for straightforward<br/>
        /// adjustments to images. The service will automatically mask the most appropriate object based on the contents<br/>
        /// of the `search_prompt`, and replace it with a generated result based on the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `search` and provide a short description of what to<br/>
        /// search-and-replace in the `search_prompt` parameter.<br/>
        /// ### Mask Mode<br/>
        /// This mode allows for precise control of generative fill tasks on an image, down to the level of<br/>
        /// individual pixels. Design professionals can provide a `mask` for the section of the image to be replaced,<br/>
        /// and use standard image prompting to describe the full image as it should appear after the editing.<br/>
        /// The resulting image will incorporate all of the elements described in the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `mask` and either pass in an `image` with an alpha channel<br/>
        /// or provide an explicit mask image to the `mask` parameter. If both are present the `mask` parameter will<br/>
        /// take precedence.<br/>
        /// ### Price<br/>
        /// - Requests with `mode` set to `search` cost 4 cents.<br/>
        /// - Requests with `mode` set to `mask` cost 3 cents.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2alpha/generation/stable-image/inpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "golden retriever in a field",<br/>
        ///         "mode": "search",<br/>
        ///         "search_prompt": "dog",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./golden-retriever-in-a-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> CreateV2alphaGenerationStableImageInpaintAsBytesAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest request,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// stable-image/inpaint<br/>
        /// Inpaint an existing image, with or without a mask, using our latest-and-greatest inpainting model.<br/>
        /// ### Search-and-Replace Mode<br/>
        /// This mode is ideal for individuals of all levels of skill in design. It can be used for straightforward<br/>
        /// adjustments to images. The service will automatically mask the most appropriate object based on the contents<br/>
        /// of the `search_prompt`, and replace it with a generated result based on the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `search` and provide a short description of what to<br/>
        /// search-and-replace in the `search_prompt` parameter.<br/>
        /// ### Mask Mode<br/>
        /// This mode allows for precise control of generative fill tasks on an image, down to the level of<br/>
        /// individual pixels. Design professionals can provide a `mask` for the section of the image to be replaced,<br/>
        /// and use standard image prompting to describe the full image as it should appear after the editing.<br/>
        /// The resulting image will incorporate all of the elements described in the `prompt`.<br/>
        /// **How to use:** set the `mode` parameter to `mask` and either pass in an `image` with an alpha channel<br/>
        /// or provide an explicit mask image to the `mask` parameter. If both are present the `mask` parameter will<br/>
        /// take precedence.<br/>
        /// ### Price<br/>
        /// - Requests with `mode` set to `search` cost 4 cents.<br/>
        /// - Requests with `mode` set to `mask` cost 3 cents.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to get the image bytes directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateV2alphaGenerationStableImageInpaintAsBytesAsync(
            string contentType,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}