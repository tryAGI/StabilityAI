
#nullable enable

namespace StabilityAI
{
    public partial class StableAudioClient
    {


        private static readonly global::StabilityAI.EndPointSecurityRequirement s_CreateAudioStableAudioTextToAudioSecurityRequirement0 =
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
        private static readonly global::StabilityAI.EndPointSecurityRequirement[] s_CreateAudioStableAudioTextToAudioSecurityRequirements =
            new global::StabilityAI.EndPointSecurityRequirement[]
            {                s_CreateAudioStableAudioTextToAudioSecurityRequirement0,
            };
        partial void PrepareCreateAudioStableAudioTextToAudioArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string contentType,
            ref global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept,
            ref string? stabilityClientId,
            ref string? stabilityClientUserId,
            ref string? stabilityClientVersion,
            global::StabilityAI.CreateAudioStableAudioTextToAudioRequest request);
        partial void PrepareCreateAudioStableAudioTextToAudioRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string contentType,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept,
            string? stabilityClientId,
            string? stabilityClientUserId,
            string? stabilityClientVersion,
            global::StabilityAI.CreateAudioStableAudioTextToAudioRequest request);
        partial void ProcessCreateAudioStableAudioTextToAudioResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAudioStableAudioTextToAudioResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text-to-Audio<br/>
        /// Stable Audio transforms existing audio samples into new high-quality compositions up to six minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb)<br/>
        /// or try Stable Audio for free at [stableaudio.com](https://stableaudio.com).<br/>
        /// This endpoint is asynchronous — it returns a generation `id` immediately (HTTP 202).<br/>
        /// Poll `GET /v2beta/audio/results/{id}` to retrieve the result.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 3.0**<br/>
        /// Flat rate of 26 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `audio/*` to receive the bytes of the audio directly. Otherwise specify `application/json` to receive the audio as base64 encoded JSON.<br/>
        /// Default Value: audio/*
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
        /// import requests, time<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/stable-audio/text-to-audio",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     files={"none": ""},<br/>
        ///     data={<br/>
        ///         "prompt": "A cinematic orchestral piece with sweeping strings and dramatic brass.",<br/>
        ///         "output_format": "mp3",<br/>
        ///         "duration": 30,<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code != 202:<br/>
        ///     raise Exception(str(response.json()))<br/>
        /// generation_id = response.json()["id"]<br/>
        /// while True:<br/>
        ///     result = requests.get(<br/>
        ///         f"https://api.stability.ai/v2beta/audio/results/{generation_id}",<br/>
        ///         headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     )<br/>
        ///     if result.status_code == 202:<br/>
        ///         print("Generation in-progress, retrying in 10 seconds...")<br/>
        ///         time.sleep(10)<br/>
        ///     elif result.status_code == 200:<br/>
        ///         with open("./output.mp3", "wb") as f:<br/>
        ///             f.write(result.content)<br/>
        ///         break<br/>
        ///     else:<br/>
        ///         raise Exception(str(result.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse> CreateAudioStableAudioTextToAudioAsync(
            string contentType,

            global::StabilityAI.CreateAudioStableAudioTextToAudioRequest request,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateAudioStableAudioTextToAudioAsResponseAsync(
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
        /// Text-to-Audio<br/>
        /// Stable Audio transforms existing audio samples into new high-quality compositions up to six minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb)<br/>
        /// or try Stable Audio for free at [stableaudio.com](https://stableaudio.com).<br/>
        /// This endpoint is asynchronous — it returns a generation `id` immediately (HTTP 202).<br/>
        /// Poll `GET /v2beta/audio/results/{id}` to retrieve the result.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 3.0**<br/>
        /// Flat rate of 26 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `audio/*` to receive the bytes of the audio directly. Otherwise specify `application/json` to receive the audio as base64 encoded JSON.<br/>
        /// Default Value: audio/*
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
        /// import requests, time<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/stable-audio/text-to-audio",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     files={"none": ""},<br/>
        ///     data={<br/>
        ///         "prompt": "A cinematic orchestral piece with sweeping strings and dramatic brass.",<br/>
        ///         "output_format": "mp3",<br/>
        ///         "duration": 30,<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code != 202:<br/>
        ///     raise Exception(str(response.json()))<br/>
        /// generation_id = response.json()["id"]<br/>
        /// while True:<br/>
        ///     result = requests.get(<br/>
        ///         f"https://api.stability.ai/v2beta/audio/results/{generation_id}",<br/>
        ///         headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     )<br/>
        ///     if result.status_code == 202:<br/>
        ///         print("Generation in-progress, retrying in 10 seconds...")<br/>
        ///         time.sleep(10)<br/>
        ///     elif result.status_code == 200:<br/>
        ///         with open("./output.mp3", "wb") as f:<br/>
        ///             f.write(result.content)<br/>
        ///         break<br/>
        ///     else:<br/>
        ///         raise Exception(str(result.json()))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse>> CreateAudioStableAudioTextToAudioAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateAudioStableAudioTextToAudioRequest request,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAudioStableAudioTextToAudioArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                accept: ref accept,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAudioStableAudioTextToAudioSecurityRequirements,
                operationName: "CreateAudioStableAudioTextToAudioAsync");

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
                                path: "/v2beta/audio/stable-audio/text-to-audio",
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

                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Model).HasValue ? (request.Model).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"model\"");

                            }
                            if (request.Duration != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Duration, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"duration\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.Steps != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Steps, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"steps\"");

                            }
                            if (request.CfgScale != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.CfgScale, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"cfg_scale\"");

                            }
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.OutputFormat).HasValue ? (request.OutputFormat).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"output_format\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAudioStableAudioTextToAudioRequest(
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
                                operationId: "createAudioStableAudioTextToAudio",
                                methodName: "CreateAudioStableAudioTextToAudioAsync",
                                pathTemplate: "\"/v2beta/audio/stable-audio/text-to-audio\"",
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
                                operationId: "createAudioStableAudioTextToAudio",
                                methodName: "CreateAudioStableAudioTextToAudioAsync",
                                pathTemplate: "\"/v2beta/audio/stable-audio/text-to-audio\"",
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
                                operationId: "createAudioStableAudioTextToAudio",
                                methodName: "CreateAudioStableAudioTextToAudioAsync",
                                pathTemplate: "\"/v2beta/audio/stable-audio/text-to-audio\"",
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
                ProcessCreateAudioStableAudioTextToAudioResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createAudioStableAudioTextToAudio",
                                methodName: "CreateAudioStableAudioTextToAudioAsync",
                                pathTemplate: "\"/v2beta/audio/stable-audio/text-to-audio\"",
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
                                operationId: "createAudioStableAudioTextToAudio",
                                methodName: "CreateAudioStableAudioTextToAudioAsync",
                                pathTemplate: "\"/v2beta/audio/stable-audio/text-to-audio\"",
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
                                global::StabilityAI.CreateAudioStableAudioTextToAudioResponse2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse2>(
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
                            // Your request was well-formed, but rejected. See the `errors` field for details.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::StabilityAI.CreateAudioStableAudioTextToAudioResponse3? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse3.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse3.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse3>(
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
                                global::StabilityAI.CreateAudioStableAudioTextToAudioResponse4? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse4.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse4.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse4>(
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
                                global::StabilityAI.CreateAudioStableAudioTextToAudioResponse5? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse5.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse5.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse5>(
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
                                ProcessCreateAudioStableAudioTextToAudioResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::StabilityAI.CreateAudioStableAudioTextToAudioResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::StabilityAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
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

                                    var __value = await global::StabilityAI.CreateAudioStableAudioTextToAudioResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse>(
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
        /// Text-to-Audio<br/>
        /// Stable Audio transforms existing audio samples into new high-quality compositions up to six minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb)<br/>
        /// or try Stable Audio for free at [stableaudio.com](https://stableaudio.com).<br/>
        /// This endpoint is asynchronous — it returns a generation `id` immediately (HTTP 202).<br/>
        /// Poll `GET /v2beta/audio/results/{id}` to retrieve the result.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 3.0**<br/>
        /// Flat rate of 26 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
        /// </param>
        /// <param name="accept">
        /// Specify `audio/*` to receive the bytes of the audio directly. Otherwise specify `application/json` to receive the audio as base64 encoded JSON.<br/>
        /// Default Value: audio/*
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
        /// What you wish the output audio to be. A strong, descriptive prompt that clearly defines<br/>
        /// instruments, moods, styles, and genre will lead to better results.<br/>
        /// You can make a prompt as simple or complex as you like. Simple prompts are good for clean<br/>
        /// output audio. Complex prompts are good for adding texture and depth to the output audio.
        /// </param>
        /// <param name="model">
        /// The model to use for generation.<br/>
        /// - `stable-audio-3` requires 26 credits per generation<br/>
        /// Default Value: stable-audio-3
        /// </param>
        /// <param name="duration">
        /// Controls the duration in seconds of the generated audio.<br/>
        /// Default Value: 190
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="steps">
        /// Controls the number of sampling steps.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values make your audio closer to your prompt). Defaults to 1 if not specified.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse> CreateAudioStableAudioTextToAudioAsync(
            string contentType,
            string prompt,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel? model = default,
            double? duration = default,
            double? seed = default,
            int? steps = default,
            double? cfgScale = default,
            global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat? outputFormat = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::StabilityAI.CreateAudioStableAudioTextToAudioRequest
            {
                Prompt = prompt,
                Model = model,
                Duration = duration,
                Seed = seed,
                Steps = steps,
                CfgScale = cfgScale,
                OutputFormat = outputFormat,
            };

            return await CreateAudioStableAudioTextToAudioAsync(
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