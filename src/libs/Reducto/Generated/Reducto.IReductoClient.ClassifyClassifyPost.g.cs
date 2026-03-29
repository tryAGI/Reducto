#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Classify
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.ClassifyResponse> ClassifyClassifyPostAsync(

            global::Reducto.ClassifyConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Classify
        /// </summary>
        /// <param name="persistResults">
        /// If True, persist the results indefinitely. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="input">
        /// For parse/split/extract pipelines, the URL of the document to be processed. You can provide one of the following:<br/>
        ///             1. A publicly available URL<br/>
        ///             2. A presigned S3 URL<br/>
        ///             3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document<br/>
        ///             4. A jobid:// prefixed URL obtained from a previous /parse invocation<br/>
        ///             5. A list of URLs (for multi-document pipelines, V3 API only)<br/>
        ///             For edit pipelines, this should be a string containing the edit instructions 
        /// </param>
        /// <param name="classificationSchema">
        /// A list of classification categories and their matching criteria.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="pageRange">
        /// The page range to process (1-indexed). By default, the first 5 pages are used. If more than 25 pages are selected, only the first 25 (after sorting) are used. Only applies to PDFs; ignored for other document types.
        /// </param>
        /// <param name="documentMetadata">
        /// Optional document-level metadata to include in classification prompts.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.ClassifyResponse> ClassifyClassifyPostAsync(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            bool? persistResults = default,
            global::System.Collections.Generic.IList<global::Reducto.ClassificationCategory>? classificationSchema = default,
            global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, object>? pageRange = default,
            string? documentMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}