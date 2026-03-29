
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyConfig
    {
        /// <summary>
        /// If True, persist the results indefinitely. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist_results")]
        public bool? PersistResults { get; set; }

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
        /// A list of classification categories and their matching criteria.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_schema")]
        public global::System.Collections.Generic.IList<global::Reducto.ClassificationCategory>? ClassificationSchema { get; set; }

        /// <summary>
        /// The page range to process (1-indexed). By default, the first 5 pages are used. If more than 25 pages are selected, only the first 25 (after sorting) are used. Only applies to PDFs; ignored for other document types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, object>))]
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, object>? PageRange { get; set; }

        /// <summary>
        /// Optional document-level metadata to include in classification prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_metadata")]
        public string? DocumentMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyConfig" /> class.
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
        /// <param name="persistResults">
        /// If True, persist the results indefinitely. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="classificationSchema">
        /// A list of classification categories and their matching criteria.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="pageRange">
        /// The page range to process (1-indexed). By default, the first 5 pages are used. If more than 25 pages are selected, only the first 25 (after sorting) are used. Only applies to PDFs; ignored for other document types.
        /// </param>
        /// <param name="documentMetadata">
        /// Optional document-level metadata to include in classification prompts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyConfig(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> input,
            bool? persistResults,
            global::System.Collections.Generic.IList<global::Reducto.ClassificationCategory>? classificationSchema,
            global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, object>? pageRange,
            string? documentMetadata)
        {
            this.PersistResults = persistResults;
            this.Input = input;
            this.ClassificationSchema = classificationSchema;
            this.PageRange = pageRange;
            this.DocumentMetadata = documentMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyConfig" /> class.
        /// </summary>
        public ClassifyConfig()
        {
        }
    }
}