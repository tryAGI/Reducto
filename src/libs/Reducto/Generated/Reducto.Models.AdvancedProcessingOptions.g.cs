
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdvancedProcessingOptions
    {
        /// <summary>
        /// The OCR system to use. Highres is recommended for documents with English characters. Legacy uses an alternative OCR backend.<br/>
        /// Default Value: highres
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsOcrSystemJsonConverter))]
        public global::Reducto.AdvancedProcessingOptionsOcrSystem? OcrSystem { get; set; }

        /// <summary>
        /// The mode to use for table output. Dynamic returns md for simpler tables and html for more complex tables.<br/>
        /// Default Value: html
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsTableOutputFormatJsonConverter))]
        public global::Reducto.AdvancedProcessingOptionsTableOutputFormat? TableOutputFormat { get; set; }

        /// <summary>
        /// A flag to indicate if consecutive tables with the same number of columns should be merged across breaks and spaces.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_tables")]
        public bool? MergeTables { get; set; }

        /// <summary>
        /// If True, preserve formula information in spreadsheet cells by wrapping text with LaTeX formula commands during parsing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_formula_information")]
        public bool? IncludeFormulaInformation { get; set; }

        /// <summary>
        /// If True, preserve Excel cell colours in the extracted spreadsheet text using LaTeX colour commands.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_color_information")]
        public bool? IncludeColorInformation { get; set; }

        /// <summary>
        /// If True, include dropdown options and the selected value when rendering spreadsheet cells.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_dropdown_information")]
        public bool? IncludeDropdownInformation { get; set; }

        /// <summary>
        /// A flag to indicate if the hierarchy of the document should be continued from chunk to chunk.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_hierarchy")]
        public bool? ContinueHierarchy { get; set; }

        /// <summary>
        /// If line breaks should be preserved in the text.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_line_breaks")]
        public bool? KeepLineBreaks { get; set; }

        /// <summary>
        /// The page range to process (1-indexed). By default, the entire document is processed. For spreadsheets, you can also provide a list of sheet names.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>))]
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>? PageRange { get; set; }

        /// <summary>
        /// Force the URL to be downloaded as a specific file extension (e.g. .png).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_file_extension")]
        public string? ForceFileExtension { get; set; }

        /// <summary>
        /// The configuration options for large table chunking (currently only supported on spreadsheet and CSV files).<br/>
        /// Default Value: {"enabled":true,"size":50}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_table_chunking")]
        public global::Reducto.LargeTableChunkingConfig? LargeTableChunking { get; set; }

        /// <summary>
        /// In a spreadsheet with different tables inside, we enable splitting up the tables by default. Intelligent mode applies more powerful models for superior accuracy, at 5× the default per-cell rate. Disabling will register as one large table.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_table_clustering")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsSpreadsheetTableClusteringJsonConverter))]
        public global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering? SpreadsheetTableClustering { get; set; }

        /// <summary>
        /// If True, add page markers to the output (e.g. [[PAGE 1 BEGINS HERE]] and [[PAGE 1 ENDS HERE]] added as blocks to the content). Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_page_markers")]
        public bool? AddPageMarkers { get; set; }

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
        /// Password to decrypt password-protected documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_password")]
        public string? DocumentPassword { get; set; }

        /// <summary>
        /// If True, filter out line numbers from the output. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_line_numbers")]
        public bool? FilterLineNumbers { get; set; }

        /// <summary>
        /// If True, pull in PDF comments from the document. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_comments")]
        public bool? ReadComments { get; set; }

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
        /// Enables model-based detection of underlines and strikethroughs, adding &lt;u&gt;/&lt;s&gt; tags to OCR text. Works with any extraction mode. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_change_tracking")]
        public bool? EnableChangeTracking { get; set; }

        /// <summary>
        /// If True, enable highlight detection. Highlighted text will be surrounded by &lt;mark&gt; tags in the output. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_highlight_detection")]
        public bool? EnableHighlightDetection { get; set; }

        /// <summary>
        /// If True, ignore and remove watermarks from OCR output. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_watermarks")]
        public bool? IgnoreWatermarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedProcessingOptions" /> class.
        /// </summary>
        /// <param name="ocrSystem">
        /// The OCR system to use. Highres is recommended for documents with English characters. Legacy uses an alternative OCR backend.<br/>
        /// Default Value: highres
        /// </param>
        /// <param name="tableOutputFormat">
        /// The mode to use for table output. Dynamic returns md for simpler tables and html for more complex tables.<br/>
        /// Default Value: html
        /// </param>
        /// <param name="mergeTables">
        /// A flag to indicate if consecutive tables with the same number of columns should be merged across breaks and spaces.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFormulaInformation">
        /// If True, preserve formula information in spreadsheet cells by wrapping text with LaTeX formula commands during parsing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeColorInformation">
        /// If True, preserve Excel cell colours in the extracted spreadsheet text using LaTeX colour commands.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeDropdownInformation">
        /// If True, include dropdown options and the selected value when rendering spreadsheet cells.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="continueHierarchy">
        /// A flag to indicate if the hierarchy of the document should be continued from chunk to chunk.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="keepLineBreaks">
        /// If line breaks should be preserved in the text.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageRange">
        /// The page range to process (1-indexed). By default, the entire document is processed. For spreadsheets, you can also provide a list of sheet names.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="forceFileExtension">
        /// Force the URL to be downloaded as a specific file extension (e.g. .png).
        /// </param>
        /// <param name="largeTableChunking">
        /// The configuration options for large table chunking (currently only supported on spreadsheet and CSV files).<br/>
        /// Default Value: {"enabled":true,"size":50}
        /// </param>
        /// <param name="spreadsheetTableClustering">
        /// In a spreadsheet with different tables inside, we enable splitting up the tables by default. Intelligent mode applies more powerful models for superior accuracy, at 5× the default per-cell rate. Disabling will register as one large table.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="addPageMarkers">
        /// If True, add page markers to the output (e.g. [[PAGE 1 BEGINS HERE]] and [[PAGE 1 ENDS HERE]] added as blocks to the content). Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="removeTextFormatting">
        /// If True, remove text formatting from the output (e.g. hyphens for list items). Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnOcrData">
        /// If True, return OCR data in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentPassword">
        /// Password to decrypt password-protected documents.
        /// </param>
        /// <param name="filterLineNumbers">
        /// If True, filter out line numbers from the output. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="readComments">
        /// If True, pull in PDF comments from the document. Defaults to False.<br/>
        /// Default Value: false
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
        /// <param name="enableChangeTracking">
        /// Enables model-based detection of underlines and strikethroughs, adding &lt;u&gt;/&lt;s&gt; tags to OCR text. Works with any extraction mode. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableHighlightDetection">
        /// If True, enable highlight detection. Highlighted text will be surrounded by &lt;mark&gt; tags in the output. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ignoreWatermarks">
        /// If True, ignore and remove watermarks from OCR output. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvancedProcessingOptions(
            global::Reducto.AdvancedProcessingOptionsOcrSystem? ocrSystem,
            global::Reducto.AdvancedProcessingOptionsTableOutputFormat? tableOutputFormat,
            bool? mergeTables,
            bool? includeFormulaInformation,
            bool? includeColorInformation,
            bool? includeDropdownInformation,
            bool? continueHierarchy,
            bool? keepLineBreaks,
            global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>? pageRange,
            string? forceFileExtension,
            global::Reducto.LargeTableChunkingConfig? largeTableChunking,
            global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering? spreadsheetTableClustering,
            bool? addPageMarkers,
            bool? removeTextFormatting,
            bool? returnOcrData,
            string? documentPassword,
            bool? filterLineNumbers,
            bool? readComments,
            bool? persistResults,
            bool? excludeHiddenSheets,
            bool? excludeHiddenRowsCols,
            bool? enableChangeTracking,
            bool? enableHighlightDetection,
            bool? ignoreWatermarks)
        {
            this.OcrSystem = ocrSystem;
            this.TableOutputFormat = tableOutputFormat;
            this.MergeTables = mergeTables;
            this.IncludeFormulaInformation = includeFormulaInformation;
            this.IncludeColorInformation = includeColorInformation;
            this.IncludeDropdownInformation = includeDropdownInformation;
            this.ContinueHierarchy = continueHierarchy;
            this.KeepLineBreaks = keepLineBreaks;
            this.PageRange = pageRange;
            this.ForceFileExtension = forceFileExtension;
            this.LargeTableChunking = largeTableChunking;
            this.SpreadsheetTableClustering = spreadsheetTableClustering;
            this.AddPageMarkers = addPageMarkers;
            this.RemoveTextFormatting = removeTextFormatting;
            this.ReturnOcrData = returnOcrData;
            this.DocumentPassword = documentPassword;
            this.FilterLineNumbers = filterLineNumbers;
            this.ReadComments = readComments;
            this.PersistResults = persistResults;
            this.ExcludeHiddenSheets = excludeHiddenSheets;
            this.ExcludeHiddenRowsCols = excludeHiddenRowsCols;
            this.EnableChangeTracking = enableChangeTracking;
            this.EnableHighlightDetection = enableHighlightDetection;
            this.IgnoreWatermarks = ignoreWatermarks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedProcessingOptions" /> class.
        /// </summary>
        public AdvancedProcessingOptions()
        {
        }
    }
}