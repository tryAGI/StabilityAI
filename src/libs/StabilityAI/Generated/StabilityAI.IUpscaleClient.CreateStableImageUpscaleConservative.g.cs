#nullable enable

namespace StabilityAI
{
    public partial interface IUpscaleClient
    {
        /// <summary>
        /// Conservative<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to 4K resolution. Put more generally, it can upscale images ~20-40x times while preserving all aspects. Conservative Upscale minimizes alterations to the image and should not be used to reimagine an image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=t1Q4w2uvvza0)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 40 credits per successful generation.  You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/conservative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./low-res-flower.jpg", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a flower",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./flower.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageUpscaleConservativeResponse> CreateStableImageUpscaleConservativeAsync(
            string contentType,

            global::StabilityAI.CreateStableImageUpscaleConservativeRequest request,
            global::StabilityAI.CreateStableImageUpscaleConservativeAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Conservative<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to 4K resolution. Put more generally, it can upscale images ~20-40x times while preserving all aspects. Conservative Upscale minimizes alterations to the image and should not be used to reimagine an image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=t1Q4w2uvvza0)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 40 credits per successful generation.  You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/conservative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./low-res-flower.jpg", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a flower",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./flower.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageUpscaleConservativeResponse>> CreateStableImageUpscaleConservativeAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageUpscaleConservativeRequest request,
            global::StabilityAI.CreateStableImageUpscaleConservativeAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Conservative<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to 4K resolution. Put more generally, it can upscale images ~20-40x times while preserving all aspects. Conservative Upscale minimizes alterations to the image and should not be used to reimagine an image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=t1Q4w2uvvza0)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 40 credits per successful generation.  You will not be charged for failed generations.
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
        /// <param name="image">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
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
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="creativity">
        /// Controls the likelihood of creating additional details not heavily conditioned by the init image.<br/>
        /// Default Value: 0.35F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageUpscaleConservativeResponse> CreateStableImageUpscaleConservativeAsync(
            string contentType,
            byte[] image,
            string imagename,
            string prompt,
            global::StabilityAI.CreateStableImageUpscaleConservativeAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat? outputFormat = default,
            double? creativity = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Conservative<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to 4K resolution. Put more generally, it can upscale images ~20-40x times while preserving all aspects. Conservative Upscale minimizes alterations to the image and should not be used to reimagine an image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=t1Q4w2uvvza0)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 40 credits per successful generation.  You will not be charged for failed generations.
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
        /// <param name="image">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
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
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="creativity">
        /// Controls the likelihood of creating additional details not heavily conditioned by the init image.<br/>
        /// Default Value: 0.35F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/conservative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./low-res-flower.jpg", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a flower",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./flower.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageUpscaleConservativeResponse> CreateStableImageUpscaleConservativeAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            global::StabilityAI.CreateStableImageUpscaleConservativeAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat? outputFormat = default,
            double? creativity = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Conservative<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to 4K resolution. Put more generally, it can upscale images ~20-40x times while preserving all aspects. Conservative Upscale minimizes alterations to the image and should not be used to reimagine an image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=t1Q4w2uvvza0)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 40 credits per successful generation.  You will not be charged for failed generations.
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
        /// <param name="image">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to upscale.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// - The aspect ratio must be between 1:2.5 and 2.5:1<br/>
        /// Example: ./some/image.png
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
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="creativity">
        /// Controls the likelihood of creating additional details not heavily conditioned by the init image.<br/>
        /// Default Value: 0.35F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/conservative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./low-res-flower.jpg", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a flower",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./flower.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageUpscaleConservativeResponse>> CreateStableImageUpscaleConservativeAsResponseAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            global::StabilityAI.CreateStableImageUpscaleConservativeAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageUpscaleConservativeRequestOutputFormat? outputFormat = default,
            double? creativity = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}