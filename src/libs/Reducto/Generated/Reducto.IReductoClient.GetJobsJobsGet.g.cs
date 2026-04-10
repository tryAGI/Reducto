#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Get Jobs
        /// </summary>
        /// <param name="excludeConfigs">
        /// Exclude raw_config from response to reduce size<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination. Use the next_cursor from the previous response to fetch the next page.
        /// </param>
        /// <param name="limit">
        /// Maximum number of jobs to return per page. Defaults to 100, max 500.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.JobsResponse> GetJobsJobsGetAsync(
            bool? excludeConfigs = default,
            string? cursor = default,
            int? limit = default,
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}