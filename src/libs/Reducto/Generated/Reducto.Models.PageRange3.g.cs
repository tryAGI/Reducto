
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PageRange3
    {
        /// <summary>
        /// The page number to start processing from (1-indexed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public int? Start { get; set; }

        /// <summary>
        /// The page number to stop processing at (1-indexed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public int? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageRange3" /> class.
        /// </summary>
        /// <param name="start">
        /// The page number to start processing from (1-indexed).
        /// </param>
        /// <param name="end">
        /// The page number to stop processing at (1-indexed).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageRange3(
            int? start,
            int? end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageRange3" /> class.
        /// </summary>
        public PageRange3()
        {
        }
    }
}