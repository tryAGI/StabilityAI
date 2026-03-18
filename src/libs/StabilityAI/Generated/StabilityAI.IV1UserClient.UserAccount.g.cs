#nullable enable

namespace StabilityAI
{
    public partial interface IV1UserClient
    {
        /// <summary>
        /// account<br/>
        /// Get information about the account associated with the provided API key
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.AccountResponseBody> UserAccountAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}