
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextAgentic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string Scope { get; set; } = "text";

        /// <summary>
        /// Custom instructions for agentic text. Note: This only applies to form regions (key-value).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAgentic" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Custom instructions for agentic text. Note: This only applies to form regions (key-value).
        /// </param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextAgentic(
            string? prompt,
            string scope = "text")
        {
            this.Scope = scope;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAgentic" /> class.
        /// </summary>
        public TextAgentic()
        {
        }
    }
}