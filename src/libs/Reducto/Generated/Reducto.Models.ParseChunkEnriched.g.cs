
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The enriched content of the chunk extracted from the document.
    /// </summary>
    public sealed partial class ParseChunkEnriched
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}