#nullable enable

namespace StabilityAI
{
    public partial interface IUpscaleClient
    {
        /// <summary>
        /// Creative Upscale (async)<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to **4K** resolution.  Put more<br/>
        /// generally, it can upscale images ~20-40x times while preserving, and often enhancing, quality.<br/>
        /// Creative Upscale **works best on highly degraded images and is not for photos of 1mp or above** as it performs<br/>
        /// heavy reimagining (controlled by creativity scale).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=QXxi9tfI425t)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `seed`<br/>
        /// - `negative_prompt`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 60 credits per successful generation.  You will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/creative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./kitten-in-space.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "cute fluffy white kitten floating in space, pastel colors",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageUpscaleCreativeResponse> CreateStableImageUpscaleCreativeAsync(
            string contentType,

            global::StabilityAI.CreateStableImageUpscaleCreativeRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creative Upscale (async)<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to **4K** resolution.  Put more<br/>
        /// generally, it can upscale images ~20-40x times while preserving, and often enhancing, quality.<br/>
        /// Creative Upscale **works best on highly degraded images and is not for photos of 1mp or above** as it performs<br/>
        /// heavy reimagining (controlled by creativity scale).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=QXxi9tfI425t)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `seed`<br/>
        /// - `negative_prompt`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 60 credits per successful generation.  You will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/creative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./kitten-in-space.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "cute fluffy white kitten floating in space, pastel colors",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageUpscaleCreativeResponse>> CreateStableImageUpscaleCreativeAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageUpscaleCreativeRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creative Upscale (async)<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to **4K** resolution.  Put more<br/>
        /// generally, it can upscale images ~20-40x times while preserving, and often enhancing, quality.<br/>
        /// Creative Upscale **works best on highly degraded images and is not for photos of 1mp or above** as it performs<br/>
        /// heavy reimagining (controlled by creativity scale).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=QXxi9tfI425t)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `seed`<br/>
        /// - `negative_prompt`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 60 credits per successful generation.  You will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
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
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
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
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity">
        /// Indicates how creative the model should be when upscaling an image.<br/>
        /// Higher values will result in more details being added to the image during upscaling.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageUpscaleCreativeResponse> CreateStableImageUpscaleCreativeAsync(
            string contentType,
            byte[] image,
            string imagename,
            string prompt,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat? outputFormat = default,
            double? seed = default,
            double? creativity = default,
            global::StabilityAI.CreateStableImageUpscaleCreativeRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creative Upscale (async)<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to **4K** resolution.  Put more<br/>
        /// generally, it can upscale images ~20-40x times while preserving, and often enhancing, quality.<br/>
        /// Creative Upscale **works best on highly degraded images and is not for photos of 1mp or above** as it performs<br/>
        /// heavy reimagining (controlled by creativity scale).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=QXxi9tfI425t)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `seed`<br/>
        /// - `negative_prompt`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 60 credits per successful generation.  You will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
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
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
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
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity">
        /// Indicates how creative the model should be when upscaling an image.<br/>
        /// Higher values will result in more details being added to the image during upscaling.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/creative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./kitten-in-space.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "cute fluffy white kitten floating in space, pastel colors",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageUpscaleCreativeResponse> CreateStableImageUpscaleCreativeAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat? outputFormat = default,
            double? seed = default,
            double? creativity = default,
            global::StabilityAI.CreateStableImageUpscaleCreativeRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creative Upscale (async)<br/>
        /// Takes images between 64x64 and 1 megapixel and upscales them all the way to **4K** resolution.  Put more<br/>
        /// generally, it can upscale images ~20-40x times while preserving, and often enhancing, quality.<br/>
        /// Creative Upscale **works best on highly degraded images and is not for photos of 1mp or above** as it performs<br/>
        /// heavy reimagining (controlled by creativity scale).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=QXxi9tfI425t)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `seed`<br/>
        /// - `negative_prompt`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 60 credits per successful generation.  You will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
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
        /// - Total pixel count must be between 4,096 and 1,048,576 pixels<br/>
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
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity">
        /// Indicates how creative the model should be when upscaling an image.<br/>
        /// Higher values will result in more details being added to the image during upscaling.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/upscale/creative",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./kitten-in-space.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "cute fluffy white kitten floating in space, pastel colors",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageUpscaleCreativeResponse>> CreateStableImageUpscaleCreativeAsResponseAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            global::StabilityAI.CreateStableImageUpscaleCreativeRequestOutputFormat? outputFormat = default,
            double? seed = default,
            double? creativity = default,
            global::StabilityAI.CreateStableImageUpscaleCreativeRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}