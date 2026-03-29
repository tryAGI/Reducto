
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessingOptions
    {
        /// <summary>
        /// The version of the processing options.<br/>
        /// Default Value: v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsVersionJsonConverter))]
        public global::Reducto.ProcessingOptionsVersion? Version { get; set; }

        /// <summary>
        /// The method to use for OCR. hybrid uses the PDF text first, then OCR. pdf only uses the PDF text. ocr only uses OCR.<br/>
        /// Default Value: ocr
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_ocr")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsPdfOcrJsonConverter))]
        public global::Reducto.ProcessingOptionsPdfOcr? PdfOcr { get; set; }

        /// <summary>
        /// The OCR system to use. Defaults to cloud (AWS Textract/Azure DocAI/etc).<br/>
        /// Default Value: textract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsOcrSystemJsonConverter))]
        public global::Reducto.ProcessingOptionsOcrSystem? OcrSystem { get; set; }

        /// <summary>
        /// The mode to use for OCR. If agentic is enabled, table OCR will be automatically edited.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsOcrModeJsonConverter))]
        public global::Reducto.ProcessingOptionsOcrMode? OcrMode { get; set; }

        /// <summary>
        /// Password to decrypt password-protected documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_password")]
        public string? DocumentPassword { get; set; }

        /// <summary>
        /// The mode to use for table output. Defaults to html.<br/>
        /// Default Value: html
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsTableOutputFormatJsonConverter))]
        public global::Reducto.ProcessingOptionsTableOutputFormat? TableOutputFormat { get; set; }

        /// <summary>
        /// If table cell colors should be used to determine table structure. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infer_table_color")]
        public bool? InferTableColor { get; set; }

        /// <summary>
        /// If True, preserve color information in spreadsheet cells by wrapping text with LaTeX color commands during parsing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_color_information")]
        public bool? IncludeColorInformation { get; set; }

        /// <summary>
        /// If True, preserve formula information in spreadsheet cells by wrapping text with LaTeX formula commands during parsing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_formula_information")]
        public bool? IncludeFormulaInformation { get; set; }

        /// <summary>
        /// If True, include dropdown options and the selected value when rendering spreadsheet cells.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_dropdown_information")]
        public bool? IncludeDropdownInformation { get; set; }

        /// <summary>
        /// The mode to use for chunking. Defaults to 'variable'. Section chunks according to sections in the document. Page chunks according to pages. Page sections chunks according to both pages and sections. Disabled returns a single chunk.<br/>
        /// Default Value: variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsChunkModeJsonConverter))]
        public global::Reducto.ProcessingOptionsChunkMode? ChunkMode { get; set; }

        /// <summary>
        /// The approximate size of chunks (in characters) that the document will be split into. Defaults to None, in which case the chunk size is variable between 250 - 1500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Number of characters of overlap from adjacent chunks. Defaults to 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_overlap")]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// DEPRECATED, use chunk_mode=disabled instead<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_chunking")]
        public bool? DisableChunking { get; set; }

        /// <summary>
        /// A flag to indicate if the hierarchy of the document should be continued from chunk to chunk. E.g. ## Prev Section (cont.)<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_hierarchy")]
        public bool? ContinueHierarchy { get; set; }

        /// <summary>
        /// The type of document to be processed. Defaults to document. If auto is specified, the orientation of the first page will be used to determine the document type.<br/>
        /// Default Value: document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsModeJsonConverter))]
        public global::Reducto.ProcessingOptionsMode? Mode { get; set; }

        /// <summary>
        /// If tables should be summarized for embedding. Defaults to True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_summary")]
        public bool? TableSummary { get; set; }

        /// <summary>
        /// Add information to the prompt for table summarization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_summary_prompt")]
        public string? TableSummaryPrompt { get; set; }

        /// <summary>
        /// A flag to indicate if figure summarization should be performed. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("figure_summary")]
        public bool? FigureSummary { get; set; }

        /// <summary>
        /// Add information to the prompt for figure summarization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("figure_summary_prompt")]
        public string? FigureSummaryPrompt { get; set; }

        /// <summary>
        /// If the figure summary prompt should override our default prompt.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("figure_summary_override")]
        public bool? FigureSummaryOverride { get; set; }

        /// <summary>
        /// If True, use enhanced figure summarization pipeline for complex charts. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhanced_figure_summary")]
        public bool? EnhancedFigureSummary { get; set; }

        /// <summary>
        /// If True, enable figure summaries for all figures regardless of size (onprem only). Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarize_all_figures")]
        public bool? SummarizeAllFigures { get; set; }

        /// <summary>
        /// A flag to indicate if bar chart extraction should be performed (requires figure_summary=True). Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_extract")]
        public bool? ChartExtract { get; set; }

        /// <summary>
        /// If True, use an advanced vision language model to improve reading order accuracy, with a small increase in latency. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligent_ordering")]
        public bool? IntelligentOrdering { get; set; }

        /// <summary>
        /// If enabled, a large language/vision model will be used to postprocess the extracted content. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrich")]
        public bool? Enrich { get; set; }

        /// <summary>
        /// Add information to the prompt for enrichment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrich_prompt")]
        public string? EnrichPrompt { get; set; }

        /// <summary>
        /// The mode to use for enrichment. Defaults to standard<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrich_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsEnrichModeJsonConverter))]
        public global::Reducto.ProcessingOptionsEnrichMode? EnrichMode { get; set; }

        /// <summary>
        /// If enabled, a large language/vision model will be used to postprocess the layout predictions. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta_layout_enrichment")]
        public bool? BetaLayoutEnrichment { get; set; }

        /// <summary>
        /// A list of block types to ignore. Defaults to ['Page Number', 'Header', 'Footer', 'Comment'].<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_blocks")]
        public global::System.Collections.Generic.IList<global::Reducto.ProcessingOptionsIgnoreBlock>? IgnoreBlocks { get; set; }

        /// <summary>
        /// If True, return overlays for the chart. This is so you can use the overlays to double check the quality of the extraction<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_agent_return_overlays")]
        public bool? ChartAgentReturnOverlays { get; set; }

        /// <summary>
        /// If True, use the advanced chart agent. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_chart_agent")]
        public bool? AdvancedChartAgent { get; set; }

        /// <summary>
        /// A flag to indicate if consecutive tables with the same number of columns should be merged. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_tables")]
        public bool? MergeTables { get; set; }

        /// <summary>
        /// Optional PDF page render DPI. Values greater than 0 render page images at this DPI before layout, OCR, and figure cropping. Set to 0 to disable the override. Higher values increase resolution and latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpi")]
        public int? Dpi { get; set; }

        /// <summary>
        /// Force the result to be returned in URL form.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_url_result")]
        public bool? ForceUrlResult { get; set; }

        /// <summary>
        /// Force the URL to be downloaded as a specific file extension (e.g. `.png`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_file_extension")]
        public string? ForceFileExtension { get; set; }

        /// <summary>
        /// Force the URL to be downloaded as a specific MIME type (e.g. image/png).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_file_mimetype")]
        public string? ForceFileMimetype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsCustomFormatJsonConverter))]
        public global::Reducto.ProcessingOptionsCustomFormat? CustomFormat { get; set; }

        /// <summary>
        /// Use a faster inference model for parsing. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_fast_inference")]
        public bool? UseFastInference { get; set; }

        /// <summary>
        /// Use GPU acceleration for OCR processing. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_gpu_ocr")]
        public bool? UseGpuOcr { get; set; }

        /// <summary>
        /// The maximum number of pages to process in a single batch. Defaults to 10.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size")]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// The dimension of the OCR crops along each axis. num_ocr_crops^2 is the total number of crops. Defaults to 2.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_ocr_crops")]
        public int? NumOcrCrops { get; set; }

        /// <summary>
        /// LEGACY: For sync/on-prem only. The timeout for the job in seconds. Defaults to 1800.<br/>
        /// Default Value: 1800
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// A user specified timeout, defaults to None
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_specified_timeout_seconds")]
        public double? UserSpecifiedTimeoutSeconds { get; set; }

        /// <summary>
        /// Extra metadata to be added to logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_metadata")]
        public object? ExtraMetadata { get; set; }

        /// <summary>
        /// If True, embed text metadata into the returned PDF. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_text_metadata_pdf")]
        public bool? EmbedTextMetadataPdf { get; set; }

        /// <summary>
        /// If True, enable numeric parse confidence scores in granular_confidence field. Defaults to False.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerical_parse_confidence")]
        public bool? NumericalParseConfidence { get; set; }

        /// <summary>
        /// If True, detect signatures in the document. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_signatures")]
        public bool? DetectSignatures { get; set; }

        /// <summary>
        /// If True, ignore and remove watermarks from OCR output. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_watermarks")]
        public bool? IgnoreWatermarks { get; set; }

        /// <summary>
        /// If True, use HTML rendered as PDF for parsing. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_html_to_pdf")]
        public bool? UseHtmlToPdf { get; set; }

        /// <summary>
        /// Instead of using LibreOffice, when enabled, this flag uses a Windows VM to convert docx files. This is slower but more accurate.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhanced_docx_conversion")]
        public bool? EnhancedDocxConversion { get; set; }

        /// <summary>
        /// If True, configure LibreOffice conversion to block linked content from untrusted documents. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_office_external_links")]
        public bool? DisableOfficeExternalLinks { get; set; }

        /// <summary>
        /// If True, parse DOCX files natively instead of converting them to PDF first. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_docx_parsing")]
        public bool? NativeDocxParsing { get; set; }

        /// <summary>
        /// If True, include bounding box information in JSON table output. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_bbox")]
        public bool? JsonBbox { get; set; }

        /// <summary>
        /// Note, this is an alpha feature subject to change at any time. If enabled, large tables will be chunked into multiple tables. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental_large_spreadsheet_table_chunking")]
        public bool? ExperimentalLargeSpreadsheetTableChunking { get; set; }

        /// <summary>
        /// Add checkboxes to the output, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_checkboxes")]
        public bool? UseCheckboxes { get; set; }

        /// <summary>
        /// Add equations to the output, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_equations")]
        public bool? UseEquations { get; set; }

        /// <summary>
        /// The page number to start processing from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_start")]
        public int? PageStart { get; set; }

        /// <summary>
        /// The page number to stop processing at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_end")]
        public int? PageEnd { get; set; }

        /// <summary>
        /// The page range to process. For spreadsheets, you can also provide a list of sheet names.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>))]
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>? PageRange { get; set; }

        /// <summary>
        /// If line breaks should be preserved in the text. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_line_breaks")]
        public bool? KeepLineBreaks { get; set; }

        /// <summary>
        /// The threshold for box overlap. Defaults to 0.5.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap_threshold")]
        public double? OverlapThreshold { get; set; }

        /// <summary>
        /// If large tables should be chunked into smaller tables, currently only supported on spreadsheet and CSV files.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_table_chunking")]
        public bool? LargeTableChunking { get; set; }

        /// <summary>
        /// The max row/column size for a table to be chunked. Defaults to 50.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_table_chunking_size")]
        public int? LargeTableChunkingSize { get; set; }

        /// <summary>
        /// Use an orientation model to detect and rotate pages as needed, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotate_pages")]
        public bool? RotatePages { get; set; }

        /// <summary>
        /// Use an orientation model to detect and rotate figures as needed, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotate_figures")]
        public bool? RotateFigures { get; set; }

        /// <summary>
        /// Add &lt;u&gt; tag around text that's underlined and surround strikethroughs and underlines with &lt;change&gt; tags, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_change_tracking")]
        public bool? EnableChangeTracking { get; set; }

        /// <summary>
        /// Add &lt;mark&gt; tags around highlighted text detected using the segmentation model, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_highlight_detection")]
        public bool? EnableHighlightDetection { get; set; }

        /// <summary>
        /// Add &lt;sub&gt; tag around subscripts and &lt;sup&gt; tag around superscripts, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_scripts")]
        public bool? EnableScripts { get; set; }

        /// <summary>
        /// Pull PDF comments from the document, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_comments")]
        public bool? EnableComments { get; set; }

        /// <summary>
        /// Extract hyperlinks from the document, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_hyperlinks")]
        public bool? EnableHyperlinks { get; set; }

        /// <summary>
        /// If figure images should be returned in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_figure_images")]
        public bool? ReturnFigureImages { get; set; }

        /// <summary>
        /// If table images should be returned in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_table_images")]
        public bool? ReturnTableImages { get; set; }

        /// <summary>
        /// If full page images should be returned in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_page_images")]
        public bool? ReturnPageImages { get; set; }

        /// <summary>
        /// On a spreadsheet, the algorithm that is used to split up sheets into multiple tables.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_table_clustering")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetTableClusteringJsonConverter))]
        public global::Reducto.ProcessingOptionsSpreadsheetTableClustering? SpreadsheetTableClustering { get; set; }

        /// <summary>
        /// Spreadsheet loader backend. 'default' uses calamine (Rust), 'legacy' uses openpyxl. None defaults to calamine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_loader")]
        public global::Reducto.ProcessingOptionsSpreadsheetLoader2? SpreadsheetLoader { get; set; }

        /// <summary>
        /// If True, filter out boxes with width greater than 50% of the document width. Defaults to False. You probably don't want to use this.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("danger_filter_wide_boxes")]
        public bool? DangerFilterWideBoxes { get; set; }

        /// <summary>
        /// If True, add page markers to the output. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_page_markers")]
        public bool? AddPageMarkers { get; set; }

        /// <summary>
        /// Override the customer ID for the request. Defaults to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// If True, remove text formatting from the output (e.g. hyphens for list items). Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_text_formatting")]
        public bool? RemoveTextFormatting { get; set; }

        /// <summary>
        /// If True, return OCR data in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_ocr_data")]
        public bool? ReturnOcrData { get; set; }

        /// <summary>
        /// The name of the bucket to use for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string? BucketName { get; set; }

        /// <summary>
        /// The AWS KMS key to use for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_arn")]
        public string? KmsArn { get; set; }

        /// <summary>
        /// When embed_text_metadata_pdf is enabled, only embed non-overlapping text boxes. Defaults to False.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_vectorized_metadata")]
        public bool? NonVectorizedMetadata { get; set; }

        /// <summary>
        /// Forces all external API calls to be routed to specified country/region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_preference")]
        public string? RegionPreference { get; set; }

        /// <summary>
        /// If True, filter out line numbers from the output. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_line_numbers")]
        public bool? FilterLineNumbers { get; set; }

        /// <summary>
        /// The layout model to use for the document. This will be deprecated in the future.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsLayoutModelJsonConverter))]
        public global::Reducto.ProcessingOptionsLayoutModel? LayoutModel { get; set; }

        /// <summary>
        /// If True, persist the results indefinitely. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist_results")]
        public bool? PersistResults { get; set; }

        /// <summary>
        /// Skip hidden sheets in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_hidden_sheets")]
        public bool? ExcludeHiddenSheets { get; set; }

        /// <summary>
        /// Skip hidden rows and cols in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_hidden_rows_cols")]
        public bool? ExcludeHiddenRowsCols { get; set; }

        /// <summary>
        /// Skip styling in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_styling")]
        public bool? ExcludeStyling { get; set; }

        /// <summary>
        /// Skip spreadsheet images in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_spreadsheet_images")]
        public bool? ExcludeSpreadsheetImages { get; set; }

        /// <summary>
        /// If True, split table blocks into smaller chunks based on the specified chunk size in the chunking option. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_table_blocks")]
        public bool? ChunkTableBlocks { get; set; }

        /// <summary>
        /// If True, use Gemini 3.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_gemini_experimental_model")]
        public bool? UseGeminiExperimentalModel { get; set; }

        /// <summary>
        /// Custom instructions for agentic text OCR form regions (key-value) only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_text_prompt")]
        public string? AgenticTextPrompt { get; set; }

        /// <summary>
        /// Thinking level for Gemini 3 in key-value model. If set to 'high', uses high thinking level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_text_thinking_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ProcessingOptionsAgenticTextThinkingLevelJsonConverter))]
        public global::Reducto.ProcessingOptionsAgenticTextThinkingLevel? AgenticTextThinkingLevel { get; set; }

        /// <summary>
        /// Timeout for Gemini 3 in key-value model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kv_gemini_timeout")]
        public int? KvGeminiTimeout { get; set; }

        /// <summary>
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_sensitive")]
        public bool? LatencySensitive { get; set; }

        /// <summary>
        /// Replace the spreadsheet chunking size with the row/column specific chunk size<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_spreadsheet_chunking_size")]
        public bool? OverrideSpreadsheetChunkingSize { get; set; }

        /// <summary>
        /// Base class for the dynamically generated ProcessingOverrides model.<br/>
        /// This provides proper typing for the dynamically created model:<br/>
        /// - Can be used as a type annotation (it's a real class, not a variable)<br/>
        /// - Attribute access returns Any, suppressing type checker errors<br/>
        /// - Actual fields are added dynamically by build_processing_overrides()<br/>
        /// The dynamic subclass will have typed fields like:<br/>
        ///     key_value: KeyValueOverrides<br/>
        ///     summarize_all_figures: FigureSummaryOverrides<br/>
        ///     ...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::Reducto.ProcessingOverridesBase? Overrides { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("special_processing_vertical_docs")]
        public bool? SpecialProcessingVerticalDocs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingOptions" /> class.
        /// </summary>
        /// <param name="version">
        /// The version of the processing options.<br/>
        /// Default Value: v1
        /// </param>
        /// <param name="pdfOcr">
        /// The method to use for OCR. hybrid uses the PDF text first, then OCR. pdf only uses the PDF text. ocr only uses OCR.<br/>
        /// Default Value: ocr
        /// </param>
        /// <param name="ocrSystem">
        /// The OCR system to use. Defaults to cloud (AWS Textract/Azure DocAI/etc).<br/>
        /// Default Value: textract
        /// </param>
        /// <param name="ocrMode">
        /// The mode to use for OCR. If agentic is enabled, table OCR will be automatically edited.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="documentPassword">
        /// Password to decrypt password-protected documents.
        /// </param>
        /// <param name="tableOutputFormat">
        /// The mode to use for table output. Defaults to html.<br/>
        /// Default Value: html
        /// </param>
        /// <param name="inferTableColor">
        /// If table cell colors should be used to determine table structure. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeColorInformation">
        /// If True, preserve color information in spreadsheet cells by wrapping text with LaTeX color commands during parsing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFormulaInformation">
        /// If True, preserve formula information in spreadsheet cells by wrapping text with LaTeX formula commands during parsing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeDropdownInformation">
        /// If True, include dropdown options and the selected value when rendering spreadsheet cells.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chunkMode">
        /// The mode to use for chunking. Defaults to 'variable'. Section chunks according to sections in the document. Page chunks according to pages. Page sections chunks according to both pages and sections. Disabled returns a single chunk.<br/>
        /// Default Value: variable
        /// </param>
        /// <param name="chunkSize">
        /// The approximate size of chunks (in characters) that the document will be split into. Defaults to None, in which case the chunk size is variable between 250 - 1500 characters.
        /// </param>
        /// <param name="chunkOverlap">
        /// Number of characters of overlap from adjacent chunks. Defaults to 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="disableChunking">
        /// DEPRECATED, use chunk_mode=disabled instead<br/>
        /// Default Value: false
        /// </param>
        /// <param name="continueHierarchy">
        /// A flag to indicate if the hierarchy of the document should be continued from chunk to chunk. E.g. ## Prev Section (cont.)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="mode">
        /// The type of document to be processed. Defaults to document. If auto is specified, the orientation of the first page will be used to determine the document type.<br/>
        /// Default Value: document
        /// </param>
        /// <param name="tableSummary">
        /// If tables should be summarized for embedding. Defaults to True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="tableSummaryPrompt">
        /// Add information to the prompt for table summarization.
        /// </param>
        /// <param name="figureSummary">
        /// A flag to indicate if figure summarization should be performed. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="figureSummaryPrompt">
        /// Add information to the prompt for figure summarization.
        /// </param>
        /// <param name="figureSummaryOverride">
        /// If the figure summary prompt should override our default prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enhancedFigureSummary">
        /// If True, use enhanced figure summarization pipeline for complex charts. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summarizeAllFigures">
        /// If True, enable figure summaries for all figures regardless of size (onprem only). Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chartExtract">
        /// A flag to indicate if bar chart extraction should be performed (requires figure_summary=True). Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="intelligentOrdering">
        /// If True, use an advanced vision language model to improve reading order accuracy, with a small increase in latency. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enrich">
        /// If enabled, a large language/vision model will be used to postprocess the extracted content. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enrichPrompt">
        /// Add information to the prompt for enrichment.
        /// </param>
        /// <param name="enrichMode">
        /// The mode to use for enrichment. Defaults to standard<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="betaLayoutEnrichment">
        /// If enabled, a large language/vision model will be used to postprocess the layout predictions. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ignoreBlocks">
        /// A list of block types to ignore. Defaults to ['Page Number', 'Header', 'Footer', 'Comment'].<br/>
        /// Default Value: []
        /// </param>
        /// <param name="chartAgentReturnOverlays">
        /// If True, return overlays for the chart. This is so you can use the overlays to double check the quality of the extraction<br/>
        /// Default Value: false
        /// </param>
        /// <param name="advancedChartAgent">
        /// If True, use the advanced chart agent. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mergeTables">
        /// A flag to indicate if consecutive tables with the same number of columns should be merged. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dpi">
        /// Optional PDF page render DPI. Values greater than 0 render page images at this DPI before layout, OCR, and figure cropping. Set to 0 to disable the override. Higher values increase resolution and latency.
        /// </param>
        /// <param name="forceUrlResult">
        /// Force the result to be returned in URL form.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="forceFileExtension">
        /// Force the URL to be downloaded as a specific file extension (e.g. `.png`).
        /// </param>
        /// <param name="forceFileMimetype">
        /// Force the URL to be downloaded as a specific MIME type (e.g. image/png).
        /// </param>
        /// <param name="customFormat"></param>
        /// <param name="useFastInference">
        /// Use a faster inference model for parsing. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useGpuOcr">
        /// Use GPU acceleration for OCR processing. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxBatchSize">
        /// The maximum number of pages to process in a single batch. Defaults to 10.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numOcrCrops">
        /// The dimension of the OCR crops along each axis. num_ocr_crops^2 is the total number of crops. Defaults to 2.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="timeout">
        /// LEGACY: For sync/on-prem only. The timeout for the job in seconds. Defaults to 1800.<br/>
        /// Default Value: 1800
        /// </param>
        /// <param name="userSpecifiedTimeoutSeconds">
        /// A user specified timeout, defaults to None
        /// </param>
        /// <param name="extraMetadata">
        /// Extra metadata to be added to logs.
        /// </param>
        /// <param name="embedTextMetadataPdf">
        /// If True, embed text metadata into the returned PDF. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="numericalParseConfidence">
        /// If True, enable numeric parse confidence scores in granular_confidence field. Defaults to False.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="detectSignatures">
        /// If True, detect signatures in the document. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ignoreWatermarks">
        /// If True, ignore and remove watermarks from OCR output. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useHtmlToPdf">
        /// If True, use HTML rendered as PDF for parsing. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enhancedDocxConversion">
        /// Instead of using LibreOffice, when enabled, this flag uses a Windows VM to convert docx files. This is slower but more accurate.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableOfficeExternalLinks">
        /// If True, configure LibreOffice conversion to block linked content from untrusted documents. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nativeDocxParsing">
        /// If True, parse DOCX files natively instead of converting them to PDF first. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="jsonBbox">
        /// If True, include bounding box information in JSON table output. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="experimentalLargeSpreadsheetTableChunking">
        /// Note, this is an alpha feature subject to change at any time. If enabled, large tables will be chunked into multiple tables. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useCheckboxes">
        /// Add checkboxes to the output, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useEquations">
        /// Add equations to the output, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageStart">
        /// The page number to start processing from.
        /// </param>
        /// <param name="pageEnd">
        /// The page number to stop processing at.
        /// </param>
        /// <param name="pageRange">
        /// The page range to process. For spreadsheets, you can also provide a list of sheet names.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="keepLineBreaks">
        /// If line breaks should be preserved in the text. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overlapThreshold">
        /// The threshold for box overlap. Defaults to 0.5.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="largeTableChunking">
        /// If large tables should be chunked into smaller tables, currently only supported on spreadsheet and CSV files.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="largeTableChunkingSize">
        /// The max row/column size for a table to be chunked. Defaults to 50.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="rotatePages">
        /// Use an orientation model to detect and rotate pages as needed, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rotateFigures">
        /// Use an orientation model to detect and rotate figures as needed, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableChangeTracking">
        /// Add &lt;u&gt; tag around text that's underlined and surround strikethroughs and underlines with &lt;change&gt; tags, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableHighlightDetection">
        /// Add &lt;mark&gt; tags around highlighted text detected using the segmentation model, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableScripts">
        /// Add &lt;sub&gt; tag around subscripts and &lt;sup&gt; tag around superscripts, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableComments">
        /// Pull PDF comments from the document, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableHyperlinks">
        /// Extract hyperlinks from the document, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnFigureImages">
        /// If figure images should be returned in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnTableImages">
        /// If table images should be returned in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnPageImages">
        /// If full page images should be returned in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetTableClustering">
        /// On a spreadsheet, the algorithm that is used to split up sheets into multiple tables.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="spreadsheetLoader">
        /// Spreadsheet loader backend. 'default' uses calamine (Rust), 'legacy' uses openpyxl. None defaults to calamine.
        /// </param>
        /// <param name="dangerFilterWideBoxes">
        /// If True, filter out boxes with width greater than 50% of the document width. Defaults to False. You probably don't want to use this.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="addPageMarkers">
        /// If True, add page markers to the output. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customerId">
        /// Override the customer ID for the request. Defaults to None.
        /// </param>
        /// <param name="removeTextFormatting">
        /// If True, remove text formatting from the output (e.g. hyphens for list items). Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnOcrData">
        /// If True, return OCR data in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="bucketName">
        /// The name of the bucket to use for the document.
        /// </param>
        /// <param name="kmsArn">
        /// The AWS KMS key to use for the document.
        /// </param>
        /// <param name="nonVectorizedMetadata">
        /// When embed_text_metadata_pdf is enabled, only embed non-overlapping text boxes. Defaults to False.
        /// </param>
        /// <param name="regionPreference">
        /// Forces all external API calls to be routed to specified country/region.
        /// </param>
        /// <param name="filterLineNumbers">
        /// If True, filter out line numbers from the output. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="layoutModel">
        /// The layout model to use for the document. This will be deprecated in the future.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="persistResults">
        /// If True, persist the results indefinitely. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeHiddenSheets">
        /// Skip hidden sheets in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeHiddenRowsCols">
        /// Skip hidden rows and cols in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeStyling">
        /// Skip styling in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeSpreadsheetImages">
        /// Skip spreadsheet images in Excel files. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chunkTableBlocks">
        /// If True, split table blocks into smaller chunks based on the specified chunk size in the chunking option. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useGeminiExperimentalModel">
        /// If True, use Gemini 3.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="agenticTextPrompt">
        /// Custom instructions for agentic text OCR form regions (key-value) only.
        /// </param>
        /// <param name="agenticTextThinkingLevel">
        /// Thinking level for Gemini 3 in key-value model. If set to 'high', uses high thinking level.
        /// </param>
        /// <param name="kvGeminiTimeout">
        /// Timeout for Gemini 3 in key-value model.
        /// </param>
        /// <param name="latencySensitive">
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overrideSpreadsheetChunkingSize">
        /// Replace the spreadsheet chunking size with the row/column specific chunk size<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overrides">
        /// Base class for the dynamically generated ProcessingOverrides model.<br/>
        /// This provides proper typing for the dynamically created model:<br/>
        /// - Can be used as a type annotation (it's a real class, not a variable)<br/>
        /// - Attribute access returns Any, suppressing type checker errors<br/>
        /// - Actual fields are added dynamically by build_processing_overrides()<br/>
        /// The dynamic subclass will have typed fields like:<br/>
        ///     key_value: KeyValueOverrides<br/>
        ///     summarize_all_figures: FigureSummaryOverrides<br/>
        ///     ...
        /// </param>
        /// <param name="specialProcessingVerticalDocs">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingOptions(
            global::Reducto.ProcessingOptionsVersion? version,
            global::Reducto.ProcessingOptionsPdfOcr? pdfOcr,
            global::Reducto.ProcessingOptionsOcrSystem? ocrSystem,
            global::Reducto.ProcessingOptionsOcrMode? ocrMode,
            string? documentPassword,
            global::Reducto.ProcessingOptionsTableOutputFormat? tableOutputFormat,
            bool? inferTableColor,
            bool? includeColorInformation,
            bool? includeFormulaInformation,
            bool? includeDropdownInformation,
            global::Reducto.ProcessingOptionsChunkMode? chunkMode,
            int? chunkSize,
            int? chunkOverlap,
            bool? disableChunking,
            bool? continueHierarchy,
            global::Reducto.ProcessingOptionsMode? mode,
            bool? tableSummary,
            string? tableSummaryPrompt,
            bool? figureSummary,
            string? figureSummaryPrompt,
            bool? figureSummaryOverride,
            bool? enhancedFigureSummary,
            bool? summarizeAllFigures,
            bool? chartExtract,
            bool? intelligentOrdering,
            bool? enrich,
            string? enrichPrompt,
            global::Reducto.ProcessingOptionsEnrichMode? enrichMode,
            bool? betaLayoutEnrichment,
            global::System.Collections.Generic.IList<global::Reducto.ProcessingOptionsIgnoreBlock>? ignoreBlocks,
            bool? chartAgentReturnOverlays,
            bool? advancedChartAgent,
            bool? mergeTables,
            int? dpi,
            bool? forceUrlResult,
            string? forceFileExtension,
            string? forceFileMimetype,
            global::Reducto.ProcessingOptionsCustomFormat? customFormat,
            bool? useFastInference,
            bool? useGpuOcr,
            int? maxBatchSize,
            int? numOcrCrops,
            double? timeout,
            double? userSpecifiedTimeoutSeconds,
            object? extraMetadata,
            bool? embedTextMetadataPdf,
            bool? numericalParseConfidence,
            bool? detectSignatures,
            bool? ignoreWatermarks,
            bool? useHtmlToPdf,
            bool? enhancedDocxConversion,
            bool? disableOfficeExternalLinks,
            bool? nativeDocxParsing,
            bool? jsonBbox,
            bool? experimentalLargeSpreadsheetTableChunking,
            bool? useCheckboxes,
            bool? useEquations,
            int? pageStart,
            int? pageEnd,
            global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>? pageRange,
            bool? keepLineBreaks,
            double? overlapThreshold,
            bool? largeTableChunking,
            int? largeTableChunkingSize,
            bool? rotatePages,
            bool? rotateFigures,
            bool? enableChangeTracking,
            bool? enableHighlightDetection,
            bool? enableScripts,
            bool? enableComments,
            bool? enableHyperlinks,
            bool? returnFigureImages,
            bool? returnTableImages,
            bool? returnPageImages,
            global::Reducto.ProcessingOptionsSpreadsheetTableClustering? spreadsheetTableClustering,
            global::Reducto.ProcessingOptionsSpreadsheetLoader2? spreadsheetLoader,
            bool? dangerFilterWideBoxes,
            bool? addPageMarkers,
            string? customerId,
            bool? removeTextFormatting,
            bool? returnOcrData,
            string? bucketName,
            string? kmsArn,
            bool? nonVectorizedMetadata,
            string? regionPreference,
            bool? filterLineNumbers,
            global::Reducto.ProcessingOptionsLayoutModel? layoutModel,
            bool? persistResults,
            bool? excludeHiddenSheets,
            bool? excludeHiddenRowsCols,
            bool? excludeStyling,
            bool? excludeSpreadsheetImages,
            bool? chunkTableBlocks,
            bool? useGeminiExperimentalModel,
            string? agenticTextPrompt,
            global::Reducto.ProcessingOptionsAgenticTextThinkingLevel? agenticTextThinkingLevel,
            int? kvGeminiTimeout,
            bool? latencySensitive,
            bool? overrideSpreadsheetChunkingSize,
            global::Reducto.ProcessingOverridesBase? overrides,
            bool? specialProcessingVerticalDocs)
        {
            this.Version = version;
            this.PdfOcr = pdfOcr;
            this.OcrSystem = ocrSystem;
            this.OcrMode = ocrMode;
            this.DocumentPassword = documentPassword;
            this.TableOutputFormat = tableOutputFormat;
            this.InferTableColor = inferTableColor;
            this.IncludeColorInformation = includeColorInformation;
            this.IncludeFormulaInformation = includeFormulaInformation;
            this.IncludeDropdownInformation = includeDropdownInformation;
            this.ChunkMode = chunkMode;
            this.ChunkSize = chunkSize;
            this.ChunkOverlap = chunkOverlap;
            this.DisableChunking = disableChunking;
            this.ContinueHierarchy = continueHierarchy;
            this.Mode = mode;
            this.TableSummary = tableSummary;
            this.TableSummaryPrompt = tableSummaryPrompt;
            this.FigureSummary = figureSummary;
            this.FigureSummaryPrompt = figureSummaryPrompt;
            this.FigureSummaryOverride = figureSummaryOverride;
            this.EnhancedFigureSummary = enhancedFigureSummary;
            this.SummarizeAllFigures = summarizeAllFigures;
            this.ChartExtract = chartExtract;
            this.IntelligentOrdering = intelligentOrdering;
            this.Enrich = enrich;
            this.EnrichPrompt = enrichPrompt;
            this.EnrichMode = enrichMode;
            this.BetaLayoutEnrichment = betaLayoutEnrichment;
            this.IgnoreBlocks = ignoreBlocks;
            this.ChartAgentReturnOverlays = chartAgentReturnOverlays;
            this.AdvancedChartAgent = advancedChartAgent;
            this.MergeTables = mergeTables;
            this.Dpi = dpi;
            this.ForceUrlResult = forceUrlResult;
            this.ForceFileExtension = forceFileExtension;
            this.ForceFileMimetype = forceFileMimetype;
            this.CustomFormat = customFormat;
            this.UseFastInference = useFastInference;
            this.UseGpuOcr = useGpuOcr;
            this.MaxBatchSize = maxBatchSize;
            this.NumOcrCrops = numOcrCrops;
            this.Timeout = timeout;
            this.UserSpecifiedTimeoutSeconds = userSpecifiedTimeoutSeconds;
            this.ExtraMetadata = extraMetadata;
            this.EmbedTextMetadataPdf = embedTextMetadataPdf;
            this.NumericalParseConfidence = numericalParseConfidence;
            this.DetectSignatures = detectSignatures;
            this.IgnoreWatermarks = ignoreWatermarks;
            this.UseHtmlToPdf = useHtmlToPdf;
            this.EnhancedDocxConversion = enhancedDocxConversion;
            this.DisableOfficeExternalLinks = disableOfficeExternalLinks;
            this.NativeDocxParsing = nativeDocxParsing;
            this.JsonBbox = jsonBbox;
            this.ExperimentalLargeSpreadsheetTableChunking = experimentalLargeSpreadsheetTableChunking;
            this.UseCheckboxes = useCheckboxes;
            this.UseEquations = useEquations;
            this.PageStart = pageStart;
            this.PageEnd = pageEnd;
            this.PageRange = pageRange;
            this.KeepLineBreaks = keepLineBreaks;
            this.OverlapThreshold = overlapThreshold;
            this.LargeTableChunking = largeTableChunking;
            this.LargeTableChunkingSize = largeTableChunkingSize;
            this.RotatePages = rotatePages;
            this.RotateFigures = rotateFigures;
            this.EnableChangeTracking = enableChangeTracking;
            this.EnableHighlightDetection = enableHighlightDetection;
            this.EnableScripts = enableScripts;
            this.EnableComments = enableComments;
            this.EnableHyperlinks = enableHyperlinks;
            this.ReturnFigureImages = returnFigureImages;
            this.ReturnTableImages = returnTableImages;
            this.ReturnPageImages = returnPageImages;
            this.SpreadsheetTableClustering = spreadsheetTableClustering;
            this.SpreadsheetLoader = spreadsheetLoader;
            this.DangerFilterWideBoxes = dangerFilterWideBoxes;
            this.AddPageMarkers = addPageMarkers;
            this.CustomerId = customerId;
            this.RemoveTextFormatting = removeTextFormatting;
            this.ReturnOcrData = returnOcrData;
            this.BucketName = bucketName;
            this.KmsArn = kmsArn;
            this.NonVectorizedMetadata = nonVectorizedMetadata;
            this.RegionPreference = regionPreference;
            this.FilterLineNumbers = filterLineNumbers;
            this.LayoutModel = layoutModel;
            this.PersistResults = persistResults;
            this.ExcludeHiddenSheets = excludeHiddenSheets;
            this.ExcludeHiddenRowsCols = excludeHiddenRowsCols;
            this.ExcludeStyling = excludeStyling;
            this.ExcludeSpreadsheetImages = excludeSpreadsheetImages;
            this.ChunkTableBlocks = chunkTableBlocks;
            this.UseGeminiExperimentalModel = useGeminiExperimentalModel;
            this.AgenticTextPrompt = agenticTextPrompt;
            this.AgenticTextThinkingLevel = agenticTextThinkingLevel;
            this.KvGeminiTimeout = kvGeminiTimeout;
            this.LatencySensitive = latencySensitive;
            this.OverrideSpreadsheetChunkingSize = overrideSpreadsheetChunkingSize;
            this.Overrides = overrides;
            this.SpecialProcessingVerticalDocs = specialProcessingVerticalDocs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingOptions" /> class.
        /// </summary>
        public ProcessingOptions()
        {
        }
    }
}