#nullable enable

namespace StabilityAI
{
    public partial interface Ix3dClient
    {
        /// <summary>
        /// Stable Point Aware 3D<br/>
        /// Stable Point Aware 3D (SPAR3D) can make real-time edits and create the complete structure<br/>
        /// of a 3D object from a single image in a few seconds. SPAR3D combines the strengths of<br/>
        /// point-cloud diffusion (probabilistic) and mesh regression (deterministic) to have improved<br/>
        /// details on the unseen back regions in the input image.<br/>
        /// Compared to our previous model [Stable Fast 3D](#tag/3D/paths/~1v2beta~13d~1stable-fast-3d/post), this new<br/>
        /// one allows editing of backside information using the point cloud representation and also<br/>
        /// leverages a larger Diffusion model to generally improve the depth and backside<br/>
        /// predictions.<br/>
        /// Read more about the model capabilities [here](https://bit.ly/4h7cpgF).<br/>
        /// This API is currently in<br/>
        /// preview. Please don’t hesitate to [contact us](https://stability.ai/contact) with any questions.<br/>
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
        /// - `remesh`<br/>
        /// - `target_type`<br/>
        /// - `target_count`<br/>
        /// - `guidance_scale`<br/>
        /// - `seed`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/3d/stable-point-aware-3d",<br/>
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
        global::System.Threading.Tasks.Task<byte[]> Create3dStablePointAware3dAsync(
            string contentType,

            global::StabilityAI.Create3dStablePointAware3dRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Point Aware 3D<br/>
        /// Stable Point Aware 3D (SPAR3D) can make real-time edits and create the complete structure<br/>
        /// of a 3D object from a single image in a few seconds. SPAR3D combines the strengths of<br/>
        /// point-cloud diffusion (probabilistic) and mesh regression (deterministic) to have improved<br/>
        /// details on the unseen back regions in the input image.<br/>
        /// Compared to our previous model [Stable Fast 3D](#tag/3D/paths/~1v2beta~13d~1stable-fast-3d/post), this new<br/>
        /// one allows editing of backside information using the point cloud representation and also<br/>
        /// leverages a larger Diffusion model to generally improve the depth and backside<br/>
        /// predictions.<br/>
        /// Read more about the model capabilities [here](https://bit.ly/4h7cpgF).<br/>
        /// This API is currently in<br/>
        /// preview. Please don’t hesitate to [contact us](https://stability.ai/contact) with any questions.<br/>
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
        /// - `remesh`<br/>
        /// - `target_type`<br/>
        /// - `target_count`<br/>
        /// - `guidance_scale`<br/>
        /// - `seed`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/3d/stable-point-aware-3d",<br/>
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Create3dStablePointAware3dAsStreamAsync(
            string contentType,

            global::StabilityAI.Create3dStablePointAware3dRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Point Aware 3D<br/>
        /// Stable Point Aware 3D (SPAR3D) can make real-time edits and create the complete structure<br/>
        /// of a 3D object from a single image in a few seconds. SPAR3D combines the strengths of<br/>
        /// point-cloud diffusion (probabilistic) and mesh regression (deterministic) to have improved<br/>
        /// details on the unseen back regions in the input image.<br/>
        /// Compared to our previous model [Stable Fast 3D](#tag/3D/paths/~1v2beta~13d~1stable-fast-3d/post), this new<br/>
        /// one allows editing of backside information using the point cloud representation and also<br/>
        /// leverages a larger Diffusion model to generally improve the depth and backside<br/>
        /// predictions.<br/>
        /// Read more about the model capabilities [here](https://bit.ly/4h7cpgF).<br/>
        /// This API is currently in<br/>
        /// preview. Please don’t hesitate to [contact us](https://stability.ai/contact) with any questions.<br/>
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
        /// - `remesh`<br/>
        /// - `target_type`<br/>
        /// - `target_count`<br/>
        /// - `guidance_scale`<br/>
        /// - `seed`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation. You will not be charged for failed generations.
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
        ///     f"https://api.stability.ai/v2beta/3d/stable-point-aware-3d",<br/>
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
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> Create3dStablePointAware3dAsResponseAsync(
            string contentType,

            global::StabilityAI.Create3dStablePointAware3dRequest request,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Point Aware 3D<br/>
        /// Stable Point Aware 3D (SPAR3D) can make real-time edits and create the complete structure<br/>
        /// of a 3D object from a single image in a few seconds. SPAR3D combines the strengths of<br/>
        /// point-cloud diffusion (probabilistic) and mesh regression (deterministic) to have improved<br/>
        /// details on the unseen back regions in the input image.<br/>
        /// Compared to our previous model [Stable Fast 3D](#tag/3D/paths/~1v2beta~13d~1stable-fast-3d/post), this new<br/>
        /// one allows editing of backside information using the point cloud representation and also<br/>
        /// leverages a larger Diffusion model to generally improve the depth and backside<br/>
        /// predictions.<br/>
        /// Read more about the model capabilities [here](https://bit.ly/4h7cpgF).<br/>
        /// This API is currently in<br/>
        /// preview. Please don’t hesitate to [contact us](https://stability.ai/contact) with any questions.<br/>
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
        /// - `remesh`<br/>
        /// - `target_type`<br/>
        /// - `target_count`<br/>
        /// - `guidance_scale`<br/>
        /// - `seed`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation. You will not be charged for failed generations.
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
        /// Determines the resolution of the textures used for both the albedo (color) map and the<br/>
        /// normal map. The resolution is specified in pixels, and a higher value corresponds to a<br/>
        /// higher level of detail in the textures, allowing for more intricate and precise rendering<br/>
        /// of surfaces. However, increasing the resolution also results in larger asset sizes, which<br/>
        /// may impact loading times and performance. `1024` is a good default value and rarely requires<br/>
        /// changing.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="foregroundRatio">
        /// Controls the amount of padding around the object to be processed within the frame. This<br/>
        /// ratio determines the relative size of the object compared to the total frame size. A<br/>
        /// higher ratio means less padding and a larger object, while a lower ratio increases the<br/>
        /// padding, effectively reducing the object’s size within the frame. This can be useful when<br/>
        /// a long and narrow object, such as a car or bus, is viewed from the front (the narrow<br/>
        /// side). Here, lowering the foreground ratio might help prevent the generated 3D assets from<br/>
        /// appearing squished or distorted. The default value of `1.3` is good for most objects.<br/>
        /// Default Value: 1.3F
        /// </param>
        /// <param name="remesh">
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing algorithm<br/>
        /// determines how the 3D model is constructed from the input image. The default value of<br/>
        /// "none" means that the model is generated without remeshing, which is suitable for most use<br/>
        /// cases. The "triangle" option generates a model with triangular faces, while the "quad"<br/>
        /// option generates a model with quadrilateral faces. The "quad" option is useful when the 3D<br/>
        /// model will be used in DCC tools such as Maya or Blender.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetType">
        /// If set to `vertex` or `face`, the result will have approximately `target_count` many vertices or<br/>
        /// faces in the simplified mesh, respectively.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetCount">
        /// This sets the target vertex or face count defined by `target_type`. Selecting extremely low<br/>
        /// counts reduces the quality of the mesh severely and values of 1,000 - 10,000 are recommended.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="guidanceScale">
        /// This sets the guidance scaling of the point diffusion module. Lower values produce less<br/>
        /// detail and higher can introduce artifacts. The default of `3` produces best results.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Create3dStablePointAware3dAsync(
            string contentType,
            byte[] image,
            string imagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? textureResolution = default,
            double? foregroundRatio = default,
            global::StabilityAI.Create3dStablePointAware3dRequestRemesh? remesh = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTargetType? targetType = default,
            double? targetCount = default,
            double? guidanceScale = default,
            double? seed = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stable Point Aware 3D<br/>
        /// Stable Point Aware 3D (SPAR3D) can make real-time edits and create the complete structure<br/>
        /// of a 3D object from a single image in a few seconds. SPAR3D combines the strengths of<br/>
        /// point-cloud diffusion (probabilistic) and mesh regression (deterministic) to have improved<br/>
        /// details on the unseen back regions in the input image.<br/>
        /// Compared to our previous model [Stable Fast 3D](#tag/3D/paths/~1v2beta~13d~1stable-fast-3d/post), this new<br/>
        /// one allows editing of backside information using the point cloud representation and also<br/>
        /// leverages a larger Diffusion model to generally improve the depth and backside<br/>
        /// predictions.<br/>
        /// Read more about the model capabilities [here](https://bit.ly/4h7cpgF).<br/>
        /// This API is currently in<br/>
        /// preview. Please don’t hesitate to [contact us](https://stability.ai/contact) with any questions.<br/>
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
        /// - `remesh`<br/>
        /// - `target_type`<br/>
        /// - `target_count`<br/>
        /// - `guidance_scale`<br/>
        /// - `seed`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation. You will not be charged for failed generations.
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
        /// Determines the resolution of the textures used for both the albedo (color) map and the<br/>
        /// normal map. The resolution is specified in pixels, and a higher value corresponds to a<br/>
        /// higher level of detail in the textures, allowing for more intricate and precise rendering<br/>
        /// of surfaces. However, increasing the resolution also results in larger asset sizes, which<br/>
        /// may impact loading times and performance. `1024` is a good default value and rarely requires<br/>
        /// changing.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="foregroundRatio">
        /// Controls the amount of padding around the object to be processed within the frame. This<br/>
        /// ratio determines the relative size of the object compared to the total frame size. A<br/>
        /// higher ratio means less padding and a larger object, while a lower ratio increases the<br/>
        /// padding, effectively reducing the object’s size within the frame. This can be useful when<br/>
        /// a long and narrow object, such as a car or bus, is viewed from the front (the narrow<br/>
        /// side). Here, lowering the foreground ratio might help prevent the generated 3D assets from<br/>
        /// appearing squished or distorted. The default value of `1.3` is good for most objects.<br/>
        /// Default Value: 1.3F
        /// </param>
        /// <param name="remesh">
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing algorithm<br/>
        /// determines how the 3D model is constructed from the input image. The default value of<br/>
        /// "none" means that the model is generated without remeshing, which is suitable for most use<br/>
        /// cases. The "triangle" option generates a model with triangular faces, while the "quad"<br/>
        /// option generates a model with quadrilateral faces. The "quad" option is useful when the 3D<br/>
        /// model will be used in DCC tools such as Maya or Blender.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetType">
        /// If set to `vertex` or `face`, the result will have approximately `target_count` many vertices or<br/>
        /// faces in the simplified mesh, respectively.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetCount">
        /// This sets the target vertex or face count defined by `target_type`. Selecting extremely low<br/>
        /// counts reduces the quality of the mesh severely and values of 1,000 - 10,000 are recommended.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="guidanceScale">
        /// This sets the guidance scaling of the point diffusion module. Lower values produce less<br/>
        /// detail and higher can introduce artifacts. The default of `3` produces best results.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/3d/stable-point-aware-3d",<br/>
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
        global::System.Threading.Tasks.Task<byte[]> Create3dStablePointAware3dAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? textureResolution = default,
            double? foregroundRatio = default,
            global::StabilityAI.Create3dStablePointAware3dRequestRemesh? remesh = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTargetType? targetType = default,
            double? targetCount = default,
            double? guidanceScale = default,
            double? seed = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Point Aware 3D<br/>
        /// Stable Point Aware 3D (SPAR3D) can make real-time edits and create the complete structure<br/>
        /// of a 3D object from a single image in a few seconds. SPAR3D combines the strengths of<br/>
        /// point-cloud diffusion (probabilistic) and mesh regression (deterministic) to have improved<br/>
        /// details on the unseen back regions in the input image.<br/>
        /// Compared to our previous model [Stable Fast 3D](#tag/3D/paths/~1v2beta~13d~1stable-fast-3d/post), this new<br/>
        /// one allows editing of backside information using the point cloud representation and also<br/>
        /// leverages a larger Diffusion model to generally improve the depth and backside<br/>
        /// predictions.<br/>
        /// Read more about the model capabilities [here](https://bit.ly/4h7cpgF).<br/>
        /// This API is currently in<br/>
        /// preview. Please don’t hesitate to [contact us](https://stability.ai/contact) with any questions.<br/>
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
        /// - `remesh`<br/>
        /// - `target_type`<br/>
        /// - `target_count`<br/>
        /// - `guidance_scale`<br/>
        /// - `seed`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation. You will not be charged for failed generations.
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
        /// Determines the resolution of the textures used for both the albedo (color) map and the<br/>
        /// normal map. The resolution is specified in pixels, and a higher value corresponds to a<br/>
        /// higher level of detail in the textures, allowing for more intricate and precise rendering<br/>
        /// of surfaces. However, increasing the resolution also results in larger asset sizes, which<br/>
        /// may impact loading times and performance. `1024` is a good default value and rarely requires<br/>
        /// changing.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="foregroundRatio">
        /// Controls the amount of padding around the object to be processed within the frame. This<br/>
        /// ratio determines the relative size of the object compared to the total frame size. A<br/>
        /// higher ratio means less padding and a larger object, while a lower ratio increases the<br/>
        /// padding, effectively reducing the object’s size within the frame. This can be useful when<br/>
        /// a long and narrow object, such as a car or bus, is viewed from the front (the narrow<br/>
        /// side). Here, lowering the foreground ratio might help prevent the generated 3D assets from<br/>
        /// appearing squished or distorted. The default value of `1.3` is good for most objects.<br/>
        /// Default Value: 1.3F
        /// </param>
        /// <param name="remesh">
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing algorithm<br/>
        /// determines how the 3D model is constructed from the input image. The default value of<br/>
        /// "none" means that the model is generated without remeshing, which is suitable for most use<br/>
        /// cases. The "triangle" option generates a model with triangular faces, while the "quad"<br/>
        /// option generates a model with quadrilateral faces. The "quad" option is useful when the 3D<br/>
        /// model will be used in DCC tools such as Maya or Blender.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetType">
        /// If set to `vertex` or `face`, the result will have approximately `target_count` many vertices or<br/>
        /// faces in the simplified mesh, respectively.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetCount">
        /// This sets the target vertex or face count defined by `target_type`. Selecting extremely low<br/>
        /// counts reduces the quality of the mesh severely and values of 1,000 - 10,000 are recommended.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="guidanceScale">
        /// This sets the guidance scaling of the point diffusion module. Lower values produce less<br/>
        /// detail and higher can introduce artifacts. The default of `3` produces best results.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/3d/stable-point-aware-3d",<br/>
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Create3dStablePointAware3dAsStreamAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? textureResolution = default,
            double? foregroundRatio = default,
            global::StabilityAI.Create3dStablePointAware3dRequestRemesh? remesh = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTargetType? targetType = default,
            double? targetCount = default,
            double? guidanceScale = default,
            double? seed = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stable Point Aware 3D<br/>
        /// Stable Point Aware 3D (SPAR3D) can make real-time edits and create the complete structure<br/>
        /// of a 3D object from a single image in a few seconds. SPAR3D combines the strengths of<br/>
        /// point-cloud diffusion (probabilistic) and mesh regression (deterministic) to have improved<br/>
        /// details on the unseen back regions in the input image.<br/>
        /// Compared to our previous model [Stable Fast 3D](#tag/3D/paths/~1v2beta~13d~1stable-fast-3d/post), this new<br/>
        /// one allows editing of backside information using the point cloud representation and also<br/>
        /// leverages a larger Diffusion model to generally improve the depth and backside<br/>
        /// predictions.<br/>
        /// Read more about the model capabilities [here](https://bit.ly/4h7cpgF).<br/>
        /// This API is currently in<br/>
        /// preview. Please don’t hesitate to [contact us](https://stability.ai/contact) with any questions.<br/>
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
        /// - `remesh`<br/>
        /// - `target_type`<br/>
        /// - `target_count`<br/>
        /// - `guidance_scale`<br/>
        /// - `seed`<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Output<br/>
        /// The output is a binary blob that includes a glTF asset, including JSON, buffers, and images.<br/>
        /// See the [GLB File Format Specification](https://registry.khronos.org/glTF/specs/2.0/glTF-2.0.html#glb-file-format-specification) for more details.<br/>
        /// ### Credits<br/>
        /// Flat rate of 4 credits per successful generation. You will not be charged for failed generations.
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
        /// Determines the resolution of the textures used for both the albedo (color) map and the<br/>
        /// normal map. The resolution is specified in pixels, and a higher value corresponds to a<br/>
        /// higher level of detail in the textures, allowing for more intricate and precise rendering<br/>
        /// of surfaces. However, increasing the resolution also results in larger asset sizes, which<br/>
        /// may impact loading times and performance. `1024` is a good default value and rarely requires<br/>
        /// changing.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="foregroundRatio">
        /// Controls the amount of padding around the object to be processed within the frame. This<br/>
        /// ratio determines the relative size of the object compared to the total frame size. A<br/>
        /// higher ratio means less padding and a larger object, while a lower ratio increases the<br/>
        /// padding, effectively reducing the object’s size within the frame. This can be useful when<br/>
        /// a long and narrow object, such as a car or bus, is viewed from the front (the narrow<br/>
        /// side). Here, lowering the foreground ratio might help prevent the generated 3D assets from<br/>
        /// appearing squished or distorted. The default value of `1.3` is good for most objects.<br/>
        /// Default Value: 1.3F
        /// </param>
        /// <param name="remesh">
        /// Controls the remeshing algorithm used to generate the 3D model. The remeshing algorithm<br/>
        /// determines how the 3D model is constructed from the input image. The default value of<br/>
        /// "none" means that the model is generated without remeshing, which is suitable for most use<br/>
        /// cases. The "triangle" option generates a model with triangular faces, while the "quad"<br/>
        /// option generates a model with quadrilateral faces. The "quad" option is useful when the 3D<br/>
        /// model will be used in DCC tools such as Maya or Blender.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetType">
        /// If set to `vertex` or `face`, the result will have approximately `target_count` many vertices or<br/>
        /// faces in the simplified mesh, respectively.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="targetCount">
        /// This sets the target vertex or face count defined by `target_type`. Selecting extremely low<br/>
        /// counts reduces the quality of the mesh severely and values of 1,000 - 10,000 are recommended.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="guidanceScale">
        /// This sets the guidance scaling of the point diffusion module. Lower values produce less<br/>
        /// detail and higher can introduce artifacts. The default of `3` produces best results.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/3d/stable-point-aware-3d",<br/>
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
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<byte[]>> Create3dStablePointAware3dAsResponseAsync(
            string contentType,
            global::System.IO.Stream image,
            string imagename,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTextureResolution? textureResolution = default,
            double? foregroundRatio = default,
            global::StabilityAI.Create3dStablePointAware3dRequestRemesh? remesh = default,
            global::StabilityAI.Create3dStablePointAware3dRequestTargetType? targetType = default,
            double? targetCount = default,
            double? guidanceScale = default,
            double? seed = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}