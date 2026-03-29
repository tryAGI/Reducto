
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Configuration for parsing a document
    /// </summary>
    public sealed partial class ParseConfig
    {
        /// <summary>
        /// The URL of the document to process. Either a public URL or a presigned URL with a valid expiration time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>> DocumentUrl { get; set; }

        /// <summary>
        /// The configuration options for processing the document.<br/>
        /// Default Value: {"version":"v1","pdf_ocr":"ocr","ocr_system":"textract","ocr_mode":"standard","table_output_format":"html","infer_table_color":false,"include_color_information":false,"include_formula_information":false,"include_dropdown_information":false,"chunk_mode":"variable","chunk_overlap":0,"disable_chunking":false,"continue_hierarchy":true,"mode":"document","table_summary":true,"figure_summary":false,"figure_summary_override":false,"enhanced_figure_summary":false,"summarize_all_figures":false,"chart_extract":false,"intelligent_ordering":false,"enrich":false,"enrich_mode":"standard","beta_layout_enrichment":false,"ignore_blocks":[],"chart_agent_return_overlays":false,"advanced_chart_agent":false,"merge_tables":false,"force_url_result":false,"use_fast_inference":false,"use_gpu_ocr":false,"max_batch_size":10,"num_ocr_crops":2,"timeout":1800,"extra_metadata":{},"embed_text_metadata_pdf":false,"numerical_parse_confidence":true,"detect_signatures":false,"ignore_watermarks":false,"use_html_to_pdf":false,"enhanced_docx_conversion":false,"disable_office_external_links":false,"native_docx_parsing":false,"json_bbox":false,"experimental_large_spreadsheet_table_chunking":false,"use_checkboxes":false,"use_equations":false,"page_range":[{}],"keep_line_breaks":false,"overlap_threshold":0.5,"large_table_chunking":true,"large_table_chunking_size":50,"rotate_pages":false,"rotate_figures":false,"enable_change_tracking":false,"enable_highlight_detection":false,"enable_scripts":false,"enable_comments":false,"enable_hyperlinks":false,"return_figure_images":false,"return_table_images":false,"return_page_images":false,"spreadsheet_table_clustering":"default","danger_filter_wide_boxes":false,"add_page_markers":false,"remove_text_formatting":false,"return_ocr_data":false,"filter_line_numbers":false,"layout_model":"default","persist_results":false,"exclude_hidden_sheets":false,"exclude_hidden_rows_cols":false,"exclude_styling":false,"exclude_spreadsheet_images":false,"chunk_table_blocks":false,"use_gemini_experimental_model":false,"latency_sensitive":false,"agentic_layout":false,"agentic_layout_mode":"default","track_offsets":false,"track_word_offsets":false,"track_line_offsets":false,"override_spreadsheet_chunking_size":false,"overrides":{},"debug_layout_stages":false,"special_processing_vertical_docs":false,"kv_onprem":false,"deprio_kv_regions":false,"postprocess_v2":false,"force_abtest_ordering":false,"promptable_agentic_text_on_regular_blocks":false,"use_fast_reducto":false,"auto_formatting":false,"shadow_tag":"","shadow_original_job_id":"","shadow_original_org_id":"","shadow_original_org_name":"","shadow_affected_domains":[],"force_save_layout_intermediates":false,"use_local_ocr_pipeline":false,"fast_agentic_tables":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Reducto.ProcessingOptions? Config { get; set; }

        /// <summary>
        /// The configuration options for asynchronous processing (default synchronous).<br/>
        /// Default Value: {"enabled":false,"priority":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public global::Reducto.ConfigInternalAsyncConfig? Async { get; set; }

        /// <summary>
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public bool? Priority { get; set; }

        /// <summary>
        /// Queue priority for this job. 'auto' uses the system default. 'batch' places the job in a lower-priority queue that processes when GPU capacity is available, suitable for non-urgent bulk work.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.QueuePriorityJsonConverter))]
        public global::Reducto.QueuePriority? QueuePriority { get; set; }

        /// <summary>
        /// User-specific configuration options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_config")]
        public object? UserConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfig" /> class.
        /// </summary>
        /// <param name="documentUrl">
        /// The URL of the document to process. Either a public URL or a presigned URL with a valid expiration time.
        /// </param>
        /// <param name="config">
        /// The configuration options for processing the document.<br/>
        /// Default Value: {"version":"v1","pdf_ocr":"ocr","ocr_system":"textract","ocr_mode":"standard","table_output_format":"html","infer_table_color":false,"include_color_information":false,"include_formula_information":false,"include_dropdown_information":false,"chunk_mode":"variable","chunk_overlap":0,"disable_chunking":false,"continue_hierarchy":true,"mode":"document","table_summary":true,"figure_summary":false,"figure_summary_override":false,"enhanced_figure_summary":false,"summarize_all_figures":false,"chart_extract":false,"intelligent_ordering":false,"enrich":false,"enrich_mode":"standard","beta_layout_enrichment":false,"ignore_blocks":[],"chart_agent_return_overlays":false,"advanced_chart_agent":false,"merge_tables":false,"force_url_result":false,"use_fast_inference":false,"use_gpu_ocr":false,"max_batch_size":10,"num_ocr_crops":2,"timeout":1800,"extra_metadata":{},"embed_text_metadata_pdf":false,"numerical_parse_confidence":true,"detect_signatures":false,"ignore_watermarks":false,"use_html_to_pdf":false,"enhanced_docx_conversion":false,"disable_office_external_links":false,"native_docx_parsing":false,"json_bbox":false,"experimental_large_spreadsheet_table_chunking":false,"use_checkboxes":false,"use_equations":false,"page_range":[{}],"keep_line_breaks":false,"overlap_threshold":0.5,"large_table_chunking":true,"large_table_chunking_size":50,"rotate_pages":false,"rotate_figures":false,"enable_change_tracking":false,"enable_highlight_detection":false,"enable_scripts":false,"enable_comments":false,"enable_hyperlinks":false,"return_figure_images":false,"return_table_images":false,"return_page_images":false,"spreadsheet_table_clustering":"default","danger_filter_wide_boxes":false,"add_page_markers":false,"remove_text_formatting":false,"return_ocr_data":false,"filter_line_numbers":false,"layout_model":"default","persist_results":false,"exclude_hidden_sheets":false,"exclude_hidden_rows_cols":false,"exclude_styling":false,"exclude_spreadsheet_images":false,"chunk_table_blocks":false,"use_gemini_experimental_model":false,"latency_sensitive":false,"agentic_layout":false,"agentic_layout_mode":"default","track_offsets":false,"track_word_offsets":false,"track_line_offsets":false,"override_spreadsheet_chunking_size":false,"overrides":{},"debug_layout_stages":false,"special_processing_vertical_docs":false,"kv_onprem":false,"deprio_kv_regions":false,"postprocess_v2":false,"force_abtest_ordering":false,"promptable_agentic_text_on_regular_blocks":false,"use_fast_reducto":false,"auto_formatting":false,"shadow_tag":"","shadow_original_job_id":"","shadow_original_org_id":"","shadow_original_org_name":"","shadow_affected_domains":[],"force_save_layout_intermediates":false,"use_local_ocr_pipeline":false,"fast_agentic_tables":false}
        /// </param>
        /// <param name="async">
        /// The configuration options for asynchronous processing (default synchronous).<br/>
        /// Default Value: {"enabled":false,"priority":false}
        /// </param>
        /// <param name="priority">
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="queuePriority">
        /// Queue priority for this job. 'auto' uses the system default. 'batch' places the job in a lower-priority queue that processes when GPU capacity is available, suitable for non-urgent bulk work.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="userConfig">
        /// User-specific configuration options.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseConfig(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>> documentUrl,
            global::Reducto.ProcessingOptions? config,
            global::Reducto.ConfigInternalAsyncConfig? async,
            bool? priority,
            global::Reducto.QueuePriority? queuePriority,
            object? userConfig)
        {
            this.DocumentUrl = documentUrl;
            this.Config = config;
            this.Async = async;
            this.Priority = priority;
            this.QueuePriority = queuePriority;
            this.UserConfig = userConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfig" /> class.
        /// </summary>
        public ParseConfig()
        {
        }
    }
}