
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Custom instructions for agentic text. Note: This only applies to form regions (key-value).
    /// </summary>
    public sealed partial class TextAgenticPrompt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}