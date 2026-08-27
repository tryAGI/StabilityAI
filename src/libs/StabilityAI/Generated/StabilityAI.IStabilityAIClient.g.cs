
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Welcome to the Stability.ai REST API!<br/>
    /// Your DreamStudio API key will be required for authentication: [How to find your API key](https://platform.stability.ai/docs/getting-started/authentication)<br/>
    /// API operations use the following versioning scheme:<br/>
    /// - `/v*` interface is stable and ready for production workloads<br/>
    /// - `/v*beta*`: interface is stable, preparing for production release<br/>
    /// - `/v*alpha*`: under development and the interface is subject to change<br/>
    /// NOTE: The v1alpha and v1beta endpoints from the developer preview are still available, but they<br/>
    /// will disabled on May 1st, 2023.  Please migrate to the v1 endpoints as soon as possible.<br/>
    /// If you have feedback or encounter any issues with the API, please reach out:<br/>
    ///   - [https://github.com/Stability-AI/REST-API](https://github.com/Stability-AI/REST-API)<br/>
    ///   - [https://discord.gg/stablediffusion #API channel](https://discord.com/channels/1002292111942635562/1042896447311454361)<br/>
    /// This generated SDK also includes the official REST v2beta Stable Image API from https://api.stability.ai/v2alpha/openapi.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IStabilityAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::StabilityAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::StabilityAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        ///
        /// </summary>
        public AudioResultsClient AudioResults { get; }

        /// <summary>
        /// Tools for generating precise, controlled variations of existing images or sketches.<br/>
        /// **[Sketch](/docs/api-reference#tag/Control/paths/~1v2beta~1stable-image~1control~1sketch/post)**<br/>
        /// This service upgrades sketches to refined outputs with precise control. For non-sketch images, it allows detailed manipulation of the final appearance by leveraging the contour lines and edges within the image.<br/>
        /// **[Structure](/docs/api-reference#tag/Control/paths/~1v2beta~1stable-image~1control~1structure/post)**<br/>
        /// This service excels in generating images by maintaining the structure of an input image, making it especially valuable for advanced content creation scenarios such as recreating scenes or rendering characters from models.<br/>
        /// **[Style](/docs/api-reference#tag/Control/paths/~1v2beta~1stable-image~1control~1style/post)**<br/>
        /// This service extracts stylistic elements from an input image (control image) and uses it to guide the creation of an output image based on the prompt. The result is a new image in the same style as the control image.
        /// </summary>
        public ControlClient Control { get; }

        /// <summary>
        /// Tools for editing your own and generated images.<br/>
        /// **[Erase](/docs/api-reference#tag/Edit/paths/~1v2beta~1stable-image~1edit~1erase/post)**<br/>
        /// The Erase service removes unwanted objects, such as blemishes on portraits or items on desks, using image masks.<br/>
        /// **[Outpaint](/docs/api-reference#tag/Edit/paths/~1v2beta~1stable-image~1edit~1outpaint/post)**<br/>
        /// The outpaint service inserts additional content in an image to fill in the space in any direction, allowing you to "zoom-out" of an image.<br/>
        /// **[Inpaint](/docs/api-reference#tag/Edit/paths/~1v2beta~1stable-image~1edit~1inpaint/post)**<br/>
        /// The Inpaint service modifies images by filling in or replacing specified areas with new content based on the content of a "mask" image.<br/>
        /// **[Search and Replace](/docs/api-reference#tag/Edit/paths/~1v2beta~1stable-image~1edit~1search-and-replace/post)**<br/>
        /// The Search and Replace service, similar to inpaint, allows to replace specified areas with new content, but this time with the help of a prompt instead of a mask. The service will automatically segment the object and replace it with the object requested in the prompt.<br/>
        /// **[Search and Recolor](/docs/api-reference#tag/Edit/paths/~1v2beta~1stable-image~1edit~1search-and-recolor/post)**<br/>
        /// The Search and Recolor service is another derivative of the inpaint service and provides the ability to change the color of a specific object in an image using a prompt. The Search and Recolor service will automatically segment the object and recolor it using the colors requested in the prompt.<br/>
        /// **[Remove Background](/docs/api-reference#tag/Edit/paths/~1v2beta~1stable-image~1edit~1remove-background/post)**<br/>
        /// The Remove Background service accurately segments the foreground from an image to removes the background.
        /// </summary>
        public EditClient Edit { get; }

        /// <summary>
        /// Tools to generate new images from text, or create variations of existing images. Our different services include:<br/>
        /// **[Stable Image Ultra](/docs/api-reference#tag/Generate/paths/~1v2beta~1stable-image~1generate~1ultra/post)**: Photorealistic, Large-Scale Output<br/>
        /// Our state of the art text to image model based on Stable Diffusion 3.5. Stable Image Ultra Produces the highest quality, photorealistic outputs perfect for professional print media and large format applications. Stable Image Ultra excels at rendering exceptional detail and realism.<br/>
        /// **[Stable Image Core](/docs/api-reference#tag/Generate/paths/~1v2beta~1stable-image~1generate~1core/post)**: Fast and Affordable<br/>
        /// Optimized for fast and aﬀordable image generation, great for rapidly iterating on concepts during ideation. Stable Image Core is the next generation model following Stable Diffusion XL.<br/>
        /// **[Stable Diffusion 3.5 Model Suite](/docs/api-reference#tag/Generate/paths/~1v2beta~1stable-image~1generate~1sd3/post)**: Stability AI's latest base models<br/>
        /// The different versions of our open models are available via API, letting you test and adjust speed and quality based on your use case. All model versions strike a balance between generation speed and output quality and are ideal for creating high-volume, high-quality digital assets like websites, newsletters, and marketing materials.
        /// </summary>
        public GenerateClient Generate { get; }

        /// <summary>
        /// Tools for fetching the results of your async generations.
        /// </summary>
        public ResultsClient Results { get; }

        /// <summary>
        /// Stable Audio 3.0. Tools to generate music and sound from text or audio, or transform existing audio clips into new compositions. Our different services include:<br/>
        /// **Stable Audio 3.0**: Fast, Best-Quality, Long-Form Music &amp; Audio Generation<br/>
        /// Our most advanced audio generation model, capable of generating up to 6-minute, 44.1 kHz stereo compositions. Stable Audio 3.0 supports text-to-audio, audio-to-audio, and audio-inpaint workflows - allowing creators to upload a sound and transform it into new instruments, styles, or genres using natural language prompts. Ideal for music production, cinematic sound design, and remixing.<br/>
        /// Stable Audio models were exclusively trained on licensed data from the [AudioSparx](https://www.audiosparx.com/) music library, honoring opt-out requests and ensuring fair compensation for creators. Additionally, Stable Audio 3.0 was pre-trained on licensed data from [Freesound](https://freesound.org/). Read more about the model capabilities [here](https://stability.ai/news/stable-audio-3-0).
        /// </summary>
        public StableAudioClient StableAudio { get; }

        /// <summary>
        /// Stable Audio 2.5. Tools to generate music and sound from text or audio, or transform existing audio clips into new compositions. Our different services include:<br/>
        /// **Stable Audio 2.5**: Fast, Best-Quality, Long-Form Music &amp; Audio Generation<br/>
        /// Our most advanced audio generation model, capable of generating up to 3-minute, 44.1 kHz stereo compositions. Stable Audio 2.5 supports text-to-audio, audio-to-audio, and audio-inpaint workflows - allowing creators to upload a sound and transform it into new instruments, styles, or genres using natural language prompts. Ideal for music production, cinematic sound design, and remixing.<br/>
        /// **Stable Audio 2.0**: High-Quality Audio Generation<br/>
        /// Built for text-to-audio and audio-to-audio generation, also capable of generating up to 3-minute, 44.1 kHz stereo. Stable Audio 2.0 is great for ideation, music demos, and ambient soundscapes. It's optimized for creative professionals seeking detailed and extended outputs from simple prompts.<br/>
        /// Stable Audio models were exclusively trained on licensed data from the [AudioSparx](https://www.audiosparx.com/) music library, honoring opt-out requests and ensuring fair compensation for creators. Additionally, Stable Audio 2.5 was pre-trained on licensed data from [Freesound](https://freesound.org/). Read more about the model capabilities [here](https://stability.ai/news/stable-audio-2-0).
        /// </summary>
        public StableAudio2Client StableAudio2 { get; }

        /// <summary>
        /// Tools for increasing the size and resolution of your existing images.<br/>
        /// **[Fast Upscaler](/docs/api-reference#tag/Upscale/paths/~1v2beta~1stable-image~1upscale~1fast/post)**<br/>
        /// This service enhances image resolution by 4x using predictive and generative AI. This lightweight and fast service (processing in ~1 second) is ideal for enhancing the quality of compressed images, making it suitable for social media posts and other applications.<br/>
        /// **[Conservative Upscaler](/docs/api-reference#tag/Upscale/paths/~1v2beta~1stable-image~1upscale~1conservative/post)**<br/>
        /// This service can upscale images by 20 to 40 times up to a 4 megapixel output image with minimal alteration to the original image. The Conservative Upscaler can upscale images as small as 64x64 pixels directly to a 4 megapixel output. Use this option if you directly need a 4 megapixel output.<br/>
        /// **[Creative Upscaler](/docs/api-reference#tag/Upscale/paths/~1v2beta~1stable-image~1upscale~1creative/post)**<br/>
        /// The service can upscale highly degraded images (lower than 1 megapixel) with a creative twist to provide high resolution results.
        /// </summary>
        public UpscaleClient Upscale { get; }

        /// <summary>
        /// Enumerate available engines.
        /// </summary>
        public V1EnginesClient V1Engines { get; }

        /// <summary>
        /// Generate images from text, existing images, or both.
        /// </summary>
        public V1GenerationClient V1Generation { get; }

        /// <summary>
        /// Manage your Stability.ai account, and view account/organization balances.
        /// </summary>
        public V1UserClient V1User { get; }

        /// <summary>
        ///
        /// </summary>
        public V2alphaGenerationClient V2alphaGeneration { get; }

        /// <summary>
        ///
        /// </summary>
        public x3dClient x3d { get; }

    }
}