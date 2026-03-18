#nullable enable

namespace StabilityAI
{
    public partial interface IV1UserClient
    {
        /// <summary>
        /// balance<br/>
        /// Get the credit balance of the account/organization associated with the API key
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StabilityAI.BalanceResponseBody> UserBalanceAsync(
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}