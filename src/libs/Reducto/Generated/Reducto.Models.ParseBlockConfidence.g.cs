
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The confidence for the block. It is either low or high and takes into account factors like OCR and table structure<br/>
    /// Default Value: low
    /// </summary>
    public sealed partial class ParseBlockConfidence
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}