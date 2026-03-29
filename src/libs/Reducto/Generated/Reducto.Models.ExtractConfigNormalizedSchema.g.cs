
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The normalized JSON schema to use for extraction.
    /// </summary>
    public sealed partial class ExtractConfigNormalizedSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}