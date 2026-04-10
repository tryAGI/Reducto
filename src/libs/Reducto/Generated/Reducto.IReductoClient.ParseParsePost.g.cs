#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Parse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>> ParseParsePostAsync(

            global::Reducto.OneOf<global::Reducto.SyncParseConfig, global::Reducto.AsyncParseConfig> request,
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>> ParseParsePostAsync(
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}