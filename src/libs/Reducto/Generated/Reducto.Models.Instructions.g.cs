
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Instructions
    {
        /// <summary>
        /// The JSON schema to use for the extraction.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// The system prompt to use for the extraction.<br/>
        /// Default Value: Be precise and thorough.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Instructions" /> class.
        /// </summary>
        /// <param name="schema">
        /// The JSON schema to use for the extraction.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for the extraction.<br/>
        /// Default Value: Be precise and thorough.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Instructions(
            object? schema,
            string? systemPrompt)
        {
            this.Schema = schema;
            this.SystemPrompt = systemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Instructions" /> class.
        /// </summary>
        public Instructions()
        {
        }
    }
}