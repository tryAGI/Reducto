
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Granular confidence scores for the block. It is a dictionary of confidence scores for the block. The confidence scores will not be None if the user has enabled numeric confidence scores.
    /// </summary>
    public sealed partial class ParseBlockGranularConfidence
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}