
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitLargeTables
    {
        /// <summary>
        /// If True, split large tables into smaller tables. Defaults to True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The size of the tables to split into. Defaults to 50. Use 'row' and 'column' to independently specify the number of rows and columns to include when splitting. If you only want to split by rows or columns, set the other value to None.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<int?, global::Reducto.SplitLargeTableSizes>))]
        public global::Reducto.AnyOf<int?, global::Reducto.SplitLargeTableSizes>? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitLargeTables" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If True, split large tables into smaller tables. Defaults to True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="size">
        /// The size of the tables to split into. Defaults to 50. Use 'row' and 'column' to independently specify the number of rows and columns to include when splitting. If you only want to split by rows or columns, set the other value to None.<br/>
        /// Default Value: 50
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitLargeTables(
            bool? enabled,
            global::Reducto.AnyOf<int?, global::Reducto.SplitLargeTableSizes>? size)
        {
            this.Enabled = enabled;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitLargeTables" /> class.
        /// </summary>
        public SplitLargeTables()
        {
        }
    }
}