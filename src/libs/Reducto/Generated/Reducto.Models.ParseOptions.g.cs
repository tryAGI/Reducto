
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParseOptions
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseOptions" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseOptions(
            global::Reducto.Enhance? enhance,
            global::Reducto.Retrieval? retrieval,
            global::Reducto.Formatting? formatting,
            global::Reducto.Spreadsheet? spreadsheet,
            global::Reducto.Settings? settings)
        {
            this.Enhance = enhance;
            this.Retrieval = retrieval;
            this.Formatting = formatting;
            this.Spreadsheet = spreadsheet;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseOptions" /> class.
        /// </summary>
        public ParseOptions()
        {
        }
    }
}