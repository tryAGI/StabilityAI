
#nullable enable

namespace StabilityAI
{
    public partial class EditClient
    {


        private static readonly global::StabilityAI.EndPointSecurityRequirement s_CreateStableImageEditReplaceBackgroundAndRelightSecurityRequirement0 =
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
        private static readonly global::StabilityAI.EndPointSecurityRequirement[] s_CreateStableImageEditReplaceBackgroundAndRelightSecurityRequirements =
            new global::StabilityAI.EndPointSecurityRequirement[]
            {                s_CreateStableImageEditReplaceBackgroundAndRelightSecurityRequirement0,
            };
        partial void PrepareCreateStableImageEditReplaceBackgroundAndRelightArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string contentType,
            ref string? stabilityClientId,
            ref string? stabilityClientUserId,
            ref string? stabilityClientVersion,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest request);
        partial void PrepareCreateStableImageEditReplaceBackgroundAndRelightRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string contentType,
            string? stabilityClientId,
            string? stabilityClientUserId,
            string? stabilityClientVersion,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest request);
        partial void ProcessCreateStableImageEditReplaceBackgroundAndRelightResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateStableImageEditReplaceBackgroundAndRelightResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Replace Background and Relight (async)<br/>
        /// The Replace Background and Relight edit service lets users swap backgrounds with<br/>
        /// AI-generated or uploaded images while adjusting lighting to match the subject. This<br/>
        /// new API provides a streamlined image editing solution and can serve e-commerce, real<br/>
        /// estate, photography, and creative projects.<br/>
        /// Some of the things you can do include:<br/>
        ///   - Background Replacement: Remove existing background and add new ones.<br/>
        ///   - AI Background Generation: Create new backgrounds using AI generated images based on prompts.<br/>
        ///   - Relighting: Adjust lighting in images that are under or overexposed.<br/>
        ///   - Flexible Inputs: Use your own background image or generate one.<br/>
        ///   - Lighting Adjustments: Modify light reference, direction, and strength.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=mtgSh4Stj3l)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `subject_image`<br/>
        /// - `background_prompt` and/or `background_reference`<br/>
        /// The body may optionally include:<br/>
        /// - `light_reference` or `light_source_direction`<br/>
        /// - `light_source_strength` (requires `light_reference` or `light_source_direction`)<br/>
        /// - `foreground_prompt`<br/>
        /// - `negative_prompt`<br/>
        /// - `preserve_original_subject`<br/>
        /// - `original_background_depth`<br/>
        /// - `keep_original_background`<br/>
        /// - `light_source_strength`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 8 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/replace-background-and-relight",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "subject_image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "background_prompt": "cinematic lighting",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse> CreateStableImageEditReplaceBackgroundAndRelightAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateStableImageEditReplaceBackgroundAndRelightAsResponseAsync(
                contentType: contentType,

                request: request,
                stabilityClientId: stabilityClientId,
                stabilityClientUserId: stabilityClientUserId,
                stabilityClientVersion: stabilityClientVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Replace Background and Relight (async)<br/>
        /// The Replace Background and Relight edit service lets users swap backgrounds with<br/>
        /// AI-generated or uploaded images while adjusting lighting to match the subject. This<br/>
        /// new API provides a streamlined image editing solution and can serve e-commerce, real<br/>
        /// estate, photography, and creative projects.<br/>
        /// Some of the things you can do include:<br/>
        ///   - Background Replacement: Remove existing background and add new ones.<br/>
        ///   - AI Background Generation: Create new backgrounds using AI generated images based on prompts.<br/>
        ///   - Relighting: Adjust lighting in images that are under or overexposed.<br/>
        ///   - Flexible Inputs: Use your own background image or generate one.<br/>
        ///   - Lighting Adjustments: Modify light reference, direction, and strength.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=mtgSh4Stj3l)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `subject_image`<br/>
        /// - `background_prompt` and/or `background_reference`<br/>
        /// The body may optionally include:<br/>
        /// - `light_reference` or `light_source_direction`<br/>
        /// - `light_source_strength` (requires `light_reference` or `light_source_direction`)<br/>
        /// - `foreground_prompt`<br/>
        /// - `negative_prompt`<br/>
        /// - `preserve_original_subject`<br/>
        /// - `original_background_depth`<br/>
        /// - `keep_original_background`<br/>
        /// - `light_source_strength`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 8 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/replace-background-and-relight",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "subject_image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "background_prompt": "cinematic lighting",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>> CreateStableImageEditReplaceBackgroundAndRelightAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateStableImageEditReplaceBackgroundAndRelightArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStableImageEditReplaceBackgroundAndRelightSecurityRequirements,
                operationName: "CreateStableImageEditReplaceBackgroundAndRelightAsync");

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
                                path: "/v2beta/stable-image/edit/replace-background-and-relight",
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
                            var __contentSubjectImage = new global::System.Net.Http.ByteArrayContent(request.SubjectImage ?? global::System.Array.Empty<byte>());
                            __contentSubjectImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.SubjectImagename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.SubjectImagename) ?? string.Empty).ToLowerInvariant() switch
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
                                content: __contentSubjectImage,
                                name: "\"subject_image\"",
                                fileName: request.SubjectImagename != null ? $"\"{request.SubjectImagename}\"" : string.Empty);
                            if (__contentSubjectImage.Headers.ContentDisposition != null)
                            {
                                __contentSubjectImage.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (request.BackgroundReference != default)
                            {

                                var __contentBackgroundReference = new global::System.Net.Http.ByteArrayContent(request.BackgroundReference ?? global::System.Array.Empty<byte>());
                                __contentBackgroundReference.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.BackgroundReferencename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.BackgroundReferencename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentBackgroundReference,
                                    name: "\"background_reference\"",
                                    fileName: request.BackgroundReferencename != null ? $"\"{request.BackgroundReferencename}\"" : string.Empty);
                                if (__contentBackgroundReference.Headers.ContentDisposition != null)
                                {
                                    __contentBackgroundReference.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.BackgroundPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.BackgroundPrompt ?? string.Empty),
                                    name: "\"background_prompt\"");

                            }
                            if (request.ForegroundPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ForegroundPrompt ?? string.Empty),
                                    name: "\"foreground_prompt\"");

                            }
                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");

                            }
                            if (request.PreserveOriginalSubject != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.PreserveOriginalSubject, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"preserve_original_subject\"");

                            }
                            if (request.OriginalBackgroundDepth != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OriginalBackgroundDepth, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"original_background_depth\"");

                            }
                            if (request.KeepOriginalBackground != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.KeepOriginalBackground).HasValue ? (request.KeepOriginalBackground).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"keep_original_background\"");

                            }
                            if (request.LightSourceDirection != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.LightSourceDirection).HasValue ? (request.LightSourceDirection).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"light_source_direction\"");

                            }
                            if (request.LightReference != default)
                            {

                                var __contentLightReference = new global::System.Net.Http.ByteArrayContent(request.LightReference ?? global::System.Array.Empty<byte>());
                                __contentLightReference.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.LightReferencename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.LightReferencename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentLightReference,
                                    name: "\"light_reference\"",
                                    fileName: request.LightReferencename != null ? $"\"{request.LightReferencename}\"" : string.Empty);
                                if (__contentLightReference.Headers.ContentDisposition != null)
                                {
                                    __contentLightReference.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.LightSourceStrength != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LightSourceStrength, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"light_source_strength\"");

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

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStableImageEditReplaceBackgroundAndRelightRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    contentType: contentType!,
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                ProcessCreateStableImageEditReplaceBackgroundAndRelightResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6>(
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
                                ProcessCreateStableImageEditReplaceBackgroundAndRelightResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>(
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

                                    var __value = await global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>(
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
        /// Replace Background and Relight (async)<br/>
        /// The Replace Background and Relight edit service lets users swap backgrounds with<br/>
        /// AI-generated or uploaded images while adjusting lighting to match the subject. This<br/>
        /// new API provides a streamlined image editing solution and can serve e-commerce, real<br/>
        /// estate, photography, and creative projects.<br/>
        /// Some of the things you can do include:<br/>
        ///   - Background Replacement: Remove existing background and add new ones.<br/>
        ///   - AI Background Generation: Create new backgrounds using AI generated images based on prompts.<br/>
        ///   - Relighting: Adjust lighting in images that are under or overexposed.<br/>
        ///   - Flexible Inputs: Use your own background image or generate one.<br/>
        ///   - Lighting Adjustments: Modify light reference, direction, and strength.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=mtgSh4Stj3l)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `subject_image`<br/>
        /// - `background_prompt` and/or `background_reference`<br/>
        /// The body may optionally include:<br/>
        /// - `light_reference` or `light_source_direction`<br/>
        /// - `light_source_strength` (requires `light_reference` or `light_source_direction`)<br/>
        /// - `foreground_prompt`<br/>
        /// - `negative_prompt`<br/>
        /// - `preserve_original_subject`<br/>
        /// - `original_background_depth`<br/>
        /// - `keep_original_background`<br/>
        /// - `light_source_strength`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 8 credits per successful generation. You will not be charged for failed generations.
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
        /// <param name="subjectImage">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="subjectImagename">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="backgroundReference">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundReferencename">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundPrompt">
        /// What you wish to see in the background of the output image. This could be a description<br/>
        /// of the desired background scene, or just a description of the lighting if modifying the<br/>
        /// light source through `light_source_direction` or `light_reference`.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.
        /// </param>
        /// <param name="foregroundPrompt">
        /// Description of the subject. Use this to prevent elements of the background from<br/>
        /// bleeding into the subject. For example, if you find your subject is turning<br/>
        /// green with a forest in the background, try putting a short description of the<br/>
        /// subject in this field.
        /// </param>
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="preserveOriginalSubject">
        /// How much to overlay the original subject to exactly match the original image. A<br/>
        /// 1.0 is an exact pixel match for the subject, and 0.0 is a close match but will<br/>
        /// have new lighting qualities. This is an advanced feature.<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="originalBackgroundDepth">
        /// Controls the generated background to have the same depth as the original subject image. This is an advanced feature.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="keepOriginalBackground">
        /// Whether to keep the background of the original image. When this is on, the background<br/>
        /// will have different lighting than the original image that changes based on the other<br/>
        /// parameters in this API.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="lightSourceDirection">
        /// Direction of the light source.
        /// </param>
        /// <param name="lightReference">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightReferencename">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightSourceStrength">
        /// If using `light_reference_image` or `light_source_direction`, controls the strength<br/>
        /// of the light source. 1.0 is brighter and 0.0 is dimmer. This is an advanced feature.<br/>
        /// &gt; **Important:** Use of this parameter requires `light_reference` or `light_source_direction` to be provided.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse> CreateStableImageEditReplaceBackgroundAndRelightAsync(
            string contentType,
            byte[] subjectImage,
            string subjectImagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            byte[]? backgroundReference = default,
            string? backgroundReferencename = default,
            string? backgroundPrompt = default,
            string? foregroundPrompt = default,
            string? negativePrompt = default,
            double? preserveOriginalSubject = default,
            double? originalBackgroundDepth = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? keepOriginalBackground = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? lightSourceDirection = default,
            byte[]? lightReference = default,
            string? lightReferencename = default,
            double? lightSourceStrength = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? outputFormat = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest
            {
                SubjectImage = subjectImage,
                SubjectImagename = subjectImagename,
                BackgroundReference = backgroundReference,
                BackgroundReferencename = backgroundReferencename,
                BackgroundPrompt = backgroundPrompt,
                ForegroundPrompt = foregroundPrompt,
                NegativePrompt = negativePrompt,
                PreserveOriginalSubject = preserveOriginalSubject,
                OriginalBackgroundDepth = originalBackgroundDepth,
                KeepOriginalBackground = keepOriginalBackground,
                LightSourceDirection = lightSourceDirection,
                LightReference = lightReference,
                LightReferencename = lightReferencename,
                LightSourceStrength = lightSourceStrength,
                Seed = seed,
                OutputFormat = outputFormat,
            };

            return await CreateStableImageEditReplaceBackgroundAndRelightAsync(
                contentType: contentType,
                stabilityClientId: stabilityClientId,
                stabilityClientUserId: stabilityClientUserId,
                stabilityClientVersion: stabilityClientVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Replace Background and Relight (async)<br/>
        /// The Replace Background and Relight edit service lets users swap backgrounds with<br/>
        /// AI-generated or uploaded images while adjusting lighting to match the subject. This<br/>
        /// new API provides a streamlined image editing solution and can serve e-commerce, real<br/>
        /// estate, photography, and creative projects.<br/>
        /// Some of the things you can do include:<br/>
        ///   - Background Replacement: Remove existing background and add new ones.<br/>
        ///   - AI Background Generation: Create new backgrounds using AI generated images based on prompts.<br/>
        ///   - Relighting: Adjust lighting in images that are under or overexposed.<br/>
        ///   - Flexible Inputs: Use your own background image or generate one.<br/>
        ///   - Lighting Adjustments: Modify light reference, direction, and strength.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=mtgSh4Stj3l)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `subject_image`<br/>
        /// - `background_prompt` and/or `background_reference`<br/>
        /// The body may optionally include:<br/>
        /// - `light_reference` or `light_source_direction`<br/>
        /// - `light_source_strength` (requires `light_reference` or `light_source_direction`)<br/>
        /// - `foreground_prompt`<br/>
        /// - `negative_prompt`<br/>
        /// - `preserve_original_subject`<br/>
        /// - `original_background_depth`<br/>
        /// - `keep_original_background`<br/>
        /// - `light_source_strength`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 8 credits per successful generation. You will not be charged for failed generations.
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
        /// <param name="subjectImage">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="subjectImagename">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="backgroundReference">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundReferencename">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundPrompt">
        /// What you wish to see in the background of the output image. This could be a description<br/>
        /// of the desired background scene, or just a description of the lighting if modifying the<br/>
        /// light source through `light_source_direction` or `light_reference`.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.
        /// </param>
        /// <param name="foregroundPrompt">
        /// Description of the subject. Use this to prevent elements of the background from<br/>
        /// bleeding into the subject. For example, if you find your subject is turning<br/>
        /// green with a forest in the background, try putting a short description of the<br/>
        /// subject in this field.
        /// </param>
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="preserveOriginalSubject">
        /// How much to overlay the original subject to exactly match the original image. A<br/>
        /// 1.0 is an exact pixel match for the subject, and 0.0 is a close match but will<br/>
        /// have new lighting qualities. This is an advanced feature.<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="originalBackgroundDepth">
        /// Controls the generated background to have the same depth as the original subject image. This is an advanced feature.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="keepOriginalBackground">
        /// Whether to keep the background of the original image. When this is on, the background<br/>
        /// will have different lighting than the original image that changes based on the other<br/>
        /// parameters in this API.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="lightSourceDirection">
        /// Direction of the light source.
        /// </param>
        /// <param name="lightReference">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightReferencename">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightSourceStrength">
        /// If using `light_reference_image` or `light_source_direction`, controls the strength<br/>
        /// of the light source. 1.0 is brighter and 0.0 is dimmer. This is an advanced feature.<br/>
        /// &gt; **Important:** Use of this parameter requires `light_reference` or `light_source_direction` to be provided.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/replace-background-and-relight",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "subject_image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "background_prompt": "cinematic lighting",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse> CreateStableImageEditReplaceBackgroundAndRelightAsync(
            string contentType,
            global::System.IO.Stream subjectImage,
            string subjectImagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::System.IO.Stream? backgroundReference = default,
            string? backgroundReferencename = default,
            string? backgroundPrompt = default,
            string? foregroundPrompt = default,
            string? negativePrompt = default,
            double? preserveOriginalSubject = default,
            double? originalBackgroundDepth = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? keepOriginalBackground = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? lightSourceDirection = default,
            global::System.IO.Stream? lightReference = default,
            string? lightReferencename = default,
            double? lightSourceStrength = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? outputFormat = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            subjectImage = subjectImage ?? throw new global::System.ArgumentNullException(nameof(subjectImage));
            var request = new global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest
            {
                SubjectImage = global::System.Array.Empty<byte>(),
                SubjectImagename = subjectImagename,
                BackgroundReference = global::System.Array.Empty<byte>(),
                BackgroundReferencename = backgroundReferencename,
                BackgroundPrompt = backgroundPrompt,
                ForegroundPrompt = foregroundPrompt,
                NegativePrompt = negativePrompt,
                PreserveOriginalSubject = preserveOriginalSubject,
                OriginalBackgroundDepth = originalBackgroundDepth,
                KeepOriginalBackground = keepOriginalBackground,
                LightSourceDirection = lightSourceDirection,
                LightReference = global::System.Array.Empty<byte>(),
                LightReferencename = lightReferencename,
                LightSourceStrength = lightSourceStrength,
                Seed = seed,
                OutputFormat = outputFormat,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateStableImageEditReplaceBackgroundAndRelightArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStableImageEditReplaceBackgroundAndRelightSecurityRequirements,
                operationName: "CreateStableImageEditReplaceBackgroundAndRelightAsync");

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
                                path: "/v2beta/stable-image/edit/replace-background-and-relight",
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
                            var __contentSubjectImage = new global::System.Net.Http.StreamContent(subjectImage);
                            __contentSubjectImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.SubjectImagename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.SubjectImagename) ?? string.Empty).ToLowerInvariant() switch
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
                                content: __contentSubjectImage,
                                name: "\"subject_image\"",
                                fileName: request.SubjectImagename != null ? $"\"{request.SubjectImagename}\"" : string.Empty);
                            if (__contentSubjectImage.Headers.ContentDisposition != null)
                            {
                                __contentSubjectImage.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (backgroundReference != default)
                            {

                                var __contentBackgroundReference = new global::System.Net.Http.StreamContent(backgroundReference);
                                __contentBackgroundReference.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.BackgroundReferencename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.BackgroundReferencename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentBackgroundReference,
                                    name: "\"background_reference\"",
                                    fileName: request.BackgroundReferencename != null ? $"\"{request.BackgroundReferencename}\"" : string.Empty);
                                if (__contentBackgroundReference.Headers.ContentDisposition != null)
                                {
                                    __contentBackgroundReference.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.BackgroundPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.BackgroundPrompt ?? string.Empty),
                                    name: "\"background_prompt\"");

                            }
                            if (request.ForegroundPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ForegroundPrompt ?? string.Empty),
                                    name: "\"foreground_prompt\"");

                            }
                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");

                            }
                            if (request.PreserveOriginalSubject != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.PreserveOriginalSubject, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"preserve_original_subject\"");

                            }
                            if (request.OriginalBackgroundDepth != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OriginalBackgroundDepth, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"original_background_depth\"");

                            }
                            if (request.KeepOriginalBackground != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.KeepOriginalBackground).HasValue ? (request.KeepOriginalBackground).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"keep_original_background\"");

                            }
                            if (request.LightSourceDirection != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.LightSourceDirection).HasValue ? (request.LightSourceDirection).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"light_source_direction\"");

                            }
                            if (lightReference != default)
                            {

                                var __contentLightReference = new global::System.Net.Http.StreamContent(lightReference);
                                __contentLightReference.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.LightReferencename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.LightReferencename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentLightReference,
                                    name: "\"light_reference\"",
                                    fileName: request.LightReferencename != null ? $"\"{request.LightReferencename}\"" : string.Empty);
                                if (__contentLightReference.Headers.ContentDisposition != null)
                                {
                                    __contentLightReference.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.LightSourceStrength != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LightSourceStrength, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"light_source_strength\"");

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

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStableImageEditReplaceBackgroundAndRelightRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    contentType: contentType!,
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                ProcessCreateStableImageEditReplaceBackgroundAndRelightResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6>(
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
                                ProcessCreateStableImageEditReplaceBackgroundAndRelightResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        await global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Replace Background and Relight (async)<br/>
        /// The Replace Background and Relight edit service lets users swap backgrounds with<br/>
        /// AI-generated or uploaded images while adjusting lighting to match the subject. This<br/>
        /// new API provides a streamlined image editing solution and can serve e-commerce, real<br/>
        /// estate, photography, and creative projects.<br/>
        /// Some of the things you can do include:<br/>
        ///   - Background Replacement: Remove existing background and add new ones.<br/>
        ///   - AI Background Generation: Create new backgrounds using AI generated images based on prompts.<br/>
        ///   - Relighting: Adjust lighting in images that are under or overexposed.<br/>
        ///   - Flexible Inputs: Use your own background image or generate one.<br/>
        ///   - Lighting Adjustments: Modify light reference, direction, and strength.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=mtgSh4Stj3l)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `subject_image`<br/>
        /// - `background_prompt` and/or `background_reference`<br/>
        /// The body may optionally include:<br/>
        /// - `light_reference` or `light_source_direction`<br/>
        /// - `light_source_strength` (requires `light_reference` or `light_source_direction`)<br/>
        /// - `foreground_prompt`<br/>
        /// - `negative_prompt`<br/>
        /// - `preserve_original_subject`<br/>
        /// - `original_background_depth`<br/>
        /// - `keep_original_background`<br/>
        /// - `light_source_strength`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Results<br/>
        /// After invoking this endpoint with the required parameters, use the `id` in the response to poll for results at the<br/>
        /// [results/{id} endpoint](#tag/Results/paths/~1v2beta~1results~1%7Bid%7D/get).  Rate-limiting or other errors may occur if you poll more than once every 10 seconds.<br/>
        /// ### Credits<br/>
        /// Flat rate of 8 credits per successful generation. You will not be charged for failed generations.
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
        /// <param name="subjectImage">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="subjectImagename">
        /// An image containing the subject that you wish to change background and relight.<br/>
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
        /// <param name="backgroundReference">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundReferencename">
        /// An image whose style you wish to use in the background. Similar to the Control: Style API,<br/>
        /// stylistic elements from this image are added to the background.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="backgroundPrompt">
        /// What you wish to see in the background of the output image. This could be a description<br/>
        /// of the desired background scene, or just a description of the lighting if modifying the<br/>
        /// light source through `light_source_direction` or `light_reference`.<br/>
        /// &gt; **Important:** either `background_reference` or `background_prompt` must be provided.
        /// </param>
        /// <param name="foregroundPrompt">
        /// Description of the subject. Use this to prevent elements of the background from<br/>
        /// bleeding into the subject. For example, if you find your subject is turning<br/>
        /// green with a forest in the background, try putting a short description of the<br/>
        /// subject in this field.
        /// </param>
        /// <param name="negativePrompt">
        /// A blurb of text describing what you **do not** wish to see in the output image.<br/>
        /// This is an advanced feature.
        /// </param>
        /// <param name="preserveOriginalSubject">
        /// How much to overlay the original subject to exactly match the original image. A<br/>
        /// 1.0 is an exact pixel match for the subject, and 0.0 is a close match but will<br/>
        /// have new lighting qualities. This is an advanced feature.<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="originalBackgroundDepth">
        /// Controls the generated background to have the same depth as the original subject image. This is an advanced feature.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="keepOriginalBackground">
        /// Whether to keep the background of the original image. When this is on, the background<br/>
        /// will have different lighting than the original image that changes based on the other<br/>
        /// parameters in this API.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="lightSourceDirection">
        /// Direction of the light source.
        /// </param>
        /// <param name="lightReference">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightReferencename">
        /// An image with the desired lighting. Lighter sections of the light_reference image will correspond to sections with brighter lighting in the output image.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 9,437,184 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="lightSourceStrength">
        /// If using `light_reference_image` or `light_source_direction`, controls the strength<br/>
        /// of the light source. 1.0 is brighter and 0.0 is dimmer. This is an advanced feature.<br/>
        /// &gt; **Important:** Use of this parameter requires `light_reference` or `light_source_direction` to be provided.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated image.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/replace-background-and-relight",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "subject_image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "background_prompt": "cinematic lighting",<br/>
        ///         "output_format": "webp",<br/>
        ///     },<br/>
        /// )<br/>
        /// print("Generation ID:", response.json().get('id'))
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>> CreateStableImageEditReplaceBackgroundAndRelightAsResponseAsync(
            string contentType,
            global::System.IO.Stream subjectImage,
            string subjectImagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::System.IO.Stream? backgroundReference = default,
            string? backgroundReferencename = default,
            string? backgroundPrompt = default,
            string? foregroundPrompt = default,
            string? negativePrompt = default,
            double? preserveOriginalSubject = default,
            double? originalBackgroundDepth = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestKeepOriginalBackground? keepOriginalBackground = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestLightSourceDirection? lightSourceDirection = default,
            global::System.IO.Stream? lightReference = default,
            string? lightReferencename = default,
            double? lightSourceStrength = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequestOutputFormat? outputFormat = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            subjectImage = subjectImage ?? throw new global::System.ArgumentNullException(nameof(subjectImage));
            var request = new global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest
            {
                SubjectImage = global::System.Array.Empty<byte>(),
                SubjectImagename = subjectImagename,
                BackgroundReference = global::System.Array.Empty<byte>(),
                BackgroundReferencename = backgroundReferencename,
                BackgroundPrompt = backgroundPrompt,
                ForegroundPrompt = foregroundPrompt,
                NegativePrompt = negativePrompt,
                PreserveOriginalSubject = preserveOriginalSubject,
                OriginalBackgroundDepth = originalBackgroundDepth,
                KeepOriginalBackground = keepOriginalBackground,
                LightSourceDirection = lightSourceDirection,
                LightReference = global::System.Array.Empty<byte>(),
                LightReferencename = lightReferencename,
                LightSourceStrength = lightSourceStrength,
                Seed = seed,
                OutputFormat = outputFormat,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateStableImageEditReplaceBackgroundAndRelightArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                stabilityClientId: ref stabilityClientId,
                stabilityClientUserId: ref stabilityClientUserId,
                stabilityClientVersion: ref stabilityClientVersion,
                request: request);


            var __authorizations = global::StabilityAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStableImageEditReplaceBackgroundAndRelightSecurityRequirements,
                operationName: "CreateStableImageEditReplaceBackgroundAndRelightAsync");

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
                                path: "/v2beta/stable-image/edit/replace-background-and-relight",
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
                            var __contentSubjectImage = new global::System.Net.Http.StreamContent(subjectImage);
                            __contentSubjectImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.SubjectImagename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.SubjectImagename) ?? string.Empty).ToLowerInvariant() switch
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
                                content: __contentSubjectImage,
                                name: "\"subject_image\"",
                                fileName: request.SubjectImagename != null ? $"\"{request.SubjectImagename}\"" : string.Empty);
                            if (__contentSubjectImage.Headers.ContentDisposition != null)
                            {
                                __contentSubjectImage.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (backgroundReference != default)
                            {

                                var __contentBackgroundReference = new global::System.Net.Http.StreamContent(backgroundReference);
                                __contentBackgroundReference.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.BackgroundReferencename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.BackgroundReferencename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentBackgroundReference,
                                    name: "\"background_reference\"",
                                    fileName: request.BackgroundReferencename != null ? $"\"{request.BackgroundReferencename}\"" : string.Empty);
                                if (__contentBackgroundReference.Headers.ContentDisposition != null)
                                {
                                    __contentBackgroundReference.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.BackgroundPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.BackgroundPrompt ?? string.Empty),
                                    name: "\"background_prompt\"");

                            }
                            if (request.ForegroundPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ForegroundPrompt ?? string.Empty),
                                    name: "\"foreground_prompt\"");

                            }
                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");

                            }
                            if (request.PreserveOriginalSubject != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.PreserveOriginalSubject, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"preserve_original_subject\"");

                            }
                            if (request.OriginalBackgroundDepth != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.OriginalBackgroundDepth, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"original_background_depth\"");

                            }
                            if (request.KeepOriginalBackground != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.KeepOriginalBackground).HasValue ? (request.KeepOriginalBackground).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"keep_original_background\"");

                            }
                            if (request.LightSourceDirection != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.LightSourceDirection).HasValue ? (request.LightSourceDirection).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"light_source_direction\"");

                            }
                            if (lightReference != default)
                            {

                                var __contentLightReference = new global::System.Net.Http.StreamContent(lightReference);
                                __contentLightReference.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.LightReferencename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.LightReferencename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentLightReference,
                                    name: "\"light_reference\"",
                                    fileName: request.LightReferencename != null ? $"\"{request.LightReferencename}\"" : string.Empty);
                                if (__contentLightReference.Headers.ContentDisposition != null)
                                {
                                    __contentLightReference.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.LightSourceStrength != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LightSourceStrength, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"light_source_strength\"");

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

                            __httpRequest.Content = __httpRequestContent;

                global::StabilityAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateStableImageEditReplaceBackgroundAndRelightRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    contentType: contentType!,
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                ProcessCreateStableImageEditReplaceBackgroundAndRelightResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::StabilityAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::StabilityAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                operationId: "createStableImageEditReplaceBackgroundAndRelight",
                                methodName: "CreateStableImageEditReplaceBackgroundAndRelightAsync",
                                pathTemplate: "\"/v2beta/stable-image/edit/replace-background-and-relight\"",
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse2>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse3>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse4>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse5>(
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
                                global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }

                                throw new global::StabilityAI.ApiException<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse6>(
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
                                ProcessCreateStableImageEditReplaceBackgroundAndRelightResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>(
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

                                    var __value = await global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>(
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
    }
}