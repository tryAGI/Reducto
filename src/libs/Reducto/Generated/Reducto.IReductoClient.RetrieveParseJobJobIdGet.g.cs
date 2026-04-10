#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Retrieve Parse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AnyOf<global::Reducto.AsyncJobResponse, global::Reducto.EnhancedAsyncJobResponse>> RetrieveParseJobJobIdGetAsync(
            string jobId,
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}