
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Font size in points for this specific field. Takes priority over the global font_size in EditOptions. If not set, falls back to the global font_size, then to auto-calculated sizing.
    /// </summary>
    public sealed partial class EditWidgetFontSize
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}