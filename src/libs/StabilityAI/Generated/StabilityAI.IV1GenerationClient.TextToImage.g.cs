#nullable enable

namespace StabilityAI
{
    public partial interface IV1GenerationClient
    {
        /// <summary>
        /// text-to-image<br/>
        /// Generate a new image from a text prompt
        /// </summary>
        /// <param name="engineId">
        /// Example: stable-diffusion-v1-5
        /// </param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::StabilityAI.Image>> TextToImageAsync(
            string engineId,

            global::StabilityAI.TextToImageRequestBody request,
            global::StabilityAI.TextToImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// text-to-image<br/>
        /// Generate a new image from a text prompt
        /// </summary>
        /// <param name="engineId">
        /// Example: stable-diffusion-v1-5
        /// </param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::StabilityAI.Image>> TextToImageAsync(
            string engineId,
            global::StabilityAI.TextToImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}