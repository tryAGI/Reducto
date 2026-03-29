
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Extra metadata fields for the block. Fields like 'is_chart' will only appear when set to True.
    /// </summary>
    public sealed partial class ParseBlockExtra
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}