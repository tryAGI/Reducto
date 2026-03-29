
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Spreadsheet loader backend. 'default' uses calamine (Rust), 'legacy' uses openpyxl. None defaults to calamine.
    /// </summary>
    public sealed partial class ProcessingOptionsSpreadsheetLoader
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}