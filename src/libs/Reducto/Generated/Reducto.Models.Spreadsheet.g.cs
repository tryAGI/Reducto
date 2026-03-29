
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Spreadsheet
    {
        /// <summary>
        /// Default Value: {"enabled":true,"size":50}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_large_tables")]
        public global::Reducto.SplitLargeTables? SplitLargeTables { get; set; }

        /// <summary>
        /// Whether to include cell color, formula, and dropdown information in the output.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::Reducto.SpreadsheetIncludeItem>? Include { get; set; }

        /// <summary>
        /// In a spreadsheet with different tables inside, we enable splitting up the tables by default. Accurate mode applies more powerful models for superior accuracy, at 5× the default per-cell rate. Disabling will register as one large table.<br/>
        /// Default Value: accurate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clustering")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SpreadsheetClusteringJsonConverter))]
        public global::Reducto.SpreadsheetClustering? Clustering { get; set; }

        /// <summary>
        /// Whether to exclude hidden sheets, rows, or columns in the output.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<global::Reducto.SpreadsheetExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Spreadsheet" /> class.
        /// </summary>
        /// <param name="splitLargeTables">
        /// Default Value: {"enabled":true,"size":50}
        /// </param>
        /// <param name="include">
        /// Whether to include cell color, formula, and dropdown information in the output.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="clustering">
        /// In a spreadsheet with different tables inside, we enable splitting up the tables by default. Accurate mode applies more powerful models for superior accuracy, at 5× the default per-cell rate. Disabling will register as one large table.<br/>
        /// Default Value: accurate
        /// </param>
        /// <param name="exclude">
        /// Whether to exclude hidden sheets, rows, or columns in the output.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Spreadsheet(
            global::Reducto.SplitLargeTables? splitLargeTables,
            global::System.Collections.Generic.IList<global::Reducto.SpreadsheetIncludeItem>? include,
            global::Reducto.SpreadsheetClustering? clustering,
            global::System.Collections.Generic.IList<global::Reducto.SpreadsheetExcludeItem>? exclude)
        {
            this.SplitLargeTables = splitLargeTables;
            this.Include = include;
            this.Clustering = clustering;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spreadsheet" /> class.
        /// </summary>
        public Spreadsheet()
        {
        }
    }
}