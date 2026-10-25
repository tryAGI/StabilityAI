
#nullable enable

namespace StabilityAI
{
    public partial class ResultsClient
    {

        /// <summary>
        /// A successful outcome selected by the actual HTTP status and media type.
        /// Dispose this result after consuming its binary body to release the HTTP response.
        /// </summary>
        public sealed class GetResultsByIdResult : global::StabilityAI.AutoSDKHttpResponse, global::System.IDisposable
        {
            internal GetResultsByIdResult(
                global::System.Net.HttpStatusCode statusCode,
                global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> headers,
                global::System.Uri? requestUri,
                global::System.IO.Stream? body0 = default,
                global::StabilityAI.ImageJSONResponse? body1 = default,
                global::StabilityAI.GetResultsResponse? body2 = default)
                : base(statusCode, headers, requestUri)
            {
                Body200Variant0 = body0;
                Body200Variant1 = body1;
                Body202 = body2;
            }
            /// <summary>Gets the body for HTTP 200; null for other outcomes.</summary>
            public global::System.IO.Stream? Body200Variant0 { get; }
            /// <summary>Gets the body for HTTP 200; null for other outcomes.</summary>
            public global::StabilityAI.ImageJSONResponse? Body200Variant1 { get; }
            /// <summary>Gets the body for HTTP 202; null for other outcomes.</summary>
            public global::StabilityAI.GetResultsResponse? Body202 { get; }
            /// <summary>Releases the binary response stream, if present.</summary>
            public void Dispose()
            {
                Body200Variant0?.Dispose();
            }
        }


        private static readonly global::StabilityAI.EndPointSecurityRequirement s_GetResultsByIdSecurityRequirement0 =
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
        private static readonly global::StabilityAI.EndPointSecurityRequirement[] s_GetResultsByIdSecurityRequirements =
            new global::StabilityAI.EndPointSecurityRequirement[]
            {                s_GetResultsByIdSecurityRequirement0,
            };
        partial void PrepareGetResultsByIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref global::StabilityAI.GetResultsAccept? accept,
            ref string? stabilityClientId,
            ref string? stabilityClientUserId,
            ref string? stabilityClientVersion);
        partial void PrepareGetResultsByIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::StabilityAI.GetResultsAccept? accept,
            string? stabilityClientId,
            string? stabilityClientUserId,
            string? stabilityClientVersion);
        partial void ProcessGetResultsByIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetResultsByIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Fetch async generation result<br/>
        /// Fetch the result of a generation by ID.<br/>
        /// Make sure to use the same API key to fetch the generation result that you used to create the generation,<br/>
        /// otherwise you will receive a `404` response.<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `GET` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field and the ID<br/>
        /// of your generation must be in the path.<br/>
        /// ### How is progress reported?<br/>
        /// Your generation is either `in-progress` (i.e. status code `202`) or it is complete (i.e. status code `200`).<br/>
        /// We may add more fine-grained progress reporting in the future (e.g. a numerical progress).<br/>
        /// ### How long are results stored?<br/>
        /// Results are stored for 24 hours after generation. After that, the results are deleted.
        /// </summary>
        /// <param name="id">
        /// The `id` of a generation, typically used for async generations, that can be used to check the status of the generation or retrieve the result.<br/>
        /// Example: a6dc6c6e20acda010fe14d71f180658f2896ed9b4ec25aa99a6ff06c796987c4
        /// </param>
        /// <param name="accept">
        /// Specify `*/*` to receive the bytes of the result directly. Otherwise specify `application/json` to receive the result as base64 encoded JSON.<br/>
        /// Default Value: */*
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// generation_id = "e52772ac75b..."<br/>
        /// response = requests.request(<br/>
        ///     "GET",<br/>
        ///     f"https://api.stability.ai/v2beta/results/{generation_id}",<br/>
        ///     headers={<br/>
        ///         'accept': "image/*",  # Use 'application/json' to receive base64 encoded JSON<br/>
        ///         'authorization': f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 202:<br/>
        ///     print("Generation in-progress, try again in 10 seconds.")<br/>
        /// elif response.status_code == 200:<br/>
        ///     print("Generation complete!")<br/>
        ///     with open("result.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.ResultsClient.GetResultsByIdResult> GetResultsByIdAsync(
            string id,
            global::StabilityAI.GetResultsAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetResultsByIdAsResponseAsync(
                id: id,
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
        /// Fetch async generation result<br/>
        /// Fetch the result of a generation by ID.<br/>
        /// Make sure to use the same API key to fetch the generation result that you used to create the generation,<br/>
        /// otherwise you will receive a `404` response.<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `GET` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field and the ID<br/>
        /// of your generation must be in the path.<br/>
        /// ### How is progress reported?<br/>
        /// Your generation is either `in-progress` (i.e. status code `202`) or it is complete (i.e. status code `200`).<br/>
        /// We may add more fine-grained progress reporting in the future (e.g. a numerical progress).<br/>
        /// ### How long are results stored?<br/>
        /// Results are stored for 24 hours after generation. After that, the results are deleted.
        /// </summary>
        /// <param name="id">
        /// The `id` of a generation, typically used for async generations, that can be used to check the status of the generation or retrieve the result.<br/>
        /// Example: a6dc6c6e20acda010fe14d71f180658f2896ed9b4ec25aa99a6ff06c796987c4
        /// </param>
        /// <param name="accept">
        /// Specify `*/*` to receive the bytes of the result directly. Otherwise specify `application/json` to receive the result as base64 encoded JSON.<br/>
        /// Default Value: */*
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// generation_id = "e52772ac75b..."<br/>
        /// response = requests.request(<br/>
        ///     "GET",<br/>
        ///     f"https://api.stability.ai/v2beta/results/{generation_id}",<br/>
        ///     headers={<br/>
        ///         'accept': "image/*",  # Use 'application/json' to receive base64 encoded JSON<br/>
        ///         'authorization': f"Bearer sk-MYAPIKEY"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 202:<br/>
        ///     print("Generation in-progress, try again in 10 seconds.")<br/>
        /// elif response.status_code == 200:<br/>
        ///     print("Generation complete!")<br/>
        ///     with open("result.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.ResultsClient.GetResultsByIdResult>> GetResultsByIdAsResponseAsync(
            string id,
            global::StabilityAI.GetResultsAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetResultsByIdArguments(
                httpClient: HttpClient,
                id: ref id,
                accept: ref accept,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetResultsByIdSecurityRequirements,
                operationName: "GetResultsByIdAsync");

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
                                path: $"/v2beta/results/{id}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::StabilityAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetResultsByIdRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id,
                    accept: accept,
                    stabilityClientId: stabilityClientId,
                    stabilityClientUserId: stabilityClientUserId,
                    stabilityClientVersion: stabilityClientVersion);

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
                                operationId: "getResultsById",
                                methodName: "GetResultsByIdAsync",
                                pathTemplate: "$\"/v2beta/results/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
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
                                operationId: "getResultsById",
                                methodName: "GetResultsByIdAsync",
                                pathTemplate: "$\"/v2beta/results/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "getResultsById",
                                methodName: "GetResultsByIdAsync",
                                pathTemplate: "$\"/v2beta/results/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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

                try
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetResultsByIdResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getResultsById",
                                methodName: "GetResultsByIdAsync",
                                pathTemplate: "$\"/v2beta/results/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "getResultsById",
                                methodName: "GetResultsByIdAsync",
                                pathTemplate: "$\"/v2beta/results/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                global::StabilityAI.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.Error>.Create(
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
                            // id: the generation either does not exist or has expired.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::StabilityAI.Error? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::StabilityAI.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::StabilityAI.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
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
                                global::StabilityAI.Error? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::StabilityAI.ApiException<global::StabilityAI.Error>.Create(
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

                            if (!__response.IsSuccessStatusCode)
                            {
                                var __errorContent = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);
                                throw global::StabilityAI.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __errorContent,
                                    innerException: null,
                                    responseBody: __errorContent,
                                    responseHeaders: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response));
                            }
                            var __mediaType = __response.Content.Headers.ContentType?.MediaType;

                            if (((int)__response.StatusCode == 200) && (global::System.String.Equals(__mediaType, "image/jpeg", global::System.StringComparison.OrdinalIgnoreCase) || global::System.String.Equals(__mediaType, "image/png", global::System.StringComparison.OrdinalIgnoreCase) || global::System.String.Equals(__mediaType, "image/webp", global::System.StringComparison.OrdinalIgnoreCase)))
                            {
                                var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);
                                var __body = new global::StabilityAI.ResponseStream(__response, __stream);
                                var __result = new global::StabilityAI.ResultsClient.GetResultsByIdResult(
                                    statusCode: __response.StatusCode,
                                    headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                    requestUri: __response.RequestMessage?.RequestUri,
                                    body0: __body);
                                return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.ResultsClient.GetResultsByIdResult>(
                                    statusCode: __result.StatusCode,
                                    headers: __result.Headers,
                                    requestUri: __result.RequestUri,
                                    body: __result);
                            }

                            if (((int)__response.StatusCode == 200) && (global::System.String.Equals(__mediaType, "application/json; type=image/jpeg", global::System.StringComparison.OrdinalIgnoreCase) || global::System.String.Equals(__mediaType, "application/json; type=image/jpeg", global::System.StringComparison.OrdinalIgnoreCase) || global::System.String.Equals(__mediaType, "application/json; type=image/jpeg", global::System.StringComparison.OrdinalIgnoreCase)))
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);
                                var __body = global::StabilityAI.ImageJSONResponse.FromJson(__content, JsonSerializerContext) ?? throw new global::System.InvalidOperationException("Response deserialization failed.");
                                var __result = new global::StabilityAI.ResultsClient.GetResultsByIdResult(
                                    statusCode: __response.StatusCode,
                                    headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                    requestUri: __response.RequestMessage?.RequestUri,
                                    body1: __body);
                                __response.Dispose();
                                return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.ResultsClient.GetResultsByIdResult>(
                                    statusCode: __result.StatusCode,
                                    headers: __result.Headers,
                                    requestUri: __result.RequestUri,
                                    body: __result);
                            }

                            if (((int)__response.StatusCode == 202) && (global::System.String.Equals(__mediaType, "application/json", global::System.StringComparison.OrdinalIgnoreCase)))
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);
                                var __body = global::StabilityAI.GetResultsResponse.FromJson(__content, JsonSerializerContext) ?? throw new global::System.InvalidOperationException("Response deserialization failed.");
                                var __result = new global::StabilityAI.ResultsClient.GetResultsByIdResult(
                                    statusCode: __response.StatusCode,
                                    headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                    requestUri: __response.RequestMessage?.RequestUri,
                                    body2: __body);
                                __response.Dispose();
                                return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.ResultsClient.GetResultsByIdResult>(
                                    statusCode: __result.StatusCode,
                                    headers: __result.Headers,
                                    requestUri: __result.RequestUri,
                                    body: __result);
                            }

                            throw global::StabilityAI.ApiException.Create(
                                statusCode: __response.StatusCode,
                                message: "The successful HTTP status and Content-Type do not match a declared response contract.",
                                innerException: null,
                                responseBody: null,
                                responseHeaders: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response));


                }
                catch
                {
                    __response.Dispose();
                    throw;
                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}