
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The JSON schema to use for the extraction.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class InstructionsSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}