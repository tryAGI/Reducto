#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Cancel Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelJobCancelJobIdPostAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}