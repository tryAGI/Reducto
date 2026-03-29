
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Base class for the dynamically generated ProcessingOverrides model.<br/>
    /// This provides proper typing for the dynamically created model:<br/>
    /// - Can be used as a type annotation (it's a real class, not a variable)<br/>
    /// - Attribute access returns Any, suppressing type checker errors<br/>
    /// - Actual fields are added dynamically by build_processing_overrides()<br/>
    /// The dynamic subclass will have typed fields like:<br/>
    ///     key_value: KeyValueOverrides<br/>
    ///     summarize_all_figures: FigureSummaryOverrides<br/>
    ///     ...
    /// </summary>
    public sealed partial class ProcessingOverridesBase
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}