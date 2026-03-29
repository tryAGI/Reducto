#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Parse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>> ParseParsePostAsync(

            global::Reducto.OneOf<global::Reducto.SyncParseConfig, global::Reducto.AsyncParseConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>> ParseParsePostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}