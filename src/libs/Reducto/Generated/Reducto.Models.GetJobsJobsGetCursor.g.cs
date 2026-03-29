
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Cursor for pagination. Use the next_cursor from the previous response to fetch the next page.
    /// </summary>
    public sealed partial class GetJobsJobsGetCursor
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}