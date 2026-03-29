
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LargeTableChunkingConfig
    {
        /// <summary>
        /// If large tables should be chunked into smaller tables, currently only supported on spreadsheet and CSV files.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The max row/column size for a table to be chunked. Defaults to 50. Header rows/columns are persisted based on heuristics.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LargeTableChunkingConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If large tables should be chunked into smaller tables, currently only supported on spreadsheet and CSV files.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="size">
        /// The max row/column size for a table to be chunked. Defaults to 50. Header rows/columns are persisted based on heuristics.<br/>
        /// Default Value: 50
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LargeTableChunkingConfig(
            bool? enabled,
            int? size)
        {
            this.Enabled = enabled;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LargeTableChunkingConfig" /> class.
        /// </summary>
        public LargeTableChunkingConfig()
        {
        }
    }
}