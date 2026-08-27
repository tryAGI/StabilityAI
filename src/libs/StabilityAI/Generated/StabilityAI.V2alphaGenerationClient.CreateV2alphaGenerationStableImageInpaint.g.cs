
#nullable enable

namespace StabilityAI
{
    public partial class V2alphaGenerationClient
    {


        private static readonly global::StabilityAI.EndPointSecurityRequirement s_CreateV2alphaGenerationStableImageInpaintSecurityRequirement0 =
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
        private static readonly global::StabilityAI.EndPointSecurityRequirement[] s_CreateV2alphaGenerationStableImageInpaintSecurityRequirements =
            new global::StabilityAI.EndPointSecurityRequirement[]
            {                s_CreateV2alphaGenerationStableImageInpaintSecurityRequirement0,
            };
        partial void PrepareCreateV2alphaGenerationStableImageInpaintArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string contentType,
            ref global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest request);
        partial void PrepareCreateV2alphaGenerationStableImageInpaintRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string contentType,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest request);
        partial void ProcessCreateV2alphaGenerationStableImageInpaintResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateV2alphaGenerationStableImageInpaintResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse> CreateV2alphaGenerationStableImageInpaintAsync(
            string contentType,

            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest request,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateV2alphaGenerationStableImageInpaintAsResponseAsync(
                contentType: contentType,

                request: request,
                accept: accept,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse>> CreateV2alphaGenerationStableImageInpaintAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest request,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateV2alphaGenerationStableImageInpaintArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                accept: ref accept,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateV2alphaGenerationStableImageInpaintSecurityRequirements,
                operationName: "CreateV2alphaGenerationStableImageInpaintAsync");

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
                                path: "/v2alpha/generation/stable-image/inpaint",
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


                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateV2alphaGenerationStableImageInpaintRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    contentType: contentType!,
                    accept: accept,
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
                                operationId: "createV2alphaGenerationStableImageInpaint",
                                methodName: "CreateV2alphaGenerationStableImageInpaintAsync",
                                pathTemplate: "\"/v2alpha/generation/stable-image/inpaint\"",
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
                                operationId: "createV2alphaGenerationStableImageInpaint",
                                methodName: "CreateV2alphaGenerationStableImageInpaintAsync",
                                pathTemplate: "\"/v2alpha/generation/stable-image/inpaint\"",
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
                                operationId: "createV2alphaGenerationStableImageInpaint",
                                methodName: "CreateV2alphaGenerationStableImageInpaintAsync",
                                pathTemplate: "\"/v2alpha/generation/stable-image/inpaint\"",
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
                ProcessCreateV2alphaGenerationStableImageInpaintResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createV2alphaGenerationStableImageInpaint",
                                methodName: "CreateV2alphaGenerationStableImageInpaintAsync",
                                pathTemplate: "\"/v2alpha/generation/stable-image/inpaint\"",
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
                                operationId: "createV2alphaGenerationStableImageInpaint",
                                methodName: "CreateV2alphaGenerationStableImageInpaintAsync",
                                pathTemplate: "\"/v2alpha/generation/stable-image/inpaint\"",
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
                                global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse4? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse4.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse4>.Create(
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
                            // An internal error occurred. If the problem persists [contact support](https://kb.stability.ai/knowledge-base/kb-tickets/new).
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse5? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse5.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse5.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse5>.Create(
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
                                ProcessCreateV2alphaGenerationStableImageInpaintResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse>(
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

                                    var __value = await global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse>(
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
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateV2alphaGenerationStableImageInpaintResponse> CreateV2alphaGenerationStableImageInpaintAsync(
            string contentType,
            global::StabilityAI.CreateV2alphaGenerationStableImageInpaintAccept? accept = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::StabilityAI.CreateV2alphaGenerationStableImageInpaintRequest
            {
            };

            return await CreateV2alphaGenerationStableImageInpaintAsync(
                contentType: contentType,
                accept: accept,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}