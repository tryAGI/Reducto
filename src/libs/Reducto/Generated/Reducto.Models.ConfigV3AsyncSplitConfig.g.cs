
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigV3AsyncSplitConfig
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
        /// The configuration options for processing the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.SplitCategory> SplitDescription { get; set; }

        /// <summary>
        /// The prompt that describes rules for splitting the document.<br/>
        /// Default Value: Split the document into the applicable sections. Sections may only overlap at their first and last page if at all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_rules")]
        public string? SplitRules { get; set; }

        /// <summary>
        /// The settings for split processing.<br/>
        /// Default Value: {"table_cutoff":"truncate"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Reducto.SplitTableOptions? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigV3AsyncSplitConfig" /> class.
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
        /// <param name="splitDescription">
        /// The configuration options for processing the document.
        /// </param>
        /// <param name="async">
        /// The configuration options for asynchronous processing (default synchronous).<br/>
        /// Default Value: {"priority":false}
        /// </param>
        /// <param name="parsing">
        /// The configuration options for parsing the document. If you are passing in a jobid:// URL for the file, then this configuration will be ignored.<br/>
        /// Default Value: {"enhance":{"agentic":[],"intelligent_ordering":false,"summarize_figures":true},"retrieval":{"chunking":{"chunk_mode":"disabled","chunk_overlap":0},"embedding_optimized":false,"filter_blocks":[]},"formatting":{"add_page_markers":false,"include":[],"merge_tables":false,"table_output_format":"dynamic"},"spreadsheet":{"clustering":"accurate","exclude":[],"include":[],"split_large_tables":{"enabled":true,"size":50}},"settings":{"embed_pdf_metadata":false,"extraction_mode":"hybrid","force_url_result":false,"ocr_system":"standard","persist_results":false,"return_images":[],"return_ocr_data":false}}
        /// </param>
        /// <param name="splitRules">
        /// The prompt that describes rules for splitting the document.<br/>
        /// Default Value: Split the document into the applicable sections. Sections may only overlap at their first and last page if at all.
        /// </param>
        /// <param name="settings">
        /// The settings for split processing.<br/>
        /// Default Value: {"table_cutoff":"truncate"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigV3AsyncSplitConfig(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            global::System.Collections.Generic.IList<global::Reducto.SplitCategory> splitDescription,
            global::Reducto.ConfigV3AsyncConfig? async,
            global::Reducto.ParseOptions? parsing,
            string? splitRules,
            global::Reducto.SplitTableOptions? settings)
        {
            this.Async = async;
            this.Input = input;
            this.Parsing = parsing;
            this.SplitDescription = splitDescription ?? throw new global::System.ArgumentNullException(nameof(splitDescription));
            this.SplitRules = splitRules;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigV3AsyncSplitConfig" /> class.
        /// </summary>
        public ConfigV3AsyncSplitConfig()
        {
        }
    }
}