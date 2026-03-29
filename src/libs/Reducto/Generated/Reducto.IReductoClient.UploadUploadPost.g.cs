#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Upload
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.UploadResponse> UploadUploadPostAsync(

            global::Reducto.BodyUploadUploadPost request,
            string? extension = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.UploadResponse> UploadUploadPostAsync(
            string? extension = default,
            byte[]? file = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}