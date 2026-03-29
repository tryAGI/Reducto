
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditConfig
    {
        /// <summary>
        /// The URL of the document to be processed. You can provide one of the following:<br/>
        /// 1. A publicly available URL<br/>
        /// 2. A presigned S3 URL<br/>
        /// 3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<string, global::Reducto.UploadResponse> DocumentUrl { get; set; }

        /// <summary>
        /// The instructions for the edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EditInstructions { get; set; }

        /// <summary>
        /// Default Value: {"color":"#FF0000","enable_overflow_pages":false,"flatten":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_options")]
        public global::Reducto.EditOptions? EditOptions { get; set; }

        /// <summary>
        /// Form schema for PDF forms. List of widgets with their types, descriptions, and bounding boxes. Only works for PDFs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("form_schema")]
        public global::System.Collections.Generic.IList<global::Reducto.EditWidget>? FormSchema { get; set; }

        /// <summary>
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public bool? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditConfig" /> class.
        /// </summary>
        /// <param name="documentUrl">
        /// The URL of the document to be processed. You can provide one of the following:<br/>
        /// 1. A publicly available URL<br/>
        /// 2. A presigned S3 URL<br/>
        /// 3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document
        /// </param>
        /// <param name="editInstructions">
        /// The instructions for the edit.
        /// </param>
        /// <param name="editOptions">
        /// Default Value: {"color":"#FF0000","enable_overflow_pages":false,"flatten":false}
        /// </param>
        /// <param name="formSchema">
        /// Form schema for PDF forms. List of widgets with their types, descriptions, and bounding boxes. Only works for PDFs.
        /// </param>
        /// <param name="priority">
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditConfig(
            global::Reducto.AnyOf<string, global::Reducto.UploadResponse> documentUrl,
            string editInstructions,
            global::Reducto.EditOptions? editOptions,
            global::System.Collections.Generic.IList<global::Reducto.EditWidget>? formSchema,
            bool? priority)
        {
            this.DocumentUrl = documentUrl;
            this.EditInstructions = editInstructions ?? throw new global::System.ArgumentNullException(nameof(editInstructions));
            this.EditOptions = editOptions;
            this.FormSchema = formSchema;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditConfig" /> class.
        /// </summary>
        public EditConfig()
        {
        }
    }
}