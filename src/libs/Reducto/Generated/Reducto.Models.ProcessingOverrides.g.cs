
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessingOverrides
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_tables")]
        public global::Reducto.AgenticTablesOverrides? AgenticTables { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_queue")]
        public global::Reducto.CustomerQueueOverrides? CustomerQueue { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_citations")]
        public global::Reducto.ExtractCitationsOverrides? ExtractCitations { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_value")]
        public global::Reducto.KeyValueOverrides? KeyValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingOverrides" /> class.
        /// </summary>
        /// <param name="agenticTables">
        /// Default Value: {}
        /// </param>
        /// <param name="customerQueue">
        /// Default Value: {}
        /// </param>
        /// <param name="extractCitations">
        /// Default Value: {}
        /// </param>
        /// <param name="keyValue">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingOverrides(
            global::Reducto.AgenticTablesOverrides? agenticTables,
            global::Reducto.CustomerQueueOverrides? customerQueue,
            global::Reducto.ExtractCitationsOverrides? extractCitations,
            global::Reducto.KeyValueOverrides? keyValue)
        {
            this.AgenticTables = agenticTables;
            this.CustomerQueue = customerQueue;
            this.ExtractCitations = extractCitations;
            this.KeyValue = keyValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingOverrides" /> class.
        /// </summary>
        public ProcessingOverrides()
        {
        }
    }
}