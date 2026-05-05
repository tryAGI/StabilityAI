#nullable enable

namespace StabilityAI
{
    public partial interface IEditClient
    {
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
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse> CreateStableImageEditReplaceBackgroundAndRelightAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>> CreateStableImageEditReplaceBackgroundAndRelightAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse> CreateStableImageEditReplaceBackgroundAndRelightAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse> CreateStableImageEditReplaceBackgroundAndRelightAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageEditReplaceBackgroundAndRelightResponse>> CreateStableImageEditReplaceBackgroundAndRelightAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}