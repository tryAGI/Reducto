
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParseAlpha
    {
        /// <summary>
        /// Default Value: {"agentic_tables":{},"customer_queue":{},"extract_citations":{},"key_value":{}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::Reducto.ProcessingOverrides? Overrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseAlpha" /> class.
        /// </summary>
        /// <param name="overrides">
        /// Default Value: {"agentic_tables":{},"customer_queue":{},"extract_citations":{},"key_value":{}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseAlpha(
            global::Reducto.ProcessingOverrides? overrides)
        {
            this.Overrides = overrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseAlpha" /> class.
        /// </summary>
        public ParseAlpha()
        {
        }
    }
}