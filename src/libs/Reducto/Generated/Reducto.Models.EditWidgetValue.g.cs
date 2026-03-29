
#nullable enable

namespace Reducto
{
    /// <summary>
    /// If provided, this value will be used directly instead of attempting to intelligently determine the field value.
    /// </summary>
    public sealed partial class EditWidgetValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}