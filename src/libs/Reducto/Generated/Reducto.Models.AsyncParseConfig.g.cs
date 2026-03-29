
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncParseConfig
    {
        /// <summary>
        /// The configuration options for asynchronous processing (default synchronous).<br/>
        /// Default Value: {"priority":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public global::Reducto.ConfigV3AsyncConfig? Async { get; set; }

        /// <summary>
        /// For parse/split/extract pipelines, the URL of the document to be processed. You can provide one of the following:<br/>
        ///             1. A publicly available URL<br/>
        ///             2. A presigned S3 URL<br/>
        ///             3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document<br/>
        ///             4. A jobid:// prefixed URL obtained from a previous /parse invocation<br/>
        ///             5. A list of URLs (for multi-document pipelines, V3 API only)<br/>
        ///             For edit pipelines, this should be a string containing the edit instructions 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> Input { get; set; }

        /// <summary>
        /// Default Value: {"agentic":[],"summarize_figures":true,"intelligent_ordering":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance")]
        public global::Reducto.Enhance? Enhance { get; set; }

        /// <summary>
        /// Default Value: {"chunking":{"chunk_mode":"disabled","chunk_overlap":0},"filter_blocks":[],"embedding_optimized":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval")]
        public global::Reducto.Retrieval? Retrieval { get; set; }

        /// <summary>
        /// Default Value: {"add_page_markers":false,"table_output_format":"dynamic","merge_tables":false,"include":[]}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting")]
        public global::Reducto.Formatting? Formatting { get; set; }

        /// <summary>
        /// Default Value: {"split_large_tables":{"enabled":true,"size":50},"include":[],"clustering":"accurate","exclude":[]}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet")]
        public global::Reducto.Spreadsheet? Spreadsheet { get; set; }

        /// <summary>
        /// Default Value: {"ocr_system":"standard","extraction_mode":"hybrid","force_url_result":false,"return_ocr_data":false,"return_images":[],"embed_pdf_metadata":false,"persist_results":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Reducto.Settings? Settings { get; set; }

        /// <summary>
        /// Queue priority. 'batch' for non-urgent work that processes when spare GPU capacity is available.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.QueuePriorityJsonConverter))]
        public global::Reducto.QueuePriority? QueuePriority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncParseConfig" /> class.
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
        /// <param name="async">
        /// The configuration options for asynchronous processing (default synchronous).<br/>
        /// Default Value: {"priority":false}
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncParseConfig(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            global::Reducto.ConfigV3AsyncConfig? async,
            global::Reducto.Enhance? enhance,
            global::Reducto.Retrieval? retrieval,
            global::Reducto.Formatting? formatting,
            global::Reducto.Spreadsheet? spreadsheet,
            global::Reducto.Settings? settings,
            global::Reducto.QueuePriority? queuePriority)
        {
            this.Async = async;
            this.Input = input;
            this.Enhance = enhance;
            this.Retrieval = retrieval;
            this.Formatting = formatting;
            this.Spreadsheet = spreadsheet;
            this.Settings = settings;
            this.QueuePriority = queuePriority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncParseConfig" /> class.
        /// </summary>
        public AsyncParseConfig()
        {
        }
    }
}