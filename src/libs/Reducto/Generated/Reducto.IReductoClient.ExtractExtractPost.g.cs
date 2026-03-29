#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Extract
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.OneOf<global::Reducto.V3ExtractResponse, global::Reducto.AsyncExtractResponse>> ExtractExtractPostAsync(

            global::Reducto.OneOf<global::Reducto.SyncExtractConfig, global::Reducto.AsyncExtractConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.OneOf<global::Reducto.V3ExtractResponse, global::Reducto.AsyncExtractResponse>> ExtractExtractPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}