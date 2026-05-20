#nullable enable

namespace StabilityAI
{
    public partial interface IAudioResultsClient
    {
        /// <summary>
        /// Fetch Audio Result<br/>
        /// Fetch the result of an audio generation by ID.<br/>
        /// Poll this endpoint after starting an async audio generation. Returns `202` while<br/>
        /// in-progress, `200` with the audio when complete.
        /// </summary>
        /// <param name="id">
        /// The `id` of a generation, typically used for async generations, that can be used to check the status of the generation or retrieve the result.<br/>
        /// Example: a6dc6c6e20acda010fe14d71f180658f2896ed9b4ec25aa99a6ff06c796987c4
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// generation_id = "e52772ac75b..."<br/>
        /// result = requests.get(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/results/{generation_id}",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        /// )<br/>
        /// if result.status_code == 202:<br/>
        ///     print("Generation is still in-progress.")<br/>
        /// elif result.status_code == 200:<br/>
        ///     with open("./output.mp3", "wb") as f:<br/>
        ///         f.write(result.content)<br/>
        ///     print("Download complete!")<br/>
        /// else:<br/>
        ///     raise Exception(str(result.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.FetchAudioResultResponse> FetchAudioResultAsync(
            string id,
            global::StabilityAI.FetchAudioResultAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch Audio Result<br/>
        /// Fetch the result of an audio generation by ID.<br/>
        /// Poll this endpoint after starting an async audio generation. Returns `202` while<br/>
        /// in-progress, `200` with the audio when complete.
        /// </summary>
        /// <param name="id">
        /// The `id` of a generation, typically used for async generations, that can be used to check the status of the generation or retrieve the result.<br/>
        /// Example: a6dc6c6e20acda010fe14d71f180658f2896ed9b4ec25aa99a6ff06c796987c4
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests<br/>
        /// generation_id = "e52772ac75b..."<br/>
        /// result = requests.get(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/results/{generation_id}",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        /// )<br/>
        /// if result.status_code == 202:<br/>
        ///     print("Generation is still in-progress.")<br/>
        /// elif result.status_code == 200:<br/>
        ///     with open("./output.mp3", "wb") as f:<br/>
        ///         f.write(result.content)<br/>
        ///     print("Download complete!")<br/>
        /// else:<br/>
        ///     raise Exception(str(result.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.FetchAudioResultResponse>> FetchAudioResultAsResponseAsync(
            string id,
            global::StabilityAI.FetchAudioResultAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}