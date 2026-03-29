
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Settings for pipeline execution that override pipeline defaults.
    /// </summary>
    public sealed partial class PipelineSettings
    {
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
        /// Initializes a new instance of the <see cref="PipelineSettings" /> class.
        /// </summary>
        /// <param name="documentPassword">
        /// Password to decrypt password-protected documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineSettings(
            string? documentPassword)
        {
            this.DocumentPassword = documentPassword;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineSettings" /> class.
        /// </summary>
        public PipelineSettings()
        {
        }
    }
}