#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Split
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.SplitResponse> SplitSplitPostAsync(

            global::Reducto.SyncSplitConfig request,
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split
        /// </summary>
        /// <param name="input">
        /// For parse/split/extract pipelines, the URL of the document to be processed. You can provide one of the following:<br/>
        ///             1. A publicly available URL<br/>
        ///             2. A presigned S3 URL<br/>
        ///             3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document<br/>
        ///             4. A jobid:// prefixed URL obtained from a previous /parse invocation<br/>
        ///             5. A list of URLs (for multi-document pipelines, V3 API only)<br/>
        ///             For edit pipelines, this should be a string containing the edit instructions 
        /// </param>
        /// <param name="parsing">
        /// The configuration options for parsing the document. If you are passing in a jobid:// URL for the file, then this configuration will be ignored.<br/>
        /// Default Value: {"enhance":{"agentic":[],"intelligent_ordering":false,"summarize_figures":true},"retrieval":{"chunking":{"chunk_mode":"disabled","chunk_overlap":0},"embedding_optimized":false,"filter_blocks":[]},"formatting":{"add_page_markers":false,"include":[],"merge_tables":false,"table_output_format":"dynamic"},"spreadsheet":{"clustering":"accurate","exclude":[],"include":[],"split_large_tables":{"enabled":true,"size":50}},"settings":{"embed_pdf_metadata":false,"extraction_mode":"hybrid","force_url_result":false,"ocr_system":"standard","persist_results":false,"return_images":[],"return_ocr_data":false}}
        /// </param>
        /// <param name="splitDescription">
        /// The configuration options for processing the document.
        /// </param>
        /// <param name="splitRules">
        /// The prompt that describes rules for splitting the document.<br/>
        /// Default Value: Split the document into the applicable sections. Sections may only overlap at their first and last page if at all.
        /// </param>
        /// <param name="settings">
        /// The settings for split processing.<br/>
        /// Default Value: {"table_cutoff":"truncate"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.SplitResponse> SplitSplitPostAsync(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            global::System.Collections.Generic.IList<global::Reducto.SplitCategory> splitDescription,
            global::Reducto.ParseOptions? parsing = default,
            string? splitRules = default,
            global::Reducto.SplitTableOptions? settings = default,
            global::Reducto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}