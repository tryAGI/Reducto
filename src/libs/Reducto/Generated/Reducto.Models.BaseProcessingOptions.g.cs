
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseProcessingOptions
    {
        /// <summary>
        /// The mode to use for OCR. Agentic mode adds an extra pass, correcting any table/text mistakes at a small cost.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.BaseProcessingOptionsOcrModeJsonConverter))]
        public global::Reducto.BaseProcessingOptionsOcrMode? OcrMode { get; set; }

        /// <summary>
        /// The mode to use for extraction. Metadata/hybrid are only recommended with high quality metadata embeddings.<br/>
        /// Default Value: ocr
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.BaseProcessingOptionsExtractionModeJsonConverter))]
        public global::Reducto.BaseProcessingOptionsExtractionMode? ExtractionMode { get; set; }

        /// <summary>
        /// The configuration options for chunking. Chunking is commonly used for RAG usecases.<br/>
        /// Default Value: {"chunk_mode":"variable","chunk_overlap":0}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking")]
        public global::Reducto.ChunkingConfig? Chunking { get; set; }

        /// <summary>
        /// The configuration options for table summarization.<br/>
        /// Default Value: {"enabled":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_summary")]
        public global::Reducto.TableSummaryConfig? TableSummary { get; set; }

        /// <summary>
        /// The configuration options for figure summarization.<br/>
        /// Default Value: {"enabled":false,"override":false,"enhanced":false,"advanced_chart_agent":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("figure_summary")]
        public global::Reducto.FigureSummaryConfig? FigureSummary { get; set; }

        /// <summary>
        /// A list of block types to filter from chunk content. Pass blocks to filter them from content. By default, no blocks are filtered.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_blocks")]
        public global::System.Collections.Generic.IList<global::Reducto.BaseProcessingOptionsFilterBlock>? FilterBlocks { get; set; }

        /// <summary>
        /// Force the result to be returned in URL form (by default only used for very large responses).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_url_result")]
        public bool? ForceUrlResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseProcessingOptions" /> class.
        /// </summary>
        /// <param name="ocrMode">
        /// The mode to use for OCR. Agentic mode adds an extra pass, correcting any table/text mistakes at a small cost.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="extractionMode">
        /// The mode to use for extraction. Metadata/hybrid are only recommended with high quality metadata embeddings.<br/>
        /// Default Value: ocr
        /// </param>
        /// <param name="chunking">
        /// The configuration options for chunking. Chunking is commonly used for RAG usecases.<br/>
        /// Default Value: {"chunk_mode":"variable","chunk_overlap":0}
        /// </param>
        /// <param name="tableSummary">
        /// The configuration options for table summarization.<br/>
        /// Default Value: {"enabled":false}
        /// </param>
        /// <param name="figureSummary">
        /// The configuration options for figure summarization.<br/>
        /// Default Value: {"enabled":false,"override":false,"enhanced":false,"advanced_chart_agent":false}
        /// </param>
        /// <param name="filterBlocks">
        /// A list of block types to filter from chunk content. Pass blocks to filter them from content. By default, no blocks are filtered.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="forceUrlResult">
        /// Force the result to be returned in URL form (by default only used for very large responses).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseProcessingOptions(
            global::Reducto.BaseProcessingOptionsOcrMode? ocrMode,
            global::Reducto.BaseProcessingOptionsExtractionMode? extractionMode,
            global::Reducto.ChunkingConfig? chunking,
            global::Reducto.TableSummaryConfig? tableSummary,
            global::Reducto.FigureSummaryConfig? figureSummary,
            global::System.Collections.Generic.IList<global::Reducto.BaseProcessingOptionsFilterBlock>? filterBlocks,
            bool? forceUrlResult)
        {
            this.OcrMode = ocrMode;
            this.ExtractionMode = extractionMode;
            this.Chunking = chunking;
            this.TableSummary = tableSummary;
            this.FigureSummary = figureSummary;
            this.FilterBlocks = filterBlocks;
            this.ForceUrlResult = forceUrlResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseProcessingOptions" /> class.
        /// </summary>
        public BaseProcessingOptions()
        {
        }
    }
}