#nullable enable

namespace StabilityAI
{
    public partial interface IStableAudioClient
    {
        /// <summary>
        /// Text-to-Audio<br/>
        /// Stable Audio transforms existing audio samples into new high-quality compositions up to six minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb)<br/>
        /// or try Stable Audio for free at [stableaudio.com](https://stableaudio.com).<br/>
        /// This endpoint is asynchronous — it returns a generation `id` immediately (HTTP 202).<br/>
        /// Poll `GET /v2beta/audio/results/{id}` to retrieve the result.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 3.0**<br/>
        /// Flat rate of 26 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests, time<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/stable-audio/text-to-audio",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     files={"none": ""},<br/>
        ///     data={<br/>
        ///         "prompt": "A cinematic orchestral piece with sweeping strings and dramatic brass.",<br/>
        ///         "output_format": "mp3",<br/>
        ///         "duration": 30,<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code != 202:<br/>
        ///     raise Exception(str(response.json()))<br/>
        /// generation_id = response.json()["id"]<br/>
        /// while True:<br/>
        ///     result = requests.get(<br/>
        ///         f"https://api.stability.ai/v2beta/audio/results/{generation_id}",<br/>
        ///         headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     )<br/>
        ///     if result.status_code == 202:<br/>
        ///         print("Generation in-progress, retrying in 10 seconds...")<br/>
        ///         time.sleep(10)<br/>
        ///     elif result.status_code == 200:<br/>
        ///         with open("./output.mp3", "wb") as f:<br/>
        ///             f.write(result.content)<br/>
        ///         break<br/>
        ///     else:<br/>
        ///         raise Exception(str(result.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse> CreateAudioStableAudioTextToAudioAsync(
            string contentType,

            global::StabilityAI.CreateAudioStableAudioTextToAudioRequest request,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text-to-Audio<br/>
        /// Stable Audio transforms existing audio samples into new high-quality compositions up to six minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb)<br/>
        /// or try Stable Audio for free at [stableaudio.com](https://stableaudio.com).<br/>
        /// This endpoint is asynchronous — it returns a generation `id` immediately (HTTP 202).<br/>
        /// Poll `GET /v2beta/audio/results/{id}` to retrieve the result.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 3.0**<br/>
        /// Flat rate of 26 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        /// <remarks>
        /// import requests, time<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/stable-audio/text-to-audio",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     files={"none": ""},<br/>
        ///     data={<br/>
        ///         "prompt": "A cinematic orchestral piece with sweeping strings and dramatic brass.",<br/>
        ///         "output_format": "mp3",<br/>
        ///         "duration": 30,<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code != 202:<br/>
        ///     raise Exception(str(response.json()))<br/>
        /// generation_id = response.json()["id"]<br/>
        /// while True:<br/>
        ///     result = requests.get(<br/>
        ///         f"https://api.stability.ai/v2beta/audio/results/{generation_id}",<br/>
        ///         headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     )<br/>
        ///     if result.status_code == 202:<br/>
        ///         print("Generation in-progress, retrying in 10 seconds...")<br/>
        ///         time.sleep(10)<br/>
        ///     elif result.status_code == 200:<br/>
        ///         with open("./output.mp3", "wb") as f:<br/>
        ///             f.write(result.content)<br/>
        ///         break<br/>
        ///     else:<br/>
        ///         raise Exception(str(result.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse>> CreateAudioStableAudioTextToAudioAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateAudioStableAudioTextToAudioRequest request,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text-to-Audio<br/>
        /// Stable Audio transforms existing audio samples into new high-quality compositions up to six minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb)<br/>
        /// or try Stable Audio for free at [stableaudio.com](https://stableaudio.com).<br/>
        /// This endpoint is asynchronous — it returns a generation `id` immediately (HTTP 202).<br/>
        /// Poll `GET /v2beta/audio/results/{id}` to retrieve the result.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 3.0**<br/>
        /// Flat rate of 26 credits per successful generation.<br/>
        /// As always, you will not be charged for failed generations.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the request body. Do not manually specify this header; your HTTP client library will automatically include the appropriate boundary parameter.<br/>
        /// Example: multipart/form-data
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
        /// <param name="prompt">
        /// What you wish the output audio to be. A strong, descriptive prompt that clearly defines<br/>
        /// instruments, moods, styles, and genre will lead to better results.<br/>
        /// You can make a prompt as simple or complex as you like. Simple prompts are good for clean<br/>
        /// output audio. Complex prompts are good for adding texture and depth to the output audio.
        /// </param>
        /// <param name="model">
        /// The model to use for generation.<br/>
        /// - `stable-audio-3` requires 26 credits per generation<br/>
        /// Default Value: stable-audio-3
        /// </param>
        /// <param name="duration">
        /// Controls the duration in seconds of the generated audio.<br/>
        /// Default Value: 190
        /// </param>
        /// <param name="seed">
        /// A specific value that is used to guide the 'randomness' of the generation. (Omit this parameter or pass `0` to use a random seed.)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="steps">
        /// Controls the number of sampling steps.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values make your audio closer to your prompt). Defaults to 1 if not specified.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateAudioStableAudioTextToAudioResponse> CreateAudioStableAudioTextToAudioAsync(
            string contentType,
            string prompt,
            global::StabilityAI.CreateAudioStableAudioTextToAudioAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.CreateAudioStableAudioTextToAudioRequestModel? model = default,
            double? duration = default,
            double? seed = default,
            int? steps = default,
            double? cfgScale = default,
            global::StabilityAI.CreateAudioStableAudioTextToAudioRequestOutputFormat? outputFormat = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}