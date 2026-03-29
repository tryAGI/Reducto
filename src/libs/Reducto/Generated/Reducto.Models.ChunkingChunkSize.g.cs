
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The approximate size of chunks (in characters) that the document will be split into. Defaults to null, in which case the chunk size is variable between 250 - 1500 characters.
    /// </summary>
    public sealed partial class ChunkingChunkSize
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}