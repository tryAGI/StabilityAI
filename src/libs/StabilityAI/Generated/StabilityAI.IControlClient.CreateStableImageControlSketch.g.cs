#nullable enable

namespace StabilityAI
{
    public partial interface IControlClient
    {
        /// <summary>
        /// Sketch<br/>
        /// This service offers an ideal solution for design projects that require brainstorming and<br/>
        /// frequent iterations. It upgrades rough hand-drawn sketches to refined outputs with precise<br/>
        /// control. For non-sketch images, it allows detailed manipulation of the final appearance by<br/>
        /// leveraging the contour lines and edges within the image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=ZKIAqHzJzzUo)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `control_strength`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will match that of the input image.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/control/sketch",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./sketch.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a medieval castle on a hill",<br/>
        ///         "control_strength": 0.7,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./castle.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageControlSketchResponse> CreateStableImageControlSketchAsync(
            string contentType,

            global::StabilityAI.CreateStableImageControlSketchRequest request,
            global::StabilityAI.CreateStableImageControlSketchAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sketch<br/>
        /// This service offers an ideal solution for design projects that require brainstorming and<br/>
        /// frequent iterations. It upgrades rough hand-drawn sketches to refined outputs with precise<br/>
        /// control. For non-sketch images, it allows detailed manipulation of the final appearance by<br/>
        /// leveraging the contour lines and edges within the image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=ZKIAqHzJzzUo)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `control_strength`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will match that of the input image.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/control/sketch",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./sketch.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a medieval castle on a hill",<br/>
        ///         "control_strength": 0.7,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./castle.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageControlSketchResponse>> CreateStableImageControlSketchAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageControlSketchRequest request,
            global::StabilityAI.CreateStableImageControlSketchAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sketch<br/>
        /// This service offers an ideal solution for design projects that require brainstorming and<br/>
        /// frequent iterations. It upgrades rough hand-drawn sketches to refined outputs with precise<br/>
        /// control. For non-sketch images, it allows detailed manipulation of the final appearance by<br/>
        /// leveraging the contour lines and edges within the image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=ZKIAqHzJzzUo)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `control_strength`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will match that of the input image.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation. You will not be charged for failed generations.
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
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </param>
        /// <param name="image">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="controlStrength">
        /// How much influence, or control, the `image` has on the generation. Represented as a float between 0 and 1, where 0 is the least influence and 1 is the maximum.<br/>
        /// Default Value: 0.7F
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
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageControlSketchResponse> CreateStableImageControlSketchAsync(
            string contentType,
            string prompt,
            byte[] image,
            string imagename,
            global::StabilityAI.CreateStableImageControlSketchAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            double? controlStrength = default,
            string? negativePrompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageControlSketchRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Sketch<br/>
        /// This service offers an ideal solution for design projects that require brainstorming and<br/>
        /// frequent iterations. It upgrades rough hand-drawn sketches to refined outputs with precise<br/>
        /// control. For non-sketch images, it allows detailed manipulation of the final appearance by<br/>
        /// leveraging the contour lines and edges within the image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=ZKIAqHzJzzUo)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `control_strength`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will match that of the input image.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation. You will not be charged for failed generations.
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
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </param>
        /// <param name="image">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="controlStrength">
        /// How much influence, or control, the `image` has on the generation. Represented as a float between 0 and 1, where 0 is the least influence and 1 is the maximum.<br/>
        /// Default Value: 0.7F
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
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/control/sketch",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./sketch.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a medieval castle on a hill",<br/>
        ///         "control_strength": 0.7,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./castle.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateStableImageControlSketchResponse> CreateStableImageControlSketchAsync(
            string contentType,
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::StabilityAI.CreateStableImageControlSketchAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            double? controlStrength = default,
            string? negativePrompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageControlSketchRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sketch<br/>
        /// This service offers an ideal solution for design projects that require brainstorming and<br/>
        /// frequent iterations. It upgrades rough hand-drawn sketches to refined outputs with precise<br/>
        /// control. For non-sketch images, it allows detailed manipulation of the final appearance by<br/>
        /// leveraging the contour lines and edges within the image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=ZKIAqHzJzzUo)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// - `prompt`<br/>
        /// The body may optionally include:<br/>
        /// - `control_strength`<br/>
        /// - `negative_prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The resolution of the generated image will match that of the input image.<br/>
        /// ### Credits<br/>
        /// Flat rate of 5 credits per successful generation. You will not be charged for failed generations.
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
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
        /// </param>
        /// <param name="image">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Image Dimensions:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - The total pixel count cannot exceed 9,437,184 pixels (e.g. 3072x3072, 4096x2304, etc.)<br/>
        /// Image Aspect Ratio:<br/>
        /// - Must be between 1:2.5 and 2.5:1 (i.e. cannot be too tall or too wide)<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="controlStrength">
        /// How much influence, or control, the `image` has on the generation. Represented as a float between 0 and 1, where 0 is the least influence and 1 is the maximum.<br/>
        /// Default Value: 0.7F
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
        /// <param name="stylePreset">
        /// Guides the image model towards a particular style.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/stable-image/control/sketch",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./sketch.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "a medieval castle on a hill",<br/>
        ///         "control_strength": 0.7,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./castle.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateStableImageControlSketchResponse>> CreateStableImageControlSketchAsResponseAsync(
            string contentType,
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::StabilityAI.CreateStableImageControlSketchAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            double? controlStrength = default,
            string? negativePrompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageControlSketchRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageControlSketchRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}