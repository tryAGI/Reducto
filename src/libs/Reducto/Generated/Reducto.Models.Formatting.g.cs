
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Formatting
    {
        /// <summary>
        /// If True, add page markers to the output. Defaults to False. Useful for extracting data with page specific information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_page_markers")]
        public bool? AddPageMarkers { get; set; }

        /// <summary>
        /// The mode to use for table output. Defaults to dynamic, which returns md for simpler tables and html for more complex tables.<br/>
        /// Default Value: dynamic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.FormattingTableOutputFormatJsonConverter))]
        public global::Reducto.FormattingTableOutputFormat? TableOutputFormat { get; set; }

        /// <summary>
        /// A flag to indicate if consecutive tables with the same number of columns should be merged. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_tables")]
        public bool? MergeTables { get; set; }

        /// <summary>
        /// A list of formatting to include in the output.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::Reducto.FormattingIncludeItem>? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Formatting" /> class.
        /// </summary>
        /// <param name="addPageMarkers">
        /// If True, add page markers to the output. Defaults to False. Useful for extracting data with page specific information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tableOutputFormat">
        /// The mode to use for table output. Defaults to dynamic, which returns md for simpler tables and html for more complex tables.<br/>
        /// Default Value: dynamic
        /// </param>
        /// <param name="mergeTables">
        /// A flag to indicate if consecutive tables with the same number of columns should be merged. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="include">
        /// A list of formatting to include in the output.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Formatting(
            bool? addPageMarkers,
            global::Reducto.FormattingTableOutputFormat? tableOutputFormat,
            bool? mergeTables,
            global::System.Collections.Generic.IList<global::Reducto.FormattingIncludeItem>? include)
        {
            this.AddPageMarkers = addPageMarkers;
            this.TableOutputFormat = tableOutputFormat;
            this.MergeTables = mergeTables;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Formatting" /> class.
        /// </summary>
        public Formatting()
        {
        }
    }
}