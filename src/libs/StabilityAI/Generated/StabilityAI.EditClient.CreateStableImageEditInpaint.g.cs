
#nullable enable

namespace StabilityAI
{
    public partial class EditClient
    {


        private static readonly global::StabilityAI.EndPointSecurityRequirement s_CreateStableImageEditInpaintSecurityRequirement0 =
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
        private static readonly global::StabilityAI.EndPointSecurityRequirement[] s_CreateStableImageEditInpaintSecurityRequirements =
            new global::StabilityAI.EndPointSecurityRequirement[]
            {                s_CreateStableImageEditInpaintSecurityRequirement0,
            };
        partial void PrepareCreateStableImageEditInpaintArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string contentType,
            ref global::StabilityAI.CreateStableImageEditInpaintAccept? accept,
            ref string? stabilityClientId,
            ref string? stabilityClientUserId,
            ref string? stabilityClientVersion,
            global::StabilityAI.CreateStableImageEditInpaintRequest request);
        partial void PrepareCreateStableImageEditInpaintRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string contentType,
            global::StabilityAI.CreateStableImageEditInpaintAccept? accept,
            string? stabilityClientId,
            string? stabilityClientUserId,
            string? stabilityClientVersion,
            global::StabilityAI.CreateStableImageEditInpaintRequest request);
        partial void ProcessCreateStableImageEditInpaintResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateStableImageEditInpaintResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Inpaint<br/>
        /// Intelligently modify images by filling in or replacing specified areas with new content based<br/>
        /// on the content of a "mask" image.<br/>
        /// The "mask" is provided in one of two ways:<br/>
        ///   1. Explicitly passing in a separate image via the `mask` parameter<br/>
        ///   2. Derived from the alpha channel of the `image` parameter.<br/>
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
        /// - `mask`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation.  You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/inpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./dog-wearing-vr-goggles.png", "rb"),<br/>
        ///         "mask": open("./mask.png", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "dog wearing black glasses",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./dog-wearing-black-glasses.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditInpaintResponse> CreateStableImageEditInpaintAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditInpaintRequest request,
            global::StabilityAI.CreateStableImageEditInpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateStableImageEditInpaintAsResponseAsync(
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
        /// Inpaint<br/>
        /// Intelligently modify images by filling in or replacing specified areas with new content based<br/>
        /// on the content of a "mask" image.<br/>
        /// The "mask" is provided in one of two ways:<br/>
        ///   1. Explicitly passing in a separate image via the `mask` parameter<br/>
        ///   2. Derived from the alpha channel of the `image` parameter.<br/>
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
        /// - `mask`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation.  You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/inpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./dog-wearing-vr-goggles.png", "rb"),<br/>
        ///         "mask": open("./mask.png", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "dog wearing black glasses",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./dog-wearing-black-glasses.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditInpaintResponse>> CreateStableImageEditInpaintAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditInpaintRequest request,
            global::StabilityAI.CreateStableImageEditInpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateStableImageEditInpaintArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                accept: ref accept,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStableImageEditInpaintSecurityRequirements,
                operationName: "CreateStableImageEditInpaintAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::StabilityAI.PathBuilder(
                                path: "/v2beta/stable-image/edit/inpaint",
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

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "application/json");

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

                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                name: "\"prompt\"");

                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");

                            }
                            if (request.Mask != default)
                            {

                                var __contentMask = new global::System.Net.Http.ByteArrayContent(request.Mask ?? global::System.Array.Empty<byte>());
                                __contentMask.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Maskname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Maskname) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentMask,
                                    name: "\"mask\"",
                                    fileName: request.Maskname != null ? $"\"{request.Maskname}\"" : string.Empty);
                                if (__contentMask.Headers.ContentDisposition != null)
                                {
                                    __contentMask.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.GrowMask != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.GrowMask, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"grow_mask\"");

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

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStableImageEditInpaintRequest(
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
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::StabilityAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::StabilityAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::StabilityAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessCreateStableImageEditInpaintResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid parameter(s), see the `errors` field for details.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse4? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateStableImageEditInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateStableImageEditInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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


                                throw global::StabilityAI.ApiException<global::StabilityAI.ContentModerationResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Your request was larger than 10MiB.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse5? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::StabilityAI.CreateStableImageEditInpaintResponse5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::StabilityAI.CreateStableImageEditInpaintResponse5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse5>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Your request was well-formed, but rejected. See the `errors` field for details.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse6? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateStableImageEditInpaintResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateStableImageEditInpaintResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse6>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // You have made more than 150 requests in 10 seconds.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse7? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateStableImageEditInpaintResponse7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateStableImageEditInpaintResponse7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse7>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // An internal error occurred. If the problem persists [contact support](https://kb.stability.ai/knowledge-base/kb-tickets/new).
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse8? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateStableImageEditInpaintResponse8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateStableImageEditInpaintResponse8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse8>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateStableImageEditInpaintResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::StabilityAI.CreateStableImageEditInpaintResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditInpaintResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::StabilityAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::StabilityAI.CreateStableImageEditInpaintResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditInpaintResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
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

                                    throw global::StabilityAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Inpaint<br/>
        /// Intelligently modify images by filling in or replacing specified areas with new content based<br/>
        /// on the content of a "mask" image.<br/>
        /// The "mask" is provided in one of two ways:<br/>
        ///   1. Explicitly passing in a separate image via the `mask` parameter<br/>
        ///   2. Derived from the alpha channel of the `image` parameter.<br/>
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
        /// - `mask`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation.  You will not be charged for failed generations.
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
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
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
        /// <param name="mask">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="maskname">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="growMask">
        /// Grows the edges of the mask outward in all directions by the specified number of pixels. The expanded area around the mask will be blurred, which can help smooth the transition between inpainted content and the original image.<br/>
        /// Try this parameter if you notice seams or rough edges around the inpainted content.<br/>
        /// &gt; Note: Excessive growth may obscure fine details in the mask and/or merge nearby masked regions.<br/>
        /// Default Value: 5
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditInpaintResponse> CreateStableImageEditInpaintAsync(
            string contentType,
            byte[] image,
            string imagename,
            string prompt,
            global::StabilityAI.CreateStableImageEditInpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            byte[]? mask = default,
            string? maskname = default,
            double? growMask = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::StabilityAI.CreateStableImageEditInpaintRequest
            {
                Image = image,
                Imagename = imagename,
                Prompt = prompt,
                NegativePrompt = negativePrompt,
                Mask = mask,
                Maskname = maskname,
                GrowMask = growMask,
                Seed = seed,
                OutputFormat = outputFormat,
                StylePreset = stylePreset,
            };

            return await CreateStableImageEditInpaintAsync(
                contentType: contentType,
                accept: accept,
                stabilityClientId: stabilityClientId,
                stabilityClientUserId: stabilityClientUserId,
                stabilityClientVersion: stabilityClientVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Inpaint<br/>
        /// Intelligently modify images by filling in or replacing specified areas with new content based<br/>
        /// on the content of a "mask" image.<br/>
        /// The "mask" is provided in one of two ways:<br/>
        ///   1. Explicitly passing in a separate image via the `mask` parameter<br/>
        ///   2. Derived from the alpha channel of the `image` parameter.<br/>
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
        /// - `mask`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation.  You will not be charged for failed generations.
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
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
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
        /// <param name="mask">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="maskname">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="growMask">
        /// Grows the edges of the mask outward in all directions by the specified number of pixels. The expanded area around the mask will be blurred, which can help smooth the transition between inpainted content and the original image.<br/>
        /// Try this parameter if you notice seams or rough edges around the inpainted content.<br/>
        /// &gt; Note: Excessive growth may obscure fine details in the mask and/or merge nearby masked regions.<br/>
        /// Default Value: 5
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/inpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./dog-wearing-vr-goggles.png", "rb"),<br/>
        ///         "mask": open("./mask.png", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "dog wearing black glasses",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./dog-wearing-black-glasses.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditInpaintResponse> CreateStableImageEditInpaintAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            global::StabilityAI.CreateStableImageEditInpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            global::System.IO.Stream? mask = default,
            string? maskname = default,
            double? growMask = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            var request = new global::StabilityAI.CreateStableImageEditInpaintRequest
            {
                Image = global::System.Array.Empty<byte>(),
                Imagename = imagename,
                Prompt = prompt,
                NegativePrompt = negativePrompt,
                Mask = global::System.Array.Empty<byte>(),
                Maskname = maskname,
                GrowMask = growMask,
                Seed = seed,
                OutputFormat = outputFormat,
                StylePreset = stylePreset,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateStableImageEditInpaintArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                accept: ref accept,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStableImageEditInpaintSecurityRequirements,
                operationName: "CreateStableImageEditInpaintAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::StabilityAI.PathBuilder(
                                path: "/v2beta/stable-image/edit/inpaint",
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

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "application/json");

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
                            var __contentImage = new global::System.Net.Http.StreamContent(image);
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

                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                name: "\"prompt\"");

                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");

                            }
                            if (mask != default)
                            {

                                var __contentMask = new global::System.Net.Http.StreamContent(mask);
                                __contentMask.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Maskname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Maskname) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentMask,
                                    name: "\"mask\"",
                                    fileName: request.Maskname != null ? $"\"{request.Maskname}\"" : string.Empty);
                                if (__contentMask.Headers.ContentDisposition != null)
                                {
                                    __contentMask.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.GrowMask != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.GrowMask, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"grow_mask\"");

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

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStableImageEditInpaintRequest(
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
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::StabilityAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::StabilityAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::StabilityAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessCreateStableImageEditInpaintResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid parameter(s), see the `errors` field for details.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse4? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateStableImageEditInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateStableImageEditInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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


                                throw global::StabilityAI.ApiException<global::StabilityAI.ContentModerationResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Your request was larger than 10MiB.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse5? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::StabilityAI.CreateStableImageEditInpaintResponse5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::StabilityAI.CreateStableImageEditInpaintResponse5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse5>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Your request was well-formed, but rejected. See the `errors` field for details.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse6? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateStableImageEditInpaintResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateStableImageEditInpaintResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse6>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // You have made more than 150 requests in 10 seconds.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse7? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateStableImageEditInpaintResponse7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateStableImageEditInpaintResponse7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse7>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // An internal error occurred. If the problem persists [contact support](https://kb.stability.ai/knowledge-base/kb-tickets/new).
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse8? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateStableImageEditInpaintResponse8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateStableImageEditInpaintResponse8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse8>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateStableImageEditInpaintResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::StabilityAI.CreateStableImageEditInpaintResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::StabilityAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    return
                                        await global::StabilityAI.CreateStableImageEditInpaintResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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

                                    throw global::StabilityAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Inpaint<br/>
        /// Intelligently modify images by filling in or replacing specified areas with new content based<br/>
        /// on the content of a "mask" image.<br/>
        /// The "mask" is provided in one of two ways:<br/>
        ///   1. Explicitly passing in a separate image via the `mask` parameter<br/>
        ///   2. Derived from the alpha channel of the `image` parameter.<br/>
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
        /// - `mask`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will be 4 megapixels.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation.  You will not be charged for failed generations.
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
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image you wish to inpaint.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
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
        /// <param name="mask">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="maskname">
        /// Controls the strength of the inpainting process on a per-pixel basis, either via a<br/>
        /// second image (passed into this parameter) or via the alpha channel of the `image` parameter.<br/>
        /// **Passing in a Mask**<br/>
        /// The image passed to this parameter should be a black and white image that represents,<br/>
        /// at any pixel, the strength of inpainting based on how dark or light the given pixel is.<br/>
        /// Completely black pixels represent no inpainting strength while completely white pixels<br/>
        /// represent maximum strength.<br/>
        /// In the event the mask is a different size than the `image` parameter, it will be automatically resized.<br/>
        /// **Alpha Channel Support**<br/>
        /// If you don't provide an explicit mask, one will be derived from the alpha channel of the `image` parameter.<br/>
        /// Transparent pixels will be inpainted while opaque pixels will be preserved.<br/>
        /// In the event an `image` with an alpha channel is provided along with a `mask`, the `mask` will take precedence.<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="growMask">
        /// Grows the edges of the mask outward in all directions by the specified number of pixels. The expanded area around the mask will be blurred, which can help smooth the transition between inpainted content and the original image.<br/>
        /// Try this parameter if you notice seams or rough edges around the inpainted content.<br/>
        /// &gt; Note: Excessive growth may obscure fine details in the mask and/or merge nearby masked regions.<br/>
        /// Default Value: 5
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/inpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./dog-wearing-vr-goggles.png", "rb"),<br/>
        ///         "mask": open("./mask.png", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "dog wearing black glasses",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./dog-wearing-black-glasses.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditInpaintResponse>> CreateStableImageEditInpaintAsResponseAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string prompt,
            global::StabilityAI.CreateStableImageEditInpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            string? negativePrompt = default,
            global::System.IO.Stream? mask = default,
            string? maskname = default,
            double? growMask = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditInpaintRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageEditInpaintRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            var request = new global::StabilityAI.CreateStableImageEditInpaintRequest
            {
                Image = global::System.Array.Empty<byte>(),
                Imagename = imagename,
                Prompt = prompt,
                NegativePrompt = negativePrompt,
                Mask = global::System.Array.Empty<byte>(),
                Maskname = maskname,
                GrowMask = growMask,
                Seed = seed,
                OutputFormat = outputFormat,
                StylePreset = stylePreset,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateStableImageEditInpaintArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                accept: ref accept,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStableImageEditInpaintSecurityRequirements,
                operationName: "CreateStableImageEditInpaintAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::StabilityAI.PathBuilder(
                                path: "/v2beta/stable-image/edit/inpaint",
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

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "application/json");

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
                            var __contentImage = new global::System.Net.Http.StreamContent(image);
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

                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                name: "\"prompt\"");

                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");

                            }
                            if (mask != default)
                            {

                                var __contentMask = new global::System.Net.Http.StreamContent(mask);
                                __contentMask.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Maskname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Maskname) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentMask,
                                    name: "\"mask\"",
                                    fileName: request.Maskname != null ? $"\"{request.Maskname}\"" : string.Empty);
                                if (__contentMask.Headers.ContentDisposition != null)
                                {
                                    __contentMask.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.GrowMask != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.GrowMask, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"grow_mask\"");

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

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStableImageEditInpaintRequest(
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
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::StabilityAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::StabilityAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::StabilityAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::StabilityAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessCreateStableImageEditInpaintResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditInpaint",
                                methodName: "CreateStableImageEditInpaintAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/inpaint\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid parameter(s), see the `errors` field for details.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse4? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateStableImageEditInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateStableImageEditInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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


                                throw global::StabilityAI.ApiException<global::StabilityAI.ContentModerationResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Your request was larger than 10MiB.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse5? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::StabilityAI.CreateStableImageEditInpaintResponse5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::StabilityAI.CreateStableImageEditInpaintResponse5.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse5>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Your request was well-formed, but rejected. See the `errors` field for details.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse6? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateStableImageEditInpaintResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateStableImageEditInpaintResponse6.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse6>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // You have made more than 150 requests in 10 seconds.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse7? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateStableImageEditInpaintResponse7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateStableImageEditInpaintResponse7.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse7>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // An internal error occurred. If the problem persists [contact support](https://kb.stability.ai/knowledge-base/kb-tickets/new).
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::StabilityAI.CreateStableImageEditInpaintResponse8? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateStableImageEditInpaintResponse8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateStableImageEditInpaintResponse8.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditInpaintResponse8>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateStableImageEditInpaintResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::StabilityAI.CreateStableImageEditInpaintResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditInpaintResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::StabilityAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::StabilityAI.CreateStableImageEditInpaintResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditInpaintResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
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

                                    throw global::StabilityAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}