#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Retrieve Parse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AnyOf<global::Reducto.AsyncJobResponse, global::Reducto.EnhancedAsyncJobResponse>> RetrieveParseJobJobIdGetAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}