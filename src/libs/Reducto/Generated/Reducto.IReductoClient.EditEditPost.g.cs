#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Edit
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.EditResponse> EditEditPostAsync(

            global::Reducto.EditConfig request,
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit
        /// </summary>
        /// <param name="documentUrl">
        /// The URL of the document to be processed. You can provide one of the following:<br/>
        /// 1. A publicly available URL<br/>
        /// 2. A presigned S3 URL<br/>
        /// 3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document
        /// </param>
        /// <param name="editInstructions">
        /// The instructions for the edit.
        /// </param>
        /// <param name="editOptions">
        /// Default Value: {"color":"#FF0000","enable_overflow_pages":false,"flatten":false}
        /// </param>
        /// <param name="formSchema">
        /// Form schema for PDF forms. List of widgets with their types, descriptions, and bounding boxes. Only works for PDFs.
        /// </param>
        /// <param name="priority">
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.EditResponse> EditEditPostAsync(
            global::Reducto.AnyOf<string, global::Reducto.UploadResponse> documentUrl,
            string editInstructions,
            global::Reducto.EditOptions? editOptions = default,
            global::System.Collections.Generic.IList<global::Reducto.EditWidget>? formSchema = default,
            bool? priority = default,
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}