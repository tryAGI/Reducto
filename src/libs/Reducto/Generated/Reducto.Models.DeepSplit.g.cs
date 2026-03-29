
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepSplit
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitions")]
        public global::System.Collections.Generic.IList<global::Reducto.DeepSplitPartition>? Partitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplit" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pages"></param>
        /// <param name="partitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepSplit(
            string name,
            global::System.Collections.Generic.IList<global::Reducto.DeepSplitPageEvidence> pages,
            global::System.Collections.Generic.IList<global::Reducto.DeepSplitPartition>? partitions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Partitions = partitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplit" /> class.
        /// </summary>
        public DeepSplit()
        {
        }
    }
}