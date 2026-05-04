
#nullable enable

namespace StabilityAI
{
    public partial class GenerateClient
    {


        private static readonly global::StabilityAI.EndPointSecurityRequirement s_CreateStableImageGenerateSd3SecurityRequirement0 =
            new global::StabilityAI.EndPointSecurityRequirement
            {
                Authorizations = new global::StabilityAI.EndPointAuthorizationRequirement[]
                {                    new global::StabilityAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::StabilityAI.EndPointSecurityRequirement[] s_CreateStableImageGenerateSd3SecurityRequirements =
            new global::StabilityAI.EndPointSecurityRequirement[]
            {                s_CreateStableImageGenerateSd3SecurityRequirement0,
            };
        partial void PrepareCreateStableImageGenerateSd3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string contentType,
            ref global::StabilityAI.CreateStableImageGenerateSd3Accept? accept,
            ref string? stabilityClientId,
            ref string? stabilityClientUserId,
            ref string? stabilityClientVersion,
            global::StabilityAI.CreateStableImageGenerateSd3Request request);
        partial void PrepareCreateStableImageGenerateSd3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string contentType,
            global::StabilityAI.CreateStableImageGenerateSd3Accept? accept,
            string? stabilityClientId,
            string? stabilityClientUserId,
            string? stabilityClientVersion,
            global::StabilityAI.CreateStableImageGenerateSd3Request request);
        partial void ProcessCreateStableImageGenerateSd3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateStableImageGenerateSd3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageGenerateSd3Response> CreateStableImageGenerateSd3Async(
            string contentType,

            global::StabilityAI.CreateStableImageGenerateSd3Request request,
            global::StabilityAI.CreateStableImageGenerateSd3Accept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateStableImageGenerateSd3AsResponseAsync(
                contentType: contentType,

                request: request,
                accept: accept,
                stabilityClientId: stabilityClientId,
                stabilityClientUserId: stabilityClientUserId,
                stabilityClientVersion: stabilityClientVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageGenerateSd3Response>> CreateStableImageGenerateSd3AsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageGenerateSd3Request request,
            global::StabilityAI.CreateStableImageGenerateSd3Accept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateStableImageGenerateSd3Arguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                accept: ref accept,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStableImageGenerateSd3SecurityRequirements,
                operationName: "CreateStableImageGenerateSd3Async");

            using var __timeoutCancellationTokenSource = global::StabilityAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::StabilityAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::StabilityAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::StabilityAI.PathBuilder(
                                path: "/v2beta/stable-image/generate/sd3",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::StabilityAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                __httpRequest.Headers.TryAddWithoutValidation("content-type", contentType.ToString());
            if (accept != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("accept", accept?.ToValueString() ?? string.Empty);
            }
            if (stabilityClientId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("stability-client-id", stabilityClientId.ToString());
            }
            if (stabilityClientUserId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("stability-client-user-id", stabilityClientUserId.ToString());
            }
            if (stabilityClientVersion != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("stability-client-version", stabilityClientVersion.ToString());
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(contentType ?? string.Empty),
                                name: "\"content-type\"");
                            if (accept != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((accept).HasValue ? (accept).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"accept\"");
                            } 
                            if (stabilityClientId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(stabilityClientId ?? string.Empty),
                                    name: "\"stability-client-id\"");
                            } 
                            if (stabilityClientUserId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(stabilityClientUserId ?? string.Empty),
                                    name: "\"stability-client-user-id\"");
                            } 
                            if (stabilityClientVersion != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(stabilityClientVersion ?? string.Empty),
                                    name: "\"stability-client-version\"");
                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                name: "\"prompt\"");
                            if (request.Mode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Mode).HasValue ? (request.Mode).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"mode\"");
                            } 
                            if (request.Image != default)
                            {

                                var __contentImage = new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>());
                                __contentImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Imagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Imagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentImage,
                                    name: "\"image\"",
                                    fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
                                if (__contentImage.Headers.ContentDisposition != null)
                                {
                                    __contentImage.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Strength != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Strength, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"strength\"");
                            } 
                            if (request.AspectRatio != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.AspectRatio).HasValue ? (request.AspectRatio).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"aspect_ratio\"");
                            } 
                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Model).HasValue ? (request.Model).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"model\"");
                            } 
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");
                            } 
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.OutputFormat).HasValue ? (request.OutputFormat).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"output_format\"");
                            } 
                            if (request.StylePreset != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.StylePreset).HasValue ? (request.StylePreset).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"style_preset\"");
                            } 
                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");
                            } 
                            if (request.CfgScale != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.CfgScale, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"cfg_scale\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStableImageGenerateSd3Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    contentType: contentType!,
                    accept: accept,
                    stabilityClientId: stabilityClientId,
                    stabilityClientUserId: stabilityClientUserId,
                    stabilityClientVersion: stabilityClientVersion,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageGenerateSd3",
                                methodName: "CreateStableImageGenerateSd3Async",
                                pathTemplate: "\"/v2beta/stable-image/generate/sd3\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageGenerateSd3",
                                methodName: "CreateStableImageGenerateSd3Async",
                                pathTemplate: "\"/v2beta/stable-image/generate/sd3\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::StabilityAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageGenerateSd3",
                                methodName: "CreateStableImageGenerateSd3Async",
                                pathTemplate: "\"/v2beta/stable-image/generate/sd3\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateStableImageGenerateSd3Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageGenerateSd3",
                                methodName: "CreateStableImageGenerateSd3Async",
                                pathTemplate: "\"/v2beta/stable-image/generate/sd3\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageGenerateSd3",
                                methodName: "CreateStableImageGenerateSd3Async",
                                pathTemplate: "\"/v2beta/stable-image/generate/sd3\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid parameter(s), see the `errors` field for details.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::StabilityAI.CreateStableImageGenerateSd3Response4? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateStableImageGenerateSd3Response4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateStableImageGenerateSd3Response4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageGenerateSd3Response4>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Your request was flagged by our content moderation system.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::StabilityAI.ContentModerationResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::StabilityAI.ContentModerationResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::StabilityAI.ContentModerationResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.ContentModerationResponse>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Your request was larger than 10MiB.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::StabilityAI.CreateStableImageGenerateSd3Response5? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::StabilityAI.CreateStableImageGenerateSd3Response5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::StabilityAI.CreateStableImageGenerateSd3Response5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageGenerateSd3Response5>(
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_413,
                                    ResponseObject = __value_413,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Your request was well-formed, but rejected. See the `errors` field for details.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::StabilityAI.CreateStableImageGenerateSd3Response6? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateStableImageGenerateSd3Response6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateStableImageGenerateSd3Response6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageGenerateSd3Response6>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // You have made more than 150 requests in 10 seconds.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::StabilityAI.CreateStableImageGenerateSd3Response7? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateStableImageGenerateSd3Response7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateStableImageGenerateSd3Response7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageGenerateSd3Response7>(
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_429,
                                    ResponseObject = __value_429,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // An internal error occurred. If the problem persists [contact support](https://kb.stability.ai/knowledge-base/kb-tickets/new).
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::StabilityAI.CreateStableImageGenerateSd3Response8? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateStableImageGenerateSd3Response8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateStableImageGenerateSd3Response8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageGenerateSd3Response8>(
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_500,
                                    ResponseObject = __value_500,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateStableImageGenerateSd3ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::StabilityAI.CreateStableImageGenerateSd3Response.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageGenerateSd3Response>(
                                        statusCode: __response.StatusCode,
                                        headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::StabilityAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::StabilityAI.CreateStableImageGenerateSd3Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageGenerateSd3Response>(
                                        statusCode: __response.StatusCode,
                                        headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::StabilityAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageGenerateSd3Response> CreateStableImageGenerateSd3Async(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::StabilityAI.CreateStableImageGenerateSd3Request
            {
                Prompt = prompt,
                Mode = mode,
                Image = image,
                Imagename = imagename,
                Strength = strength,
                AspectRatio = aspectRatio,
                Model = model,
                Seed = seed,
                OutputFormat = outputFormat,
                StylePreset = stylePreset,
                NegativePrompt = negativePrompt,
                CfgScale = cfgScale,
            };

            return await CreateStableImageGenerateSd3Async(
                contentType: contentType,
                accept: accept,
                stabilityClientId: stabilityClientId,
                stabilityClientUserId: stabilityClientUserId,
                stabilityClientVersion: stabilityClientVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}