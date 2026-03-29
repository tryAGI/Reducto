
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractConfigNew
    {
        /// <summary>
        /// Default Value: {"ocr_mode":"standard","extraction_mode":"ocr","chunking":{"chunk_mode":"variable","chunk_overlap":0},"table_summary":{"enabled":false},"figure_summary":{"advanced_chart_agent":false,"enabled":false,"enhanced":false,"override":false},"filter_blocks":[],"force_url_result":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Reducto.BaseProcessingOptions? Options { get; set; }

        /// <summary>
        /// Default Value: {"ocr_system":"highres","table_output_format":"html","merge_tables":false,"include_formula_information":false,"include_color_information":false,"include_dropdown_information":false,"continue_hierarchy":true,"keep_line_breaks":false,"page_range":{},"large_table_chunking":{"enabled":true,"size":50},"spreadsheet_table_clustering":"default","add_page_markers":false,"remove_text_formatting":false,"return_ocr_data":false,"filter_line_numbers":false,"read_comments":false,"persist_results":false,"exclude_hidden_sheets":false,"exclude_hidden_rows_cols":false,"enable_change_tracking":false,"enable_highlight_detection":false,"ignore_watermarks":false,"track_offsets":false,"track_word_offsets":false,"track_line_offsets":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_options")]
        public global::Reducto.AdvancedProcessingOptions? AdvancedOptions { get; set; }

        /// <summary>
        /// Default Value: {"enrich":{"enabled":false,"mode":"standard"},"layout_enrichment":false,"native_docx_parsing":false,"native_office_conversion":false,"disable_office_external_links":false,"enable_checkboxes":false,"enable_equations":false,"rotate_pages":true,"rotate_figures":false,"enable_scripts":false,"return_figure_images":false,"return_table_images":false,"return_page_images":false,"layout_model":"default","embed_text_metadata_pdf":false,"detect_signatures":false,"agentic_layout":false,"danger_filter_wide_boxes":false,"chunk_table_blocks":false,"use_fast_reducto":false,"use_local_ocr_pipeline":false,"use_gemini_experimental_model":false,"latency_sensitive":false,"promptable_agentic_text_on_regular_blocks":false,"deprio_kv_regions":false,"postprocess_v2":false,"fast_agentic_tables":false,"auto_formatting":false,"shadow_tag":"","shadow_original_job_id":"","shadow_original_org_id":"","shadow_original_org_name":"","shadow_affected_domains":[],"force_save_layout_intermediates":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental_options")]
        public global::Reducto.ExperimentalProcessingOptions? ExperimentalOptions { get; set; }

        /// <summary>
        /// The JSON schema to use for extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// A system prompt to use for the extraction. This is a general prompt that is applied to the entire document before any other prompts.<br/>
        /// Default Value: Be precise and thorough.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// If True, use Deep Extract, an agentic extraction mode that iteratively refines its output to achieve near-perfect accuracy. Best for complex documents where accuracy is critical.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_extract")]
        public bool? DeepExtract { get; set; }

        /// <summary>
        /// If citations should be generated for the extracted content.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_citations")]
        public bool? GenerateCitations { get; set; }

        /// <summary>
        /// The configuration options for array extract<br/>
        /// Default Value: {"enabled":false,"mode":"legacy","pages_per_segment":10,"streaming_extract_item_density":50}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array_extract")]
        public global::Reducto.ArrayExtractConfig? ArrayExtract { get; set; }

        /// <summary>
        /// If chunking should be used for the extraction. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_chunking")]
        public bool? UseChunking { get; set; }

        /// <summary>
        /// If images should be passed directly for extractions. Can only be enabled for documents with less than 10 pages. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// If spreadsheet agent should be used for extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_agent")]
        public bool? SpreadsheetAgent { get; set; }

        /// <summary>
        /// If table citations should be generated for the extracted content.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental_table_citations")]
        public bool? ExperimentalTableCitations { get; set; }

        /// <summary>
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public bool? Priority { get; set; }

        /// <summary>
        /// The configuration options for citations.<br/>
        /// Default Value: {"numerical_confidence":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations_options")]
        public global::Reducto.AdvancedCitationsConfig? CitationsOptions { get; set; }

        /// <summary>
        /// The configuration options for agent extract<br/>
        /// Default Value: {"enabled":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_extract")]
        public global::Reducto.AgentExtractConfig? AgentExtract { get; set; }

        /// <summary>
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_sensitive")]
        public bool? LatencySensitive { get; set; }

        /// <summary>
        /// The URL of the document to be processed. You can provide one of the following:<br/>
        /// 1. A publicly available URL<br/>
        /// 2. A presigned S3 URL<br/>
        /// 3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document<br/>
        /// 4. A job_id (jobid://) or a list of job_ids (jobid://) obtained from a previous /parse endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> DocumentUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfigNew" /> class.
        /// </summary>
        /// <param name="schema">
        /// The JSON schema to use for extraction.
        /// </param>
        /// <param name="documentUrl">
        /// The URL of the document to be processed. You can provide one of the following:<br/>
        /// 1. A publicly available URL<br/>
        /// 2. A presigned S3 URL<br/>
        /// 3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document<br/>
        /// 4. A job_id (jobid://) or a list of job_ids (jobid://) obtained from a previous /parse endpoint
        /// </param>
        /// <param name="options">
        /// Default Value: {"ocr_mode":"standard","extraction_mode":"ocr","chunking":{"chunk_mode":"variable","chunk_overlap":0},"table_summary":{"enabled":false},"figure_summary":{"advanced_chart_agent":false,"enabled":false,"enhanced":false,"override":false},"filter_blocks":[],"force_url_result":false}
        /// </param>
        /// <param name="advancedOptions">
        /// Default Value: {"ocr_system":"highres","table_output_format":"html","merge_tables":false,"include_formula_information":false,"include_color_information":false,"include_dropdown_information":false,"continue_hierarchy":true,"keep_line_breaks":false,"page_range":{},"large_table_chunking":{"enabled":true,"size":50},"spreadsheet_table_clustering":"default","add_page_markers":false,"remove_text_formatting":false,"return_ocr_data":false,"filter_line_numbers":false,"read_comments":false,"persist_results":false,"exclude_hidden_sheets":false,"exclude_hidden_rows_cols":false,"enable_change_tracking":false,"enable_highlight_detection":false,"ignore_watermarks":false,"track_offsets":false,"track_word_offsets":false,"track_line_offsets":false}
        /// </param>
        /// <param name="experimentalOptions">
        /// Default Value: {"enrich":{"enabled":false,"mode":"standard"},"layout_enrichment":false,"native_docx_parsing":false,"native_office_conversion":false,"disable_office_external_links":false,"enable_checkboxes":false,"enable_equations":false,"rotate_pages":true,"rotate_figures":false,"enable_scripts":false,"return_figure_images":false,"return_table_images":false,"return_page_images":false,"layout_model":"default","embed_text_metadata_pdf":false,"detect_signatures":false,"agentic_layout":false,"danger_filter_wide_boxes":false,"chunk_table_blocks":false,"use_fast_reducto":false,"use_local_ocr_pipeline":false,"use_gemini_experimental_model":false,"latency_sensitive":false,"promptable_agentic_text_on_regular_blocks":false,"deprio_kv_regions":false,"postprocess_v2":false,"fast_agentic_tables":false,"auto_formatting":false,"shadow_tag":"","shadow_original_job_id":"","shadow_original_org_id":"","shadow_original_org_name":"","shadow_affected_domains":[],"force_save_layout_intermediates":false}
        /// </param>
        /// <param name="systemPrompt">
        /// A system prompt to use for the extraction. This is a general prompt that is applied to the entire document before any other prompts.<br/>
        /// Default Value: Be precise and thorough.
        /// </param>
        /// <param name="deepExtract">
        /// If True, use Deep Extract, an agentic extraction mode that iteratively refines its output to achieve near-perfect accuracy. Best for complex documents where accuracy is critical.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="generateCitations">
        /// If citations should be generated for the extracted content.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="arrayExtract">
        /// The configuration options for array extract<br/>
        /// Default Value: {"enabled":false,"mode":"legacy","pages_per_segment":10,"streaming_extract_item_density":50}
        /// </param>
        /// <param name="useChunking">
        /// If chunking should be used for the extraction. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeImages">
        /// If images should be passed directly for extractions. Can only be enabled for documents with less than 10 pages. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetAgent">
        /// If spreadsheet agent should be used for extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="experimentalTableCitations">
        /// If table citations should be generated for the extracted content.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="priority">
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="citationsOptions">
        /// The configuration options for citations.<br/>
        /// Default Value: {"numerical_confidence":false}
        /// </param>
        /// <param name="agentExtract">
        /// The configuration options for agent extract<br/>
        /// Default Value: {"enabled":false}
        /// </param>
        /// <param name="latencySensitive">
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractConfigNew(
            object schema,
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> documentUrl,
            global::Reducto.BaseProcessingOptions? options,
            global::Reducto.AdvancedProcessingOptions? advancedOptions,
            global::Reducto.ExperimentalProcessingOptions? experimentalOptions,
            string? systemPrompt,
            bool? deepExtract,
            bool? generateCitations,
            global::Reducto.ArrayExtractConfig? arrayExtract,
            bool? useChunking,
            bool? includeImages,
            bool? spreadsheetAgent,
            bool? experimentalTableCitations,
            bool? priority,
            global::Reducto.AdvancedCitationsConfig? citationsOptions,
            global::Reducto.AgentExtractConfig? agentExtract,
            bool? latencySensitive)
        {
            this.Options = options;
            this.AdvancedOptions = advancedOptions;
            this.ExperimentalOptions = experimentalOptions;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.SystemPrompt = systemPrompt;
            this.DeepExtract = deepExtract;
            this.GenerateCitations = generateCitations;
            this.ArrayExtract = arrayExtract;
            this.UseChunking = useChunking;
            this.IncludeImages = includeImages;
            this.SpreadsheetAgent = spreadsheetAgent;
            this.ExperimentalTableCitations = experimentalTableCitations;
            this.Priority = priority;
            this.CitationsOptions = citationsOptions;
            this.AgentExtract = agentExtract;
            this.LatencySensitive = latencySensitive;
            this.DocumentUrl = documentUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfigNew" /> class.
        /// </summary>
        public ExtractConfigNew()
        {
        }
    }
}