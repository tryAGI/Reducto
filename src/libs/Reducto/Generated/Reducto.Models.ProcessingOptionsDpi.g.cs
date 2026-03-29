
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Optional PDF page render DPI. Values greater than 0 render page images at this DPI before layout, OCR, and figure cropping. Set to 0 to disable the override. Higher values increase resolution and latency.
    /// </summary>
    public sealed partial class ProcessingOptionsDpi
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}