
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Tools for editing your own and generated images.<br/>
    /// **[Erase](https://docs.stability.ai/api-reference/edit/erase)**<br/>
    /// The Erase service removes unwanted objects, such as blemishes on portraits or items on desks, using image masks.<br/>
    /// **[Outpaint](https://docs.stability.ai/api-reference/edit/outpaint)**<br/>
    /// The outpaint service inserts additional content in an image to fill in the space in any direction, allowing you to "zoom-out" of an image.<br/>
    /// **[Inpaint](https://docs.stability.ai/api-reference/edit/inpaint)**<br/>
    /// The Inpaint service modifies images by filling in or replacing specified areas with new content based on the content of a "mask" image.<br/>
    /// **[Search and Replace](https://docs.stability.ai/api-reference/edit/search-and-replace)**<br/>
    /// The Search and Replace service, similar to inpaint, allows to replace specified areas with new content, but this time with the help of a prompt instead of a mask. The service will automatically segment the object and replace it with the object requested in the prompt.<br/>
    /// **[Search and Recolor](https://docs.stability.ai/api-reference/edit/search-and-recolor)**<br/>
    /// The Search and Recolor service is another derivative of the inpaint service and provides the ability to change the color of a specific object in an image using a prompt. The Search and Recolor service will automatically segment the object and recolor it using the colors requested in the prompt.<br/>
    /// **[Remove Background](https://docs.stability.ai/api-reference/edit/remove-background)**<br/>
    /// The Remove Background service accurately segments the foreground from an image to removes the background.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEditClient : global::System.IDisposable
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