#nullable enable

namespace StabilityAI
{
    public partial interface IV1EnginesClient
    {
        /// <summary>
        /// list<br/>
        /// List all engines available to your organization/user
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StabilityAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::StabilityAI.Engine>> ListEnginesAsync(
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}