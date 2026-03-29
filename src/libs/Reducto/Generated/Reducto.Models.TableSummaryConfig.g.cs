
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSummaryConfig
    {
        /// <summary>
        /// If table summarization should be performed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Add information to the prompt for table summarization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSummaryConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If table summarization should be performed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// Add information to the prompt for table summarization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSummaryConfig(
            bool? enabled,
            string? prompt)
        {
            this.Enabled = enabled;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSummaryConfig" /> class.
        /// </summary>
        public TableSummaryConfig()
        {
        }
    }
}