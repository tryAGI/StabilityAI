#nullable enable

namespace StabilityAI
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Stable Image Ultra<br/>
        /// Our most advanced text to image generation service, Stable Image Ultra creates the highest quality images<br/>
        /// with unprecedented prompt understanding. Ultra excels in typography, complex compositions, dynamic lighting,<br/>
        /// vibrant hues, and overall cohesion and structure of an art piece. Made from the most advanced models,<br/>
        /// including Stable Diffusion 3.5, Ultra offers the best of the Stable Diffusion ecosystem.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=yXhs626oZdr1)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.  The accept header should be set to one of the following:<br/>
        /// - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the image in the format specified by the `output_format` parameter, but encoded to base64 in a JSON response.<br/>
        /// The only required parameter is the `prompt` field, which should contain the text prompt for the image generation.<br/>
        /// The body of the request should include:<br/>
        /// - `prompt` - text to generate the image from<br/>
        /// The body may optionally include:<br/>
        /// - `image` - the image to use as the starting point for the generation<br/>
        /// - `strength` - controls how much influence the `image` parameter has on the output image<br/>
        /// - `aspect_ratio` - the aspect ratio of the output image<br/>
        /// - `negative_prompt` - keywords of what you **do not** wish to see in the output image<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `output_format` - the format of the output image<br/>
        /// &gt; **Note:** for the full list of optional parameters, please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 1 megapixel. The default resolution is 1024x1024.<br/>
        /// ### Credits<br/>
        /// The Ultra service uses 8 credits per successful result. You will not be charged for failed results.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="stabilityClientId">
        /// The name of your application, used to help us communicate app-specific debugging or moderation issues to you.<br/>
        /// Example: my-awesome-app
        /// </param>
        /// <param name="stabilityClientUserId">
        /// A unique identifier for your end user. Used to help us communicate user-specific debugging or moderation issues to you. Feel free to obfuscate this value to protect user privacy.<br/>
        /// Example: DiscordUser#9999
        /// </param>
        /// <param name="stabilityClientVersion">
        /// The version of your application, used to help us communicate version-specific debugging or moderation issues to you.<br/>
        /// Example: 1.2.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/generate/ultra",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={"none": ''},<br/>
        ///     data={<br/>
        ///         "prompt": "Lighthouse on a cliff overlooking the ocean",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./lighthouse.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> CreateStableImageGenerateUltraAsBytesAsync(
            string contentType,

            global::StabilityAI.CreateStableImageGenerateUltraRequest request,
            global::StabilityAI.CreateStableImageGenerateUltraAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Image Ultra<br/>
        /// Our most advanced text to image generation service, Stable Image Ultra creates the highest quality images<br/>
        /// with unprecedented prompt understanding. Ultra excels in typography, complex compositions, dynamic lighting,<br/>
        /// vibrant hues, and overall cohesion and structure of an art piece. Made from the most advanced models,<br/>
        /// including Stable Diffusion 3.5, Ultra offers the best of the Stable Diffusion ecosystem.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=yXhs626oZdr1)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.  The accept header should be set to one of the following:<br/>
        /// - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the image in the format specified by the `output_format` parameter, but encoded to base64 in a JSON response.<br/>
        /// The only required parameter is the `prompt` field, which should contain the text prompt for the image generation.<br/>
        /// The body of the request should include:<br/>
        /// - `prompt` - text to generate the image from<br/>
        /// The body may optionally include:<br/>
        /// - `image` - the image to use as the starting point for the generation<br/>
        /// - `strength` - controls how much influence the `image` parameter has on the output image<br/>
        /// - `aspect_ratio` - the aspect ratio of the output image<br/>
        /// - `negative_prompt` - keywords of what you **do not** wish to see in the output image<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `output_format` - the format of the output image<br/>
        /// &gt; **Note:** for the full list of optional parameters, please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 1 megapixel. The default resolution is 1024x1024.<br/>
        /// ### Credits<br/>
        /// The Ultra service uses 8 credits per successful result. You will not be charged for failed results.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="stabilityClientId">
        /// The name of your application, used to help us communicate app-specific debugging or moderation issues to you.<br/>
        /// Example: my-awesome-app
        /// </param>
        /// <param name="stabilityClientUserId">
        /// A unique identifier for your end user. Used to help us communicate user-specific debugging or moderation issues to you. Feel free to obfuscate this value to protect user privacy.<br/>
        /// Example: DiscordUser#9999
        /// </param>
        /// <param name="stabilityClientVersion">
        /// The version of your application, used to help us communicate version-specific debugging or moderation issues to you.<br/>
        /// Example: 1.2.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/generate/ultra",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={"none": ''},<br/>
        ///     data={<br/>
        ///         "prompt": "Lighthouse on a cliff overlooking the ocean",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./lighthouse.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateStableImageGenerateUltraAsBytesAsStreamAsync(
            string contentType,

            global::StabilityAI.CreateStableImageGenerateUltraRequest request,
            global::StabilityAI.CreateStableImageGenerateUltraAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Image Ultra<br/>
        /// Our most advanced text to image generation service, Stable Image Ultra creates the highest quality images<br/>
        /// with unprecedented prompt understanding. Ultra excels in typography, complex compositions, dynamic lighting,<br/>
        /// vibrant hues, and overall cohesion and structure of an art piece. Made from the most advanced models,<br/>
        /// including Stable Diffusion 3.5, Ultra offers the best of the Stable Diffusion ecosystem.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=yXhs626oZdr1)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.  The accept header should be set to one of the following:<br/>
        /// - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the image in the format specified by the `output_format` parameter, but encoded to base64 in a JSON response.<br/>
        /// The only required parameter is the `prompt` field, which should contain the text prompt for the image generation.<br/>
        /// The body of the request should include:<br/>
        /// - `prompt` - text to generate the image from<br/>
        /// The body may optionally include:<br/>
        /// - `image` - the image to use as the starting point for the generation<br/>
        /// - `strength` - controls how much influence the `image` parameter has on the output image<br/>
        /// - `aspect_ratio` - the aspect ratio of the output image<br/>
        /// - `negative_prompt` - keywords of what you **do not** wish to see in the output image<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `output_format` - the format of the output image<br/>
        /// &gt; **Note:** for the full list of optional parameters, please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 1 megapixel. The default resolution is 1024x1024.<br/>
        /// ### Credits<br/>
        /// The Ultra service uses 8 credits per successful result. You will not be charged for failed results.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="stabilityClientId">
        /// The name of your application, used to help us communicate app-specific debugging or moderation issues to you.<br/>
        /// Example: my-awesome-app
        /// </param>
        /// <param name="stabilityClientUserId">
        /// A unique identifier for your end user. Used to help us communicate user-specific debugging or moderation issues to you. Feel free to obfuscate this value to protect user privacy.<br/>
        /// Example: DiscordUser#9999
        /// </param>
        /// <param name="stabilityClientVersion">
        /// The version of your application, used to help us communicate version-specific debugging or moderation issues to you.<br/>
        /// Example: 1.2.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/generate/ultra",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={"none": ''},<br/>
        ///     data={<br/>
        ///         "prompt": "Lighthouse on a cliff overlooking the ocean",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./lighthouse.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> CreateStableImageGenerateUltraAsBytesAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageGenerateUltraRequest request,
            global::StabilityAI.CreateStableImageGenerateUltraAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Image Ultra<br/>
        /// Our most advanced text to image generation service, Stable Image Ultra creates the highest quality images<br/>
        /// with unprecedented prompt understanding. Ultra excels in typography, complex compositions, dynamic lighting,<br/>
        /// vibrant hues, and overall cohesion and structure of an art piece. Made from the most advanced models,<br/>
        /// including Stable Diffusion 3.5, Ultra offers the best of the Stable Diffusion ecosystem.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=yXhs626oZdr1)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.  The accept header should be set to one of the following:<br/>
        /// - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the image in the format specified by the `output_format` parameter, but encoded to base64 in a JSON response.<br/>
        /// The only required parameter is the `prompt` field, which should contain the text prompt for the image generation.<br/>
        /// The body of the request should include:<br/>
        /// - `prompt` - text to generate the image from<br/>
        /// The body may optionally include:<br/>
        /// - `image` - the image to use as the starting point for the generation<br/>
        /// - `strength` - controls how much influence the `image` parameter has on the output image<br/>
        /// - `aspect_ratio` - the aspect ratio of the output image<br/>
        /// - `negative_prompt` - keywords of what you **do not** wish to see in the output image<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `output_format` - the format of the output image<br/>
        /// &gt; **Note:** for the full list of optional parameters, please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 1 megapixel. The default resolution is 1024x1024.<br/>
        /// ### Credits<br/>
        /// The Ultra service uses 8 credits per successful result. You will not be charged for failed results.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `image/*` to receive the bytes of the image directly. Otherwise specify `application/json` to receive the image as base64 encoded JSON.<br/>
        /// Default Value: image/*
        /// </param>
        /// <param name="stabilityClientId">
        /// The name of your application, used to help us communicate app-specific debugging or moderation issues to you.<br/>
        /// Example: my-awesome-app
        /// </param>
        /// <param name="stabilityClientUserId">
        /// A unique identifier for your end user. Used to help us communicate user-specific debugging or moderation issues to you. Feel free to obfuscate this value to protect user privacy.<br/>
        /// Example: DiscordUser#9999
        /// </param>
        /// <param name="stabilityClientVersion">
        /// The version of your application, used to help us communicate version-specific debugging or moderation issues to you.<br/>
        /// Example: 1.2.1
        /// </param>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </param>
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="aspectRatio">
        /// Controls the aspect ratio of the generated image.<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="image">
        /// The image to use as the starting point for the generation.<br/>
        /// &gt; **Important:** The `strength` parameter is required when `image` is provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,384 pixels<br/>
        /// - Height must be between 64 and 16,384 pixels<br/>
        /// - Total pixel count must be at least 4,096 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image to use as the starting point for the generation.<br/>
        /// &gt; **Important:** The `strength` parameter is required when `image` is provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Width must be between 64 and 16,384 pixels<br/>
        /// - Height must be between 64 and 16,384 pixels<br/>
        /// - Total pixel count must be at least 4,096 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="strength">
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the <br/>
        /// `image` parameter has on the generated image.  A value of 0 would yield an image that <br/>
        /// is identical to the input.  A value of 1 would be as if you passed in no image at all.<br/>
        /// &gt; **Important:** This parameter is required when `image` is provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateStableImageGenerateUltraAsBytesAsync(
            string contentType,
            string prompt,
            global::StabilityAI.CreateStableImageGenerateUltraAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            global::StabilityAI.CreateStableImageGenerateUltraRequestAspectRatio? aspectRatio = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageGenerateUltraRequestOutputFormat? outputFormat = default,
            byte[]? image = default,
            string? imagename = default,
            global::StabilityAI.CreateStableImageGenerateUltraRequestStylePreset? stylePreset = default,
            double? strength = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}