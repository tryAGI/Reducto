#nullable enable

namespace Reducto
{
    public partial interface IReductoClient
    {
        /// <summary>
        /// Pipeline
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reducto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.PipelineResponse> PipelinePipelinePostAsync(

            global::Reducto.V3PipelineConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pipeline
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
        /// <param name="pipelineId">
        /// The ID of the pipeline to use for the document.
        /// </param>
        /// <param name="settings">
        /// Settings for pipeline execution that override pipeline defaults.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reducto.PipelineResponse> PipelinePipelinePostAsync(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            string pipelineId,
            global::Reducto.PipelineSettings? settings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}