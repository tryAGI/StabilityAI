#nullable enable

namespace StabilityAI
{
    public partial interface IStableAudio2Client
    {
        /// <summary>
        /// Inpaint<br/>
        /// Stable Audio 2.5 transforms existing audio samples into new high-quality compositions up to three minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb).<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`. The `accept` header should be set to one of the following:<br/>
        /// - `audio/*` to receive the audio in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the audio encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `prompt` - text to generate the audio from<br/>
        /// - `audio` - the audio to use as the starting point for the generation<br/>
        /// &gt; **Notes:**<br/>
        /// &gt; - We do not allow copyrighted content to be uploaded to our platform.<br/>
        /// &gt; - Maximum request size is 50Mb.<br/>
        /// #### **Optional Parameters:**<br/>
        /// The body may optionally include:<br/>
        /// - `output_format` - the format of the output audio<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `duration` - the number of seconds of the generated audio<br/>
        /// - `steps` - the number of sampling steps<br/>
        /// - `mask_start` - start time in seconds for the audio segment to be inpainted (e.g., 30.0 for 30.0 seconds)<br/>
        /// - `mask_end` - end time in seconds for the audio segment to be inpainted (e.g., 190.0 for 190.0 seconds)<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 2.5**<br/>
        /// Flat rate of 20 credits per successful generation.<br/>
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
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/stable-audio-2/inpaint",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     files={<br/>
        ///         "audio": open("./uk-bass-base.mp3", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "A song in the 3/4 time signature that features cheerful acoustic guitar, live recorded drums, and rhythmic claps, The mood is happy and up-lifting.",<br/>
        ///         "output_format": "mp3",<br/>
        ///         "duration": 20,<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./output.mp3", "wb") as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateAudioStableAudio2InpaintResponse> CreateAudioStableAudio2InpaintAsync(
            string contentType,

            global::StabilityAI.CreateAudioStableAudio2InpaintRequest request,
            global::StabilityAI.CreateAudioStableAudio2InpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint<br/>
        /// Stable Audio 2.5 transforms existing audio samples into new high-quality compositions up to three minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb).<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`. The `accept` header should be set to one of the following:<br/>
        /// - `audio/*` to receive the audio in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the audio encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `prompt` - text to generate the audio from<br/>
        /// - `audio` - the audio to use as the starting point for the generation<br/>
        /// &gt; **Notes:**<br/>
        /// &gt; - We do not allow copyrighted content to be uploaded to our platform.<br/>
        /// &gt; - Maximum request size is 50Mb.<br/>
        /// #### **Optional Parameters:**<br/>
        /// The body may optionally include:<br/>
        /// - `output_format` - the format of the output audio<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `duration` - the number of seconds of the generated audio<br/>
        /// - `steps` - the number of sampling steps<br/>
        /// - `mask_start` - start time in seconds for the audio segment to be inpainted (e.g., 30.0 for 30.0 seconds)<br/>
        /// - `mask_end` - end time in seconds for the audio segment to be inpainted (e.g., 190.0 for 190.0 seconds)<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 2.5**<br/>
        /// Flat rate of 20 credits per successful generation.<br/>
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
        /// import requests<br/>
        /// response = requests.post(<br/>
        ///     f"https://api.stability.ai/v2beta/audio/stable-audio-2/inpaint",<br/>
        ///     headers={"authorization": f"Bearer sk-MYAPIKEY", "accept": "audio/*"},<br/>
        ///     files={<br/>
        ///         "audio": open("./uk-bass-base.mp3", "rb"),<br/>
        ///     },<br/>
        ///     data={<br/>
        ///         "prompt": "A song in the 3/4 time signature that features cheerful acoustic guitar, live recorded drums, and rhythmic claps, The mood is happy and up-lifting.",<br/>
        ///         "output_format": "mp3",<br/>
        ///         "duration": 20,<br/>
        ///     },<br/>
        /// )<br/>
        /// if response.status_code == 200:<br/>
        ///     with open("./output.mp3", "wb") as file:<br/>
        ///         file.write(response.content)<br/>
        /// else:<br/>
        ///     raise Exception(str(response.json()))
        /// </remarks>
        global::System.Threading.Tasks.Task<global::StabilityAI.AutoSDKHttpResponse<global::StabilityAI.CreateAudioStableAudio2InpaintResponse>> CreateAudioStableAudio2InpaintAsResponseAsync(
            string contentType,

            global::StabilityAI.CreateAudioStableAudio2InpaintRequest request,
            global::StabilityAI.CreateAudioStableAudio2InpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint<br/>
        /// Stable Audio 2.5 transforms existing audio samples into new high-quality compositions up to three minutes<br/>
        /// long at 44.1kHz stereo using text instructions.<br/>
        /// ### Try it out<br/>
        /// Grab your [API key](https://platform.stability.ai/account/keys) and head over to<br/>
        /// [![Open Google Colab](https://platform.stability.ai/svg/google-colab.svg)](https://colab.research.google.com/github/stability-ai/stability-sdk/blob/main/nbs/Stable_Audio_API.ipynb).<br/>
        /// ### How to use<br/>
        /// Please invoke this endpoint with a `POST` request.<br/>
        /// The headers of the request must include an API key in the `authorization` field. The body of the request must be<br/>
        /// `multipart/form-data`. The `accept` header should be set to one of the following:<br/>
        /// - `audio/*` to receive the audio in the format specified by the `output_format` parameter.<br/>
        /// - `application/json` to receive the audio encoded as base64 in a JSON response.<br/>
        /// The body of the request should include:<br/>
        /// - `prompt` - text to generate the audio from<br/>
        /// - `audio` - the audio to use as the starting point for the generation<br/>
        /// &gt; **Notes:**<br/>
        /// &gt; - We do not allow copyrighted content to be uploaded to our platform.<br/>
        /// &gt; - Maximum request size is 50Mb.<br/>
        /// #### **Optional Parameters:**<br/>
        /// The body may optionally include:<br/>
        /// - `output_format` - the format of the output audio<br/>
        /// - `seed` - the randomness seed to use for the generation<br/>
        /// - `duration` - the number of seconds of the generated audio<br/>
        /// - `steps` - the number of sampling steps<br/>
        /// - `mask_start` - start time in seconds for the audio segment to be inpainted (e.g., 30.0 for 30.0 seconds)<br/>
        /// - `mask_end` - end time in seconds for the audio segment to be inpainted (e.g., 190.0 for 190.0 seconds)<br/>
        /// &gt; **Note:** for more details about these parameters please see the request schema below.<br/>
        /// ### Credits<br/>
        /// **Stable Audio 2.5**<br/>
        /// Flat rate of 20 credits per successful generation.<br/>
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
        /// <param name="outputFormat">
        /// Dictates the `content-type` of the generated audio.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="audio">
        /// The audio to be use as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 190 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </param>
        /// <param name="audioname">
        /// The audio to be use as the starting point for the generation.<br/>
        /// Supported Formats:<br/>
        /// - mp3<br/>
        /// - wav<br/>
        /// Validation Rule:<br/>
        /// - Audio must be between 6 and 190 seconds long<br/>
        /// Example: ./some/audio.mp3
        /// </param>
        /// <param name="maskStart">
        /// Default Value: 30
        /// </param>
        /// <param name="maskEnd">
        /// Default Value: 190
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.CreateAudioStableAudio2InpaintResponse> CreateAudioStableAudio2InpaintAsync(
            string contentType,
            string prompt,
            byte[] audio,
            string audioname,
            global::StabilityAI.CreateAudioStableAudio2InpaintAccept? accept = default,
            string? stabilityClientId = default,
            string? stabilityClientUserId = default,
            string? stabilityClientVersion = default,
            double? duration = default,
            double? seed = default,
            int? steps = default,
            global::StabilityAI.CreateAudioStableAudio2InpaintRequestOutputFormat? outputFormat = default,
            double? maskStart = default,
            double? maskEnd = default,
            global::StabilityAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}