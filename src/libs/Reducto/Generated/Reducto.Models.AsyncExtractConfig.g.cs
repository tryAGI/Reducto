
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncExtractConfig
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
        /// The configuration options for parsing the document. If you are passing in a jobid:// URL for the file, then this configuration will be ignored.<br/>
        /// Default Value: {"enhance":{"agentic":[],"intelligent_ordering":false,"summarize_figures":true},"retrieval":{"chunking":{"chunk_mode":"disabled","chunk_overlap":0},"embedding_optimized":false,"filter_blocks":[]},"formatting":{"add_page_markers":false,"include":[],"merge_tables":false,"table_output_format":"dynamic"},"spreadsheet":{"clustering":"accurate","exclude":[],"include":[],"split_large_tables":{"enabled":true,"size":50}},"settings":{"embed_pdf_metadata":false,"extraction_mode":"hybrid","force_url_result":false,"ocr_system":"standard","persist_results":false,"return_images":[],"return_ocr_data":false}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing")]
        public global::Reducto.ParseOptions? Parsing { get; set; }

        /// <summary>
        /// The instructions to use for the extraction.<br/>
        /// Default Value: {"schema":{},"system_prompt":"Be precise and thorough."}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public global::Reducto.Instructions? Instructions { get; set; }

        /// <summary>
        /// The settings to use for the extraction.<br/>
        /// Default Value: {"include_images":false,"optimize_for_latency":false,"array_extract":false,"deep_extract":false,"citations":{"enabled":false,"numerical_confidence":true}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Reducto.ExtractSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncExtractConfig" /> class.
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
        /// <param name="parsing">
        /// The configuration options for parsing the document. If you are passing in a jobid:// URL for the file, then this configuration will be ignored.<br/>
        /// Default Value: {"enhance":{"agentic":[],"intelligent_ordering":false,"summarize_figures":true},"retrieval":{"chunking":{"chunk_mode":"disabled","chunk_overlap":0},"embedding_optimized":false,"filter_blocks":[]},"formatting":{"add_page_markers":false,"include":[],"merge_tables":false,"table_output_format":"dynamic"},"spreadsheet":{"clustering":"accurate","exclude":[],"include":[],"split_large_tables":{"enabled":true,"size":50}},"settings":{"embed_pdf_metadata":false,"extraction_mode":"hybrid","force_url_result":false,"ocr_system":"standard","persist_results":false,"return_images":[],"return_ocr_data":false}}
        /// </param>
        /// <param name="instructions">
        /// The instructions to use for the extraction.<br/>
        /// Default Value: {"schema":{},"system_prompt":"Be precise and thorough."}
        /// </param>
        /// <param name="settings">
        /// The settings to use for the extraction.<br/>
        /// Default Value: {"include_images":false,"optimize_for_latency":false,"array_extract":false,"deep_extract":false,"citations":{"enabled":false,"numerical_confidence":true}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncExtractConfig(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            global::Reducto.ConfigV3AsyncConfig? async,
            global::Reducto.ParseOptions? parsing,
            global::Reducto.Instructions? instructions,
            global::Reducto.ExtractSettings? settings)
        {
            this.Async = async;
            this.Input = input;
            this.Parsing = parsing;
            this.Instructions = instructions;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncExtractConfig" /> class.
        /// </summary>
        public AsyncExtractConfig()
        {
        }
    }
}