
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Tools for increasing the size and resolution of your existing images.<br/>
    /// **[Fast Upscaler](/docs/api-reference#tag/Upscale/paths/~1v2beta~1stable-image~1upscale~1fast/post)**<br/>
    /// This service enhances image resolution by 4x using predictive and generative AI. This lightweight and fast service (processing in ~1 second) is ideal for enhancing the quality of compressed images, making it suitable for social media posts and other applications.<br/>
    /// **[Conservative Upscaler](/docs/api-reference#tag/Upscale/paths/~1v2beta~1stable-image~1upscale~1conservative/post)**<br/>
    /// This service can upscale images by 20 to 40 times up to a 4 megapixel output image with minimal alteration to the original image. The Conservative Upscaler can upscale images as small as 64x64 pixels directly to a 4 megapixel output. Use this option if you directly need a 4 megapixel output.<br/>
    /// **[Creative Upscaler](/docs/api-reference#tag/Upscale/paths/~1v2beta~1stable-image~1upscale~1creative/post)**<br/>
    /// The service can upscale highly degraded images (lower than 1 megapixel) with a creative twist to provide high resolution results.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IUpscaleClient : global::System.IDisposable
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


    }
}