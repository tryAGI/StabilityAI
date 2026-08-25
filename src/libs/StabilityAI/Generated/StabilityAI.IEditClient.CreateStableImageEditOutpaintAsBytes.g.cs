#nullable enable

namespace StabilityAI
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Outpaint<br/>
        /// The Outpaint service inserts additional content in an image to fill in the space in any direction.<br/>
        /// Compared to other automated or manual attempts to expand the content in an image, the Outpaint service<br/>
        /// should minimize artifacts and signs that the original image has been edited.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=bZ2yK7VQSgLw)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a POST request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// Along with _at least one_ outpaint direction:<br/>
        /// - `left`<br/>
        /// - `right`<br/>
        /// - `up`<br/>
        /// - `down`<br/>
        /// &gt; **Note:** for best quality use outpaint direction values smaller or equal to your source image dimensions.<br/>
        /// Each of these parameters should be set to a number between 0 and 2000, representing the number of pixels to outpaint in that direction.<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation.  You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/outpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "left": 200,<br/>
        ///         "down": 200,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./husky-in-a-huge-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> CreateStableImageEditOutpaintAsBytesAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditOutpaintRequest request,
            global::StabilityAI.CreateStableImageEditOutpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Outpaint<br/>
        /// The Outpaint service inserts additional content in an image to fill in the space in any direction.<br/>
        /// Compared to other automated or manual attempts to expand the content in an image, the Outpaint service<br/>
        /// should minimize artifacts and signs that the original image has been edited.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=bZ2yK7VQSgLw)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a POST request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// Along with _at least one_ outpaint direction:<br/>
        /// - `left`<br/>
        /// - `right`<br/>
        /// - `up`<br/>
        /// - `down`<br/>
        /// &gt; **Note:** for best quality use outpaint direction values smaller or equal to your source image dimensions.<br/>
        /// Each of these parameters should be set to a number between 0 and 2000, representing the number of pixels to outpaint in that direction.<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation.  You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/outpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "left": 200,<br/>
        ///         "down": 200,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./husky-in-a-huge-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateStableImageEditOutpaintAsBytesAsStreamAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditOutpaintRequest request,
            global::StabilityAI.CreateStableImageEditOutpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Outpaint<br/>
        /// The Outpaint service inserts additional content in an image to fill in the space in any direction.<br/>
        /// Compared to other automated or manual attempts to expand the content in an image, the Outpaint service<br/>
        /// should minimize artifacts and signs that the original image has been edited.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=bZ2yK7VQSgLw)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a POST request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// Along with _at least one_ outpaint direction:<br/>
        /// - `left`<br/>
        /// - `right`<br/>
        /// - `up`<br/>
        /// - `down`<br/>
        /// &gt; **Note:** for best quality use outpaint direction values smaller or equal to your source image dimensions.<br/>
        /// Each of these parameters should be set to a number between 0 and 2000, representing the number of pixels to outpaint in that direction.<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation.  You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/outpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "left": 200,<br/>
        ///         "down": 200,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./husky-in-a-huge-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> CreateStableImageEditOutpaintAsBytesAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateStableImageEditOutpaintRequest request,
            global::StabilityAI.CreateStableImageEditOutpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Outpaint<br/>
        /// The Outpaint service inserts additional content in an image to fill in the space in any direction.<br/>
        /// Compared to other automated or manual attempts to expand the content in an image, the Outpaint service<br/>
        /// should minimize artifacts and signs that the original image has been edited.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=bZ2yK7VQSgLw)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a POST request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// Along with _at least one_ outpaint direction:<br/>
        /// - `left`<br/>
        /// - `right`<br/>
        /// - `up`<br/>
        /// - `down`<br/>
        /// &gt; **Note:** for best quality use outpaint direction values smaller or equal to your source image dimensions.<br/>
        /// Each of these parameters should be set to a number between 0 and 2000, representing the number of pixels to outpaint in that direction.<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation.  You will not be charged for failed generations.
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
        /// The image you wish to outpaint.<br/>
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
        /// <param name="imagename">
        /// The image you wish to outpaint.<br/>
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
        /// <param name="left">
        /// The number of pixels to outpaint on the left side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="right">
        /// The number of pixels to outpaint on the right side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="up">
        /// The number of pixels to outpaint on the top of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="down">
        /// The number of pixels to outpaint on the bottom of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity"></param>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
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
        global::System.Threading.Tasks.Task<byte[]> CreateStableImageEditOutpaintAsBytesAsync(
            string contentType,
            byte[] image,
            string imagename,
            global::StabilityAI.CreateStableImageEditOutpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            int? left = default,
            int? right = default,
            int? up = default,
            int? down = default,
            global::StabilityAI.AllOf<double?, object>? creativity = default,
            string? prompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Outpaint<br/>
        /// The Outpaint service inserts additional content in an image to fill in the space in any direction.<br/>
        /// Compared to other automated or manual attempts to expand the content in an image, the Outpaint service<br/>
        /// should minimize artifacts and signs that the original image has been edited.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=bZ2yK7VQSgLw)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a POST request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// Along with _at least one_ outpaint direction:<br/>
        /// - `left`<br/>
        /// - `right`<br/>
        /// - `up`<br/>
        /// - `down`<br/>
        /// &gt; **Note:** for best quality use outpaint direction values smaller or equal to your source image dimensions.<br/>
        /// Each of these parameters should be set to a number between 0 and 2000, representing the number of pixels to outpaint in that direction.<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation.  You will not be charged for failed generations.
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
        /// The image you wish to outpaint.<br/>
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
        /// <param name="imagename">
        /// The image you wish to outpaint.<br/>
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
        /// <param name="left">
        /// The number of pixels to outpaint on the left side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="right">
        /// The number of pixels to outpaint on the right side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="up">
        /// The number of pixels to outpaint on the top of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="down">
        /// The number of pixels to outpaint on the bottom of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity"></param>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/outpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "left": 200,<br/>
        ///         "down": 200,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./husky-in-a-huge-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> CreateStableImageEditOutpaintAsBytesAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            global::StabilityAI.CreateStableImageEditOutpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            int? left = default,
            int? right = default,
            int? up = default,
            int? down = default,
            global::StabilityAI.AllOf<double?, object>? creativity = default,
            string? prompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Outpaint<br/>
        /// The Outpaint service inserts additional content in an image to fill in the space in any direction.<br/>
        /// Compared to other automated or manual attempts to expand the content in an image, the Outpaint service<br/>
        /// should minimize artifacts and signs that the original image has been edited.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=bZ2yK7VQSgLw)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a POST request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// Along with _at least one_ outpaint direction:<br/>
        /// - `left`<br/>
        /// - `right`<br/>
        /// - `up`<br/>
        /// - `down`<br/>
        /// &gt; **Note:** for best quality use outpaint direction values smaller or equal to your source image dimensions.<br/>
        /// Each of these parameters should be set to a number between 0 and 2000, representing the number of pixels to outpaint in that direction.<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation.  You will not be charged for failed generations.
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
        /// The image you wish to outpaint.<br/>
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
        /// <param name="imagename">
        /// The image you wish to outpaint.<br/>
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
        /// <param name="left">
        /// The number of pixels to outpaint on the left side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="right">
        /// The number of pixels to outpaint on the right side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="up">
        /// The number of pixels to outpaint on the top of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="down">
        /// The number of pixels to outpaint on the bottom of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity"></param>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/outpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "left": 200,<br/>
        ///         "down": 200,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./husky-in-a-huge-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateStableImageEditOutpaintAsBytesAsStreamAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            global::StabilityAI.CreateStableImageEditOutpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            int? left = default,
            int? right = default,
            int? up = default,
            int? down = default,
            global::StabilityAI.AllOf<double?, object>? creativity = default,
            string? prompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Outpaint<br/>
        /// The Outpaint service inserts additional content in an image to fill in the space in any direction.<br/>
        /// Compared to other automated or manual attempts to expand the content in an image, the Outpaint service<br/>
        /// should minimize artifacts and signs that the original image has been edited.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Image_API_Public.ipynb#scrollTo=bZ2yK7VQSgLw)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a POST request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`, and the `accept` header should be set to one of the following:<br/>
        ///   - `image/*` to receive the image in the format specified by the `output_format` parameter.<br/>
        ///   - `application/json` to receive the image encoded as base64 in a JSON response.<br/>
        /// The body of the request must include:<br/>
        /// - `image`<br/>
        /// Along with _at least one_ outpaint direction:<br/>
        /// - `left`<br/>
        /// - `right`<br/>
        /// - `up`<br/>
        /// - `down`<br/>
        /// &gt; **Note:** for best quality use outpaint direction values smaller or equal to your source image dimensions.<br/>
        /// Each of these parameters should be set to a number between 0 and 2000, representing the number of pixels to outpaint in that direction.<br/>
        /// Optionally, the body of the request may also include:<br/>
        /// - `prompt`<br/>
        /// - `seed`<br/>
        /// - `output_format`<br/>
        /// - `creativity`<br/>
        /// - `style_preset`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation.  You will not be charged for failed generations.
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
        /// The image you wish to outpaint.<br/>
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
        /// <param name="imagename">
        /// The image you wish to outpaint.<br/>
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
        /// <param name="left">
        /// The number of pixels to outpaint on the left side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="right">
        /// The number of pixels to outpaint on the right side of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="up">
        /// The number of pixels to outpaint on the top of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="down">
        /// The number of pixels to outpaint on the bottom of the image. At least one outpainting direction must be supplied with a non-zero value.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="creativity"></param>
        /// <param name="prompt">
        /// What you wish to see in the output image. A strong, descriptive prompt that clearly defines<br/>
        /// elements, colors, and subjects will lead to better results.<br/>
        /// To control the weight of a given word use the format `(word:weight)`,<br/>
        /// where `word` is the word you'd like to control the weight of and `weight`<br/>
        /// is a value between 0 and 1. For example: `The sky was a crisp (blue:0.3) and (green:0.8)`<br/>
        /// would convey a sky that was blue and green, but more green than blue.
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
        ///     f"https://api.stability.ai/v2beta/stable-image/edit/outpaint",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///         "accept": "image/*"<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./husky-in-a-field.png", "rb")<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "left": 200,<br/>
        ///         "down": 200,<br/>
        ///         "output_format": "webp"<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./husky-in-a-huge-field.webp", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> CreateStableImageEditOutpaintAsBytesAsResponseAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            global::StabilityAI.CreateStableImageEditOutpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            int? left = default,
            int? right = default,
            int? up = default,
            int? down = default,
            global::StabilityAI.AllOf<double?, object>? creativity = default,
            string? prompt = default,
            double? seed = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestOutputFormat? outputFormat = default,
            global::StabilityAI.CreateStableImageEditOutpaintRequestStylePreset? stylePreset = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}