
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The number of rows to include in each chunk when splitting large tables. Does not chunk rows if set to None.
    /// </summary>
    public sealed partial class SplitLargeTableSizesRow
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}