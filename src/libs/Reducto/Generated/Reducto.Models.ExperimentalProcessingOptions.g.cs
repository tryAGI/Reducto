
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentalProcessingOptions
    {
        /// <summary>
        /// The configuration options for enrichment.<br/>
        /// Default Value: {"enabled":false,"mode":"standard"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrich")]
        public global::Reducto.EnrichConfig? Enrich { get; set; }

        /// <summary>
        /// Layout enrichment is a beta feature that improves our layout and reading order performance at the cost of increased latency. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_enrichment")]
        public bool? LayoutEnrichment { get; set; }

        /// <summary>
        /// Instead of using LibreOffice, when enabled, this flag uses a Windows VM to convert files. This is slower but more accurate.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_office_conversion")]
        public bool? NativeOfficeConversion { get; set; }

        /// <summary>
        /// If True, configure LibreOffice conversion to block linked content from untrusted documents. Defaults to True on-prem and False elsewhere.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_office_external_links")]
        public bool? DisableOfficeExternalLinks { get; set; }

        /// <summary>
        /// Use an experimental checkbox detection model to add checkboxes to the output, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_checkboxes")]
        public bool? EnableCheckboxes { get; set; }

        /// <summary>
        /// Use an experimental equation detection model to add equations to the output, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_equations")]
        public bool? EnableEquations { get; set; }

        /// <summary>
        /// Use an orientation model to detect and rotate pages as needed, defaults to True<br/>
        /// Default Value: true
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
        /// Add &lt;sub&gt; tag around subscripts and &lt;sup&gt; tag around superscripts, defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_scripts")]
        public bool? EnableScripts { get; set; }

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
        /// The layout model to use for the document. This will be deprecated in the future.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ExperimentalProcessingOptionsLayoutModelJsonConverter))]
        public global::Reducto.ExperimentalProcessingOptionsLayoutModel? LayoutModel { get; set; }

        /// <summary>
        /// If extracted OCR text metadata should be embedded back into the returned PDF, overwriting any existing text. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_text_metadata_pdf")]
        public bool? EmbedTextMetadataPdf { get; set; }

        /// <summary>
        /// If True, detect signatures in the document. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_signatures")]
        public bool? DetectSignatures { get; set; }

        /// <summary>
        /// You probably shouldn't use this. If True, filter out boxes with width greater than 50% of the document width. Defaults to False. You probably don't want to use this.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("danger_filter_wide_boxes")]
        public bool? DangerFilterWideBoxes { get; set; }

        /// <summary>
        /// A user specified timeout, defaults to None
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_specified_timeout_seconds")]
        public double? UserSpecifiedTimeoutSeconds { get; set; }

        /// <summary>
        /// If True, split table blocks into smaller chunks based on the specified chunk size in the chunking option. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_table_blocks")]
        public bool? ChunkTableBlocks { get; set; }

        /// <summary>
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_sensitive")]
        public bool? LatencySensitive { get; set; }

        /// <summary>
        /// If True, enable two-stage LLM pipeline for agentic text correction on regular text blocks. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptable_agentic_text_on_regular_blocks")]
        public bool? PromptableAgenticTextOnRegularBlocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalProcessingOptions" /> class.
        /// </summary>
        /// <param name="enrich">
        /// The configuration options for enrichment.<br/>
        /// Default Value: {"enabled":false,"mode":"standard"}
        /// </param>
        /// <param name="layoutEnrichment">
        /// Layout enrichment is a beta feature that improves our layout and reading order performance at the cost of increased latency. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nativeOfficeConversion">
        /// Instead of using LibreOffice, when enabled, this flag uses a Windows VM to convert files. This is slower but more accurate.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableOfficeExternalLinks">
        /// If True, configure LibreOffice conversion to block linked content from untrusted documents. Defaults to True on-prem and False elsewhere.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableCheckboxes">
        /// Use an experimental checkbox detection model to add checkboxes to the output, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableEquations">
        /// Use an experimental equation detection model to add equations to the output, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rotatePages">
        /// Use an orientation model to detect and rotate pages as needed, defaults to True<br/>
        /// Default Value: true
        /// </param>
        /// <param name="rotateFigures">
        /// Use an orientation model to detect and rotate figures as needed, defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableScripts">
        /// Add &lt;sub&gt; tag around subscripts and &lt;sup&gt; tag around superscripts, defaults to False<br/>
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
        /// <param name="layoutModel">
        /// The layout model to use for the document. This will be deprecated in the future.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="embedTextMetadataPdf">
        /// If extracted OCR text metadata should be embedded back into the returned PDF, overwriting any existing text. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="detectSignatures">
        /// If True, detect signatures in the document. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dangerFilterWideBoxes">
        /// You probably shouldn't use this. If True, filter out boxes with width greater than 50% of the document width. Defaults to False. You probably don't want to use this.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userSpecifiedTimeoutSeconds">
        /// A user specified timeout, defaults to None
        /// </param>
        /// <param name="chunkTableBlocks">
        /// If True, split table blocks into smaller chunks based on the specified chunk size in the chunking option. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="latencySensitive">
        /// If True, the job will be processed with lower latency and higher priority. Uses 2x the cost of a regular job. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="promptableAgenticTextOnRegularBlocks">
        /// If True, enable two-stage LLM pipeline for agentic text correction on regular text blocks. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentalProcessingOptions(
            global::Reducto.EnrichConfig? enrich,
            bool? layoutEnrichment,
            bool? nativeOfficeConversion,
            bool? disableOfficeExternalLinks,
            bool? enableCheckboxes,
            bool? enableEquations,
            bool? rotatePages,
            bool? rotateFigures,
            bool? enableScripts,
            bool? returnFigureImages,
            bool? returnTableImages,
            bool? returnPageImages,
            global::Reducto.ExperimentalProcessingOptionsLayoutModel? layoutModel,
            bool? embedTextMetadataPdf,
            bool? detectSignatures,
            bool? dangerFilterWideBoxes,
            double? userSpecifiedTimeoutSeconds,
            bool? chunkTableBlocks,
            bool? latencySensitive,
            bool? promptableAgenticTextOnRegularBlocks)
        {
            this.Enrich = enrich;
            this.LayoutEnrichment = layoutEnrichment;
            this.NativeOfficeConversion = nativeOfficeConversion;
            this.DisableOfficeExternalLinks = disableOfficeExternalLinks;
            this.EnableCheckboxes = enableCheckboxes;
            this.EnableEquations = enableEquations;
            this.RotatePages = rotatePages;
            this.RotateFigures = rotateFigures;
            this.EnableScripts = enableScripts;
            this.ReturnFigureImages = returnFigureImages;
            this.ReturnTableImages = returnTableImages;
            this.ReturnPageImages = returnPageImages;
            this.LayoutModel = layoutModel;
            this.EmbedTextMetadataPdf = embedTextMetadataPdf;
            this.DetectSignatures = detectSignatures;
            this.DangerFilterWideBoxes = dangerFilterWideBoxes;
            this.UserSpecifiedTimeoutSeconds = userSpecifiedTimeoutSeconds;
            this.ChunkTableBlocks = chunkTableBlocks;
            this.LatencySensitive = latencySensitive;
            this.PromptableAgenticTextOnRegularBlocks = promptableAgenticTextOnRegularBlocks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentalProcessingOptions" /> class.
        /// </summary>
        public ExperimentalProcessingOptions()
        {
        }
    }
}