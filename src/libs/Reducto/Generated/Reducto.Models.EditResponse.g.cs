
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditResponse
    {
        /// <summary>
        /// Presigned URL to download the edited document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentUrl { get; set; }

        /// <summary>
        /// Form schema for PDF forms. List of widgets with their types, descriptions, and bounding boxes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("form_schema")]
        public global::System.Collections.Generic.IList<global::Reducto.EditWidget>? FormSchema { get; set; }

        /// <summary>
        /// Usage information for the edit operation, including number of pages and credits charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Reducto.ParseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditResponse" /> class.
        /// </summary>
        /// <param name="documentUrl">
        /// Presigned URL to download the edited document.
        /// </param>
        /// <param name="formSchema">
        /// Form schema for PDF forms. List of widgets with their types, descriptions, and bounding boxes.
        /// </param>
        /// <param name="usage">
        /// Usage information for the edit operation, including number of pages and credits charged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditResponse(
            string documentUrl,
            global::System.Collections.Generic.IList<global::Reducto.EditWidget>? formSchema,
            global::Reducto.ParseUsage? usage)
        {
            this.DocumentUrl = documentUrl ?? throw new global::System.ArgumentNullException(nameof(documentUrl));
            this.FormSchema = formSchema;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditResponse" /> class.
        /// </summary>
        public EditResponse()
        {
        }
    }
}