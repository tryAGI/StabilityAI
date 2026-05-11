#nullable enable

namespace StabilityAI
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Stable Diffusion 3.5<br/>
        /// Generate using Stable Diffusion 3.5 models, Stability AI latest base model:<br/>
        /// - **Stable Diffusion 3.5 Large**: At 8 billion parameters, with superior quality and<br/>
        ///   prompt adherence, this base model is the most powerful in the Stable Diffusion<br/>
        ///   family. This model is ideal for professional use cases at 1 megapixel resolution.<br/>
        /// - **Stable Diffusion 3.5 Large Turbo**: A distilled version of Stable Diffusion 3.5 Large.<br/>
        ///   SD3.5 Large Turbo generates high-quality images with exceptional prompt adherence<br/>
        ///   in just 4 steps, making it considerably faster than Stable Diffusion 3.5 Large.<br/>
        /// - **Stable Diffusion 3.5 Medium**: With 2.5 billion parameters, the model delivers an<br/>
        ///   optimal balance between prompt accuracy and image quality, making it an efficient<br/>
        ///   choice for fast high-performance image generation.<br/>
        /// - **Stable Diffusion 3.5 Flash**: A distilled version of Stable Diffusion 3.5 Medium. <br/>
        ///   SD3.5 Flash generates high-quality images with a 4 step process instead of 40, making <br/>
        ///   it faster than Stable Diffusion 3.5 Medium.<br/>
        /// Read more about the model capabilities [here](https://stability.ai/news/introducing-stable-diffusion-3-5).<br/>
        /// As of April 17, 2025, we have deprecated the Stable Diffusion 3.0 APIs and will be automatically<br/>
        /// re-routing calls to Stable Diffusion 3.0 models to Stable Diffusion 3.5 APIs at no extra cost.<br/>
        /// You can read more in the [release notes](/docs/release-notes#api-deprecation-notice).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/SD3_API.ipynb)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.  The accept header should be set to one of the following:<br/>
        /// - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// #### **Generating with a prompt**<br/>
        /// Commonly referred to as **text-to-image**, this mode generates an image from text alone. While the only required<br/>
        /// parameter is the `prompt`, it also supports an `aspect_ratio` parameter which can be used to control the<br/>
        /// aspect ratio of the generated image.<br/>
        /// #### **Generating with a prompt *and* an image**<br/>
        /// Commonly referred to as **image-to-image**, this mode also generates an image from text but uses an existing image as the<br/>
        /// starting point. The required parameters are:<br/>
        /// - `prompt` - text to generate the image from<br/>
        /// - `image` - the image to use as the starting point for the generation<br/>
        /// - `strength` - controls how much influence the `image` parameter has on the output image<br/>
        /// - `mode` - must be set to `image-to-image`<br/>
        /// &gt; **Note:** maximum request size is 10MiB.<br/>
        /// #### **Optional Parameters:**<br/>
        /// Both modes support the following optional parameters:<br/>
        /// - `model` - the model to use (SD 3.5 Large, SD 3.5 Large Turbo, SD 3.5 Medium, SD 3.5 Flash)<br/>
        /// - `output_format` - the format of the output image<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `negative_prompt` - keywords of what you **do not** wish to see in the output image<br/>
        /// - `cfg_scale` - controls how strictly the diffusion process adheres to the prompt text<br/>
        /// - `style_preset` - guides the image model towards a particular style<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 1MP. The default resolution is 1024x1024.<br/>
        /// ### Credits<br/>
        /// - **SD 3.5 Large**: Flat rate of 6.5 credits per successful generation.<br/>
        /// - **SD 3.5 Large Turbo**: Flat rate of 4 credits per successful generation.<br/>
        /// - **SD 3.5 Medium**: Flat rate of 3.5 credits per successful generation.<br/>
        /// - **SD 3.5 Flash**: Flat rate of 2.5 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/generate/sd3",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={"none": ''},<br/>
        ///     data={<br/>
        ///         "prompt": "Lighthouse on a cliff overlooking the ocean",<br/>
        ///         "output_format": "jpeg",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./lighthouse.jpeg", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageGenerateSd3Response> CreateStableImageGenerateSd3Async(
            string contentType,

            global::StabilityAI.CreateStableImageGenerateSd3Request request,
            global::StabilityAI.CreateStableImageGenerateSd3Accept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Diffusion 3.5<br/>
        /// Generate using Stable Diffusion 3.5 models, Stability AI latest base model:<br/>
        /// - **Stable Diffusion 3.5 Large**: At 8 billion parameters, with superior quality and<br/>
        ///   prompt adherence, this base model is the most powerful in the Stable Diffusion<br/>
        ///   family. This model is ideal for professional use cases at 1 megapixel resolution.<br/>
        /// - **Stable Diffusion 3.5 Large Turbo**: A distilled version of Stable Diffusion 3.5 Large.<br/>
        ///   SD3.5 Large Turbo generates high-quality images with exceptional prompt adherence<br/>
        ///   in just 4 steps, making it considerably faster than Stable Diffusion 3.5 Large.<br/>
        /// - **Stable Diffusion 3.5 Medium**: With 2.5 billion parameters, the model delivers an<br/>
        ///   optimal balance between prompt accuracy and image quality, making it an efficient<br/>
        ///   choice for fast high-performance image generation.<br/>
        /// - **Stable Diffusion 3.5 Flash**: A distilled version of Stable Diffusion 3.5 Medium. <br/>
        ///   SD3.5 Flash generates high-quality images with a 4 step process instead of 40, making <br/>
        ///   it faster than Stable Diffusion 3.5 Medium.<br/>
        /// Read more about the model capabilities [here](https://stability.ai/news/introducing-stable-diffusion-3-5).<br/>
        /// As of April 17, 2025, we have deprecated the Stable Diffusion 3.0 APIs and will be automatically<br/>
        /// re-routing calls to Stable Diffusion 3.0 models to Stable Diffusion 3.5 APIs at no extra cost.<br/>
        /// You can read more in the [release notes](/docs/release-notes#api-deprecation-notice).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/SD3_API.ipynb)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.  The accept header should be set to one of the following:<br/>
        /// - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// #### **Generating with a prompt**<br/>
        /// Commonly referred to as **text-to-image**, this mode generates an image from text alone. While the only required<br/>
        /// parameter is the `prompt`, it also supports an `aspect_ratio` parameter which can be used to control the<br/>
        /// aspect ratio of the generated image.<br/>
        /// #### **Generating with a prompt *and* an image**<br/>
        /// Commonly referred to as **image-to-image**, this mode also generates an image from text but uses an existing image as the<br/>
        /// starting point. The required parameters are:<br/>
        /// - `prompt` - text to generate the image from<br/>
        /// - `image` - the image to use as the starting point for the generation<br/>
        /// - `strength` - controls how much influence the `image` parameter has on the output image<br/>
        /// - `mode` - must be set to `image-to-image`<br/>
        /// &gt; **Note:** maximum request size is 10MiB.<br/>
        /// #### **Optional Parameters:**<br/>
        /// Both modes support the following optional parameters:<br/>
        /// - `model` - the model to use (SD 3.5 Large, SD 3.5 Large Turbo, SD 3.5 Medium, SD 3.5 Flash)<br/>
        /// - `output_format` - the format of the output image<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `negative_prompt` - keywords of what you **do not** wish to see in the output image<br/>
        /// - `cfg_scale` - controls how strictly the diffusion process adheres to the prompt text<br/>
        /// - `style_preset` - guides the image model towards a particular style<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 1MP. The default resolution is 1024x1024.<br/>
        /// ### Credits<br/>
        /// - **SD 3.5 Large**: Flat rate of 6.5 credits per successful generation.<br/>
        /// - **SD 3.5 Large Turbo**: Flat rate of 4 credits per successful generation.<br/>
        /// - **SD 3.5 Medium**: Flat rate of 3.5 credits per successful generation.<br/>
        /// - **SD 3.5 Flash**: Flat rate of 2.5 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/generate/sd3",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={"none": ''},<br/>
        ///     data={<br/>
        ///         "prompt": "Lighthouse on a cliff overlooking the ocean",<br/>
        ///         "output_format": "jpeg",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./lighthouse.jpeg", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageGenerateSd3Response>> CreateStableImageGenerateSd3AsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageGenerateSd3Request request,
            global::StabilityAI.CreateStableImageGenerateSd3Accept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Diffusion 3.5<br/>
        /// Generate using Stable Diffusion 3.5 models, Stability AI latest base model:<br/>
        /// - **Stable Diffusion 3.5 Large**: At 8 billion parameters, with superior quality and<br/>
        ///   prompt adherence, this base model is the most powerful in the Stable Diffusion<br/>
        ///   family. This model is ideal for professional use cases at 1 megapixel resolution.<br/>
        /// - **Stable Diffusion 3.5 Large Turbo**: A distilled version of Stable Diffusion 3.5 Large.<br/>
        ///   SD3.5 Large Turbo generates high-quality images with exceptional prompt adherence<br/>
        ///   in just 4 steps, making it considerably faster than Stable Diffusion 3.5 Large.<br/>
        /// - **Stable Diffusion 3.5 Medium**: With 2.5 billion parameters, the model delivers an<br/>
        ///   optimal balance between prompt accuracy and image quality, making it an efficient<br/>
        ///   choice for fast high-performance image generation.<br/>
        /// - **Stable Diffusion 3.5 Flash**: A distilled version of Stable Diffusion 3.5 Medium. <br/>
        ///   SD3.5 Flash generates high-quality images with a 4 step process instead of 40, making <br/>
        ///   it faster than Stable Diffusion 3.5 Medium.<br/>
        /// Read more about the model capabilities [here](https://stability.ai/news/introducing-stable-diffusion-3-5).<br/>
        /// As of April 17, 2025, we have deprecated the Stable Diffusion 3.0 APIs and will be automatically<br/>
        /// re-routing calls to Stable Diffusion 3.0 models to Stable Diffusion 3.5 APIs at no extra cost.<br/>
        /// You can read more in the [release notes](/docs/release-notes#api-deprecation-notice).<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/SD3_API.ipynb)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.  The accept header should be set to one of the following:<br/>
        /// - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// #### **Generating with a prompt**<br/>
        /// Commonly referred to as **text-to-image**, this mode generates an image from text alone. While the only required<br/>
        /// parameter is the `prompt`, it also supports an `aspect_ratio` parameter which can be used to control the<br/>
        /// aspect ratio of the generated image.<br/>
        /// #### **Generating with a prompt *and* an image**<br/>
        /// Commonly referred to as **image-to-image**, this mode also generates an image from text but uses an existing image as the<br/>
        /// starting point. The required parameters are:<br/>
        /// - `prompt` - text to generate the image from<br/>
        /// - `image` - the image to use as the starting point for the generation<br/>
        /// - `strength` - controls how much influence the `image` parameter has on the output image<br/>
        /// - `mode` - must be set to `image-to-image`<br/>
        /// &gt; **Note:** maximum request size is 10MiB.<br/>
        /// #### **Optional Parameters:**<br/>
        /// Both modes support the following optional parameters:<br/>
        /// - `model` - the model to use (SD 3.5 Large, SD 3.5 Large Turbo, SD 3.5 Medium, SD 3.5 Flash)<br/>
        /// - `output_format` - the format of the output image<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `negative_prompt` - keywords of what you **do not** wish to see in the output image<br/>
        /// - `cfg_scale` - controls how strictly the diffusion process adheres to the prompt text<br/>
        /// - `style_preset` - guides the image model towards a particular style<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 1MP. The default resolution is 1024x1024.<br/>
        /// ### Credits<br/>
        /// - **SD 3.5 Large**: Flat rate of 6.5 credits per successful generation.<br/>
        /// - **SD 3.5 Large Turbo**: Flat rate of 4 credits per successful generation.<br/>
        /// - **SD 3.5 Medium**: Flat rate of 3.5 credits per successful generation.<br/>
        /// - **SD 3.5 Flash**: Flat rate of 2.5 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
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
        /// elements, colors, and subjects will lead to better results.
        /// </param>
        /// <param name="mode">
        /// Controls whether this is a text-to-image or image-to-image generation, which affects which parameters are required:<br/>
        /// - **text-to-image** requires only the `prompt` parameter<br/>
        /// - **image-to-image** requires the `prompt`, `image`, and `strength` parameters<br/>
        /// Default Value: text-to-image
        /// </param>
        /// <param name="image">
        /// The image to use as the starting point for the generation.<br/>
        /// Supported formats:<br/>
        ///   - jpeg<br/>
        ///   - png<br/>
        ///   - webp<br/>
        /// Supported dimensions:<br/>
        ///   - Every side must be at least 64 pixels<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests.
        /// </param>
        /// <param name="imagename">
        /// The image to use as the starting point for the generation.<br/>
        /// Supported formats:<br/>
        ///   - jpeg<br/>
        ///   - png<br/>
        ///   - webp<br/>
        /// Supported dimensions:<br/>
        ///   - Every side must be at least 64 pixels<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests.
        /// </param>
        /// <param name="strength">
        /// Sometimes referred to as _denoising_, this parameter controls how much influence the<br/>
        /// `image` parameter has on the generated image.  A value of 0 would yield an image that<br/>
        /// is identical to the input.  A value of 1 would be as if you passed in no image at all.<br/>
        /// &gt; **Important:** This parameter is only valid for **image-to-image** requests. For SD 3.5 Flash, the<br/>
        ///  best results for image-to-image generation are achieved with a `strength` between .94 - .97.
        /// </param>
        /// <param name="aspectRatio">
        /// Controls the aspect ratio of the generated image. Defaults to 1:1.<br/>
        /// &gt; **Important:** This parameter is only valid for **text-to-image** requests.<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="model">
        /// The model to use for generation.<br/>
        /// - `sd3.5-large` requires 6.5 credits per generation<br/>
        /// - `sd3.5-large-turbo` requires 4 credits per generation<br/>
        /// - `sd3.5-medium` requires 3.5 credits per generation<br/>
        /// - `sd3.5-flash` requires 2.5 credits per generation<br/>
        /// - As of the April 17, 2025, `sd3-large`, `sd3-large-turbo` and `sd3-medium`<br/>
        ///   are re-routed to their `sd3.5-[model version]` equivalent, at the same price.<br/>
        /// Default Value: sd3.5-large
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="negativePrompt">
        /// Keywords of what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values keep your image closer to your prompt). The _Large_ and _Medium_ models use a default of `4`. The _Turbo_ and _Flash_ model uses a default of `1`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageGenerateSd3Response> CreateStableImageGenerateSd3Async(
            string contentType,
            string prompt,
            global::StabilityAI.CreateStableImageGenerateSd3Accept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.CreateStableImageGenerateSd3RequestMode? mode = default,
            byte[]? image = default,
            string? imagename = default,
            double? strength = default,
            global::StabilityAI.CreateStableImageGenerateSd3RequestAspectRatio? aspectRatio = default,
            global::StabilityAI.CreateStableImageGenerateSd3RequestModel? model = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageGenerateSd3RequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageGenerateSd3RequestStylePreset? stylePreset = default,
            string? negativePrompt = default,
            double? cfgScale = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}