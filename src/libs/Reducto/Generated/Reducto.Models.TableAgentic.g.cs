
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableAgentic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"table"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string Scope { get; set; } = "table";

        /// <summary>
        /// Custom prompt for table agentic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAgentic" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Custom prompt for table agentic.
        /// </param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableAgentic(
            string? prompt,
            string scope = "table")
        {
            this.Scope = scope;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAgentic" /> class.
        /// </summary>
        public TableAgentic()
        {
        }
    }
}