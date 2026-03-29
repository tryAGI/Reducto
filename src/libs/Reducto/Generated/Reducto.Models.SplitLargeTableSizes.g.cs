
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitLargeTableSizes
    {
        /// <summary>
        /// The number of rows to include in each chunk when splitting large tables. Does not chunk rows if set to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        public int? Row { get; set; }

        /// <summary>
        /// The number of columns to include in each chunk when splitting large tables. Does not chunk columns if set to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        public int? Column { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitLargeTableSizes" /> class.
        /// </summary>
        /// <param name="row">
        /// The number of rows to include in each chunk when splitting large tables. Does not chunk rows if set to None.
        /// </param>
        /// <param name="column">
        /// The number of columns to include in each chunk when splitting large tables. Does not chunk columns if set to None.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitLargeTableSizes(
            int? row,
            int? column)
        {
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitLargeTableSizes" /> class.
        /// </summary>
        public SplitLargeTableSizes()
        {
        }
    }
}