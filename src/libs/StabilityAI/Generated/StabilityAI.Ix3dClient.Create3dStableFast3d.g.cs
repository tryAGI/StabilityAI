#nullable enable

namespace StabilityAI
{
    public partial interface Ix3dClient
    {
        /// <summary>
        /// Stable Fast 3D<br/>
        /// Stable Fast 3D generates high-quality 3D assets from a single 2D input image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_3D_API.ipynb)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// The body may optionally include:<br/>
        /// - `texture_resolution`<br/>
        /// - `foreground_ratio`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 10 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/3d/stable-fast-3d",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./cat-statue.png", "rb")<br/>
        ///     },<br/>
        ///     data={},<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./3d-cat-statue.glb", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> Create3dStableFast3dAsync(
            string contentType,

            global::StabilityAI.Create3dStableFast3dRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Fast 3D<br/>
        /// Stable Fast 3D generates high-quality 3D assets from a single 2D input image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_3D_API.ipynb)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// The body may optionally include:<br/>
        /// - `texture_resolution`<br/>
        /// - `foreground_ratio`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 10 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/3d/stable-fast-3d",<br/>
        ///     headers={<br/>
        ///         "authorization": f"Bearer sk-MYAPIKEY",<br/>
        ///     },<br/>
        ///     files={<br/>
        ///         "image": open("./cat-statue.png", "rb")<br/>
        ///     },<br/>
        ///     data={},<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./3d-cat-statue.glb", 'wb') as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> Create3dStableFast3dAsResponseAsync(
            string contentType,

            global::StabilityAI.Create3dStableFast3dRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Fast 3D<br/>
        /// Stable Fast 3D generates high-quality 3D assets from a single 2D input image.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_3D_API.ipynb)<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`.<br/>
        /// The body of the request should include:<br/>
        /// - `image`<br/>
        /// The body may optionally include:<br/>
        /// - `texture_resolution`<br/>
        /// - `foreground_ratio`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 10 credits per successful generation. You will not be charged for failed generations.
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
        /// <param name="image">
        /// The image to generate a 3D model from.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 4,194,304 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="imagename">
        /// The image to generate a 3D model from.<br/>
        /// Supported Formats:<br/>
        /// - jpeg<br/>
        /// - png<br/>
        /// - webp<br/>
        /// Validation Rules:<br/>
        /// - Every side must be at least 64 pixels<br/>
        /// - Total pixel count must be between 4,096 and 4,194,304 pixels<br/>
        /// Example: ./some/image.png
        /// </param>
        /// <param name="textureResolution">
        /// Determines the resolution of the textures used for both the albedo (color) map<br/>
        /// and the normal map. The resolution is specified in pixels, and a higher value<br/>
        /// corresponds to a higher level of detail in the textures, allowing for more<br/>
        /// intricate and precise rendering of surfaces. However, increasing the resolution<br/>
        /// also results in larger asset sizes, which may impact loading times and<br/>
        /// performance. 1024 is a good default value and rarely requires changing.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="foregroundRatio">
        /// Controls the amount of padding around the object to be processed within the frame.<br/>
        /// This ratio determines the relative size of the object compared to the total frame<br/>
        /// size. A higher ratio means less padding and a larger object, while a lower ratio<br/>
        /// increases the padding, effectively reducing the object’s size within the frame. This<br/>
        /// can be useful when a long and narrow object, such as a car or bus, is viewed from the<br/>
        /// front (the narrow side). Here, lowering the foreground ratio might help prevent the<br/>
        /// generated 3D assets from appearing squished or distorted. The default value of 0.85<br/>
        /// is good for most objects.<br/>
        /// Default Value: 0.85F
        /// </param>
        /// <param name="remesh">
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing<br/>
        /// algorithm determines how the 3D model is constructed from the input image. The<br/>
        /// default value of "none" means that the model is generated without remeshing,<br/>
        /// which is suitable for most use cases. The "triangle" option generates a model<br/>
        /// with triangular faces, while the "quad" option generates a model with quadrilateral<br/>
        /// faces. The "quad" option is useful when the 3D model will be used in DCC tools such<br/>
        /// as Maya or Blender.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="vertexCount">
        /// If specified, the result will have approximately this many vertices (and consequently fewer faces) in the simplified mesh.<br/>
        /// Setting this value to -1 (the default value) means that a limit is not set.<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Create3dStableFast3dAsync(
            string contentType,
            byte[] image,
            string imagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.Create3dStableFast3dRequestTextureResolution? textureResolution = default,
            double? foregroundRatio = default,
            global::StabilityAI.Create3dStableFast3dRequestRemesh? remesh = default,
            double? vertexCount = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}