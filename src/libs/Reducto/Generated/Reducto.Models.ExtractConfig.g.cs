
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>> DocumentUrl { get; set; }

        /// <summary>
        /// The configuration options for extraction.<br/>
        /// Default Value: {"version":"v1","pdf_ocr":"ocr","ocr_system":"textract","ocr_mode":"standard","table_output_format":"html","infer_table_color":false,"include_color_information":false,"include_formula_information":false,"include_dropdown_information":false,"chunk_mode":"variable","chunk_overlap":0,"disable_chunking":true,"continue_hierarchy":true,"mode":"document","table_summary":true,"figure_summary":false,"figure_summary_override":false,"enhanced_figure_summary":false,"summarize_all_figures":false,"chart_extract":false,"intelligent_ordering":false,"enrich":false,"enrich_mode":"standard","beta_layout_enrichment":false,"ignore_blocks":[],"chart_agent_return_overlays":false,"advanced_chart_agent":false,"merge_tables":false,"force_url_result":false,"use_fast_inference":false,"use_gpu_ocr":false,"max_batch_size":10,"num_ocr_crops":2,"timeout":1800,"extra_metadata":{},"embed_text_metadata_pdf":false,"numerical_parse_confidence":true,"detect_signatures":false,"ignore_watermarks":false,"use_html_to_pdf":false,"enhanced_docx_conversion":false,"disable_office_external_links":false,"native_docx_parsing":false,"json_bbox":false,"experimental_large_spreadsheet_table_chunking":false,"use_checkboxes":false,"use_equations":false,"page_range":[{}],"keep_line_breaks":false,"overlap_threshold":0.5,"large_table_chunking":true,"large_table_chunking_size":50,"rotate_pages":false,"rotate_figures":false,"enable_change_tracking":false,"enable_highlight_detection":false,"enable_scripts":false,"enable_comments":false,"enable_hyperlinks":false,"return_figure_images":false,"return_table_images":false,"return_page_images":false,"spreadsheet_table_clustering":"default","danger_filter_wide_boxes":false,"add_page_markers":false,"remove_text_formatting":false,"return_ocr_data":false,"filter_line_numbers":false,"layout_model":"default","persist_results":false,"exclude_hidden_sheets":false,"exclude_hidden_rows_cols":false,"exclude_styling":false,"exclude_spreadsheet_images":false,"chunk_table_blocks":false,"use_gemini_experimental_model":false,"latency_sensitive":false,"agentic_layout":false,"agentic_layout_mode":"default","track_offsets":false,"track_word_offsets":false,"track_line_offsets":false,"override_spreadsheet_chunking_size":false,"overrides":{},"debug_layout_stages":false,"special_processing_vertical_docs":false,"kv_onprem":false,"deprio_kv_regions":false,"postprocess_v2":false,"force_abtest_ordering":false,"promptable_agentic_text_on_regular_blocks":false,"use_fast_reducto":false,"auto_formatting":false,"shadow_tag":"","shadow_original_job_id":"","shadow_original_org_id":"","shadow_original_org_name":"","shadow_affected_domains":[],"force_save_layout_intermediates":false,"use_local_ocr_pipeline":false,"fast_agentic_tables":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_config")]
        public global::Reducto.ProcessingOptions? ParseConfig { get; set; }

        /// <summary>
        /// The configuration options for extraction.<br/>
        /// Default Value: {"generate_citations":false,"numerical_confidence":false,"spreadsheet_agent":false,"experimental_table_citations":true,"array_extract":false,"array_extract_pages":10,"extract_algorithm":"legacy","streaming_extract_item_density":50}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Reducto.ExtractConfigOptions? Options { get; set; }

        /// <summary>
        /// The JSON schema to use for extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// The normalized JSON schema to use for extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_schema")]
        public object? NormalizedSchema { get; set; }

        /// <summary>
        /// A system prompt to use for the extraction. This is a general prompt that is applied to the entire document before any other prompts.<br/>
        /// Default Value: Be concise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha_deep_extract")]
        public bool? AlphaDeepExtract { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha_table_citations")]
        public bool? AlphaTableCitations { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_extract")]
        public bool? DeepExtract { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_citations")]
        public bool? DeepCitations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_extract_current_output")]
        public object? DeepExtractCurrentOutput { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha_big_extraction_model")]
        public bool? AlphaBigExtractionModel { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_gemini_experimental_model")]
        public bool? UseGeminiExperimentalModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_model")]
        public string? ExtractModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_model_args")]
        public object? ExtractModelArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_reducto_prompt")]
        public string? InternalReductoPrompt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// If agent extraction should be used for extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_extract")]
        public bool? AgentExtract { get; set; }

        /// <summary>
        /// The name of the array that the agent will extract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_extract_line_item_name")]
        public string? AgentExtractLineItemName { get; set; }

        /// <summary>
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_sensitive")]
        public bool? LatencySensitive { get; set; }

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
        /// Initializes a new instance of the <see cref="ExtractConfig" /> class.
        /// </summary>
        /// <param name="documentUrl"></param>
        /// <param name="schema">
        /// The JSON schema to use for extraction.
        /// </param>
        /// <param name="parseConfig">
        /// The configuration options for extraction.<br/>
        /// Default Value: {"version":"v1","pdf_ocr":"ocr","ocr_system":"textract","ocr_mode":"standard","table_output_format":"html","infer_table_color":false,"include_color_information":false,"include_formula_information":false,"include_dropdown_information":false,"chunk_mode":"variable","chunk_overlap":0,"disable_chunking":true,"continue_hierarchy":true,"mode":"document","table_summary":true,"figure_summary":false,"figure_summary_override":false,"enhanced_figure_summary":false,"summarize_all_figures":false,"chart_extract":false,"intelligent_ordering":false,"enrich":false,"enrich_mode":"standard","beta_layout_enrichment":false,"ignore_blocks":[],"chart_agent_return_overlays":false,"advanced_chart_agent":false,"merge_tables":false,"force_url_result":false,"use_fast_inference":false,"use_gpu_ocr":false,"max_batch_size":10,"num_ocr_crops":2,"timeout":1800,"extra_metadata":{},"embed_text_metadata_pdf":false,"numerical_parse_confidence":true,"detect_signatures":false,"ignore_watermarks":false,"use_html_to_pdf":false,"enhanced_docx_conversion":false,"disable_office_external_links":false,"native_docx_parsing":false,"json_bbox":false,"experimental_large_spreadsheet_table_chunking":false,"use_checkboxes":false,"use_equations":false,"page_range":[{}],"keep_line_breaks":false,"overlap_threshold":0.5,"large_table_chunking":true,"large_table_chunking_size":50,"rotate_pages":false,"rotate_figures":false,"enable_change_tracking":false,"enable_highlight_detection":false,"enable_scripts":false,"enable_comments":false,"enable_hyperlinks":false,"return_figure_images":false,"return_table_images":false,"return_page_images":false,"spreadsheet_table_clustering":"default","danger_filter_wide_boxes":false,"add_page_markers":false,"remove_text_formatting":false,"return_ocr_data":false,"filter_line_numbers":false,"layout_model":"default","persist_results":false,"exclude_hidden_sheets":false,"exclude_hidden_rows_cols":false,"exclude_styling":false,"exclude_spreadsheet_images":false,"chunk_table_blocks":false,"use_gemini_experimental_model":false,"latency_sensitive":false,"agentic_layout":false,"agentic_layout_mode":"default","track_offsets":false,"track_word_offsets":false,"track_line_offsets":false,"override_spreadsheet_chunking_size":false,"overrides":{},"debug_layout_stages":false,"special_processing_vertical_docs":false,"kv_onprem":false,"deprio_kv_regions":false,"postprocess_v2":false,"force_abtest_ordering":false,"promptable_agentic_text_on_regular_blocks":false,"use_fast_reducto":false,"auto_formatting":false,"shadow_tag":"","shadow_original_job_id":"","shadow_original_org_id":"","shadow_original_org_name":"","shadow_affected_domains":[],"force_save_layout_intermediates":false,"use_local_ocr_pipeline":false,"fast_agentic_tables":false}
        /// </param>
        /// <param name="options">
        /// The configuration options for extraction.<br/>
        /// Default Value: {"generate_citations":false,"numerical_confidence":false,"spreadsheet_agent":false,"experimental_table_citations":true,"array_extract":false,"array_extract_pages":10,"extract_algorithm":"legacy","streaming_extract_item_density":50}
        /// </param>
        /// <param name="normalizedSchema">
        /// The normalized JSON schema to use for extraction.
        /// </param>
        /// <param name="systemPrompt">
        /// A system prompt to use for the extraction. This is a general prompt that is applied to the entire document before any other prompts.<br/>
        /// Default Value: Be concise.
        /// </param>
        /// <param name="alphaDeepExtract">
        /// Default Value: false
        /// </param>
        /// <param name="alphaTableCitations">
        /// Default Value: false
        /// </param>
        /// <param name="deepExtract">
        /// Default Value: false
        /// </param>
        /// <param name="deepCitations">
        /// Default Value: false
        /// </param>
        /// <param name="deepExtractCurrentOutput"></param>
        /// <param name="alphaBigExtractionModel">
        /// Default Value: false
        /// </param>
        /// <param name="useGeminiExperimentalModel">
        /// Default Value: false
        /// </param>
        /// <param name="extractModel"></param>
        /// <param name="extractModelArgs"></param>
        /// <param name="internalReductoPrompt"></param>
        /// <param name="includeImages">
        /// Default Value: false
        /// </param>
        /// <param name="agentExtract">
        /// If agent extraction should be used for extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="agentExtractLineItemName">
        /// The name of the array that the agent will extract.
        /// </param>
        /// <param name="latencySensitive">
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="async">
        /// The configuration options for asynchronous processing (default synchronous).<br/>
        /// Default Value: {"enabled":false,"priority":false}
        /// </param>
        /// <param name="priority">
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="userConfig">
        /// User-specific configuration options.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractConfig(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>> documentUrl,
            object schema,
            global::Reducto.ProcessingOptions? parseConfig,
            global::Reducto.ExtractConfigOptions? options,
            object? normalizedSchema,
            string? systemPrompt,
            bool? alphaDeepExtract,
            bool? alphaTableCitations,
            bool? deepExtract,
            bool? deepCitations,
            object? deepExtractCurrentOutput,
            bool? alphaBigExtractionModel,
            bool? useGeminiExperimentalModel,
            string? extractModel,
            object? extractModelArgs,
            string? internalReductoPrompt,
            bool? includeImages,
            bool? agentExtract,
            string? agentExtractLineItemName,
            bool? latencySensitive,
            global::Reducto.ConfigInternalAsyncConfig? async,
            bool? priority,
            object? userConfig)
        {
            this.DocumentUrl = documentUrl;
            this.ParseConfig = parseConfig;
            this.Options = options;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.NormalizedSchema = normalizedSchema;
            this.SystemPrompt = systemPrompt;
            this.AlphaDeepExtract = alphaDeepExtract;
            this.AlphaTableCitations = alphaTableCitations;
            this.DeepExtract = deepExtract;
            this.DeepCitations = deepCitations;
            this.DeepExtractCurrentOutput = deepExtractCurrentOutput;
            this.AlphaBigExtractionModel = alphaBigExtractionModel;
            this.UseGeminiExperimentalModel = useGeminiExperimentalModel;
            this.ExtractModel = extractModel;
            this.ExtractModelArgs = extractModelArgs;
            this.InternalReductoPrompt = internalReductoPrompt;
            this.IncludeImages = includeImages;
            this.AgentExtract = agentExtract;
            this.AgentExtractLineItemName = agentExtractLineItemName;
            this.LatencySensitive = latencySensitive;
            this.Async = async;
            this.Priority = priority;
            this.UserConfig = userConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfig" /> class.
        /// </summary>
        public ExtractConfig()
        {
        }
    }
}