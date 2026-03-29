
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepSplitPartition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.DeepSplitPageEvidence> Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplitPartition" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepSplitPartition(
            string name,
            global::System.Collections.Generic.IList<global::Reducto.DeepSplitPageEvidence> pages)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplitPartition" /> class.
        /// </summary>
        public DeepSplitPartition()
        {
        }
    }
}