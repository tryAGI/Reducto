
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Form schema for PDF forms. List of widgets with their types, descriptions, and bounding boxes. Only works for PDFs.
    /// </summary>
    public sealed partial class AsyncEditConfigFormSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}