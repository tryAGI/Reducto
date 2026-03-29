#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Async Parse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AsyncParseResponse> AsyncParseParseAsyncPostAsync(

            global::Reducto.AsyncParseConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Async Parse
        /// </summary>
        /// <param name="async">
        /// The configuration options for asynchronous processing (default synchronous).<br/>
        /// Default Value: {"priority":false}
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
        /// <param name="enhance">
        /// Default Value: {"agentic":[],"summarize_figures":true,"intelligent_ordering":false}
        /// </param>
        /// <param name="retrieval">
        /// Default Value: {"chunking":{"chunk_mode":"disabled","chunk_overlap":0},"filter_blocks":[],"embedding_optimized":false}
        /// </param>
        /// <param name="formatting">
        /// Default Value: {"add_page_markers":false,"table_output_format":"dynamic","merge_tables":false,"include":[]}
        /// </param>
        /// <param name="spreadsheet">
        /// Default Value: {"split_large_tables":{"enabled":true,"size":50},"include":[],"clustering":"accurate","exclude":[]}
        /// </param>
        /// <param name="settings">
        /// Default Value: {"ocr_system":"standard","extraction_mode":"hybrid","force_url_result":false,"return_ocr_data":false,"return_images":[],"embed_pdf_metadata":false,"persist_results":false}
        /// </param>
        /// <param name="queuePriority">
        /// Queue priority. 'batch' for non-urgent work that processes when spare GPU capacity is available.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.AsyncParseResponse> AsyncParseParseAsyncPostAsync(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            global::Reducto.ConfigV3AsyncConfig? async = default,
            global::Reducto.Enhance? enhance = default,
            global::Reducto.Retrieval? retrieval = default,
            global::Reducto.Formatting? formatting = default,
            global::Reducto.Spreadsheet? spreadsheet = default,
            global::Reducto.Settings? settings = default,
            global::Reducto.QueuePriority? queuePriority = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}