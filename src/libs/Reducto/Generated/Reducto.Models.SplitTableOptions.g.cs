
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitTableOptions
    {
        /// <summary>
        /// If tables should be truncated to the first few rows or if all content should be preserved. truncate improves latency, preserve is recommended for cases where partition_key is being used and the partition_key may be included within the table. Defaults to truncate<br/>
        /// Default Value: truncate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_cutoff")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SplitTableOptionsTableCutoffJsonConverter))]
        public global::Reducto.SplitTableOptionsTableCutoff? TableCutoff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTableOptions" /> class.
        /// </summary>
        /// <param name="tableCutoff">
        /// If tables should be truncated to the first few rows or if all content should be preserved. truncate improves latency, preserve is recommended for cases where partition_key is being used and the partition_key may be included within the table. Defaults to truncate<br/>
        /// Default Value: truncate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitTableOptions(
            global::Reducto.SplitTableOptionsTableCutoff? tableCutoff)
        {
            this.TableCutoff = tableCutoff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTableOptions" /> class.
        /// </summary>
        public SplitTableOptions()
        {
        }
    }
}