
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Settings
    {
        /// <summary>
        /// Standard is our best multilingual OCR system. Legacy only supports germanic languages and is available for backwards compatibility.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SettingsOcrSystemJsonConverter))]
        public global::Reducto.SettingsOcrSystem? OcrSystem { get; set; }

        /// <summary>
        /// The mode to use for text extraction from PDFs. OCR mode uses optical character recognition only. Hybrid mode combines OCR with embedded PDF text for best accuracy (default).<br/>
        /// Default Value: hybrid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SettingsExtractionModeJsonConverter))]
        public global::Reducto.SettingsExtractionMode? ExtractionMode { get; set; }

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
        /// If True, return OCR data in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_ocr_data")]
        public bool? ReturnOcrData { get; set; }

        /// <summary>
        /// Whether to return images for the specified block types. 'page' returns full page images. By default, no images are returned.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_images")]
        public global::System.Collections.Generic.IList<global::Reducto.SettingsReturnImage>? ReturnImages { get; set; }

        /// <summary>
        /// If True, embed OCR metadata into the returned PDF. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_pdf_metadata")]
        public bool? EmbedPdfMetadata { get; set; }

        /// <summary>
        /// If True, persist the results indefinitely. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist_results")]
        public bool? PersistResults { get; set; }

        /// <summary>
        /// The timeout for the job in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// The page range to process (1-indexed). By default, the entire document is processed. For spreadsheets, you can also provide a list of sheet names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>, object>))]
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>, object>? PageRange { get; set; }

        /// <summary>
        /// Password to decrypt password-protected documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_password")]
        public string? DocumentPassword { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="ocrSystem">
        /// Standard is our best multilingual OCR system. Legacy only supports germanic languages and is available for backwards compatibility.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="extractionMode">
        /// The mode to use for text extraction from PDFs. OCR mode uses optical character recognition only. Hybrid mode combines OCR with embedded PDF text for best accuracy (default).<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="forceUrlResult">
        /// Force the result to be returned in URL form.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="forceFileExtension">
        /// Force the URL to be downloaded as a specific file extension (e.g. `.png`).
        /// </param>
        /// <param name="returnOcrData">
        /// If True, return OCR data in the result. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnImages">
        /// Whether to return images for the specified block types. 'page' returns full page images. By default, no images are returned.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="embedPdfMetadata">
        /// If True, embed OCR metadata into the returned PDF. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="persistResults">
        /// If True, persist the results indefinitely. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// The timeout for the job in seconds.
        /// </param>
        /// <param name="pageRange">
        /// The page range to process (1-indexed). By default, the entire document is processed. For spreadsheets, you can also provide a list of sheet names.
        /// </param>
        /// <param name="documentPassword">
        /// Password to decrypt password-protected documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Settings(
            global::Reducto.SettingsOcrSystem? ocrSystem,
            global::Reducto.SettingsExtractionMode? extractionMode,
            bool? forceUrlResult,
            string? forceFileExtension,
            bool? returnOcrData,
            global::System.Collections.Generic.IList<global::Reducto.SettingsReturnImage>? returnImages,
            bool? embedPdfMetadata,
            bool? persistResults,
            double? timeout,
            global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>, object>? pageRange,
            string? documentPassword)
        {
            this.OcrSystem = ocrSystem;
            this.ExtractionMode = extractionMode;
            this.ForceUrlResult = forceUrlResult;
            this.ForceFileExtension = forceFileExtension;
            this.ReturnOcrData = returnOcrData;
            this.ReturnImages = returnImages;
            this.EmbedPdfMetadata = embedPdfMetadata;
            this.PersistResults = persistResults;
            this.Timeout = timeout;
            this.PageRange = pageRange;
            this.DocumentPassword = documentPassword;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
        }
    }
}