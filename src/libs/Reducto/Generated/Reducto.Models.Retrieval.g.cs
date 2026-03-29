
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Retrieval
    {
        /// <summary>
        /// Default Value: {"chunk_mode":"disabled","chunk_overlap":0}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking")]
        public global::Reducto.Chunking? Chunking { get; set; }

        /// <summary>
        /// A list of block types to filter out from 'content' and 'embed' fields. By default, no blocks are filtered.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_blocks")]
        public global::System.Collections.Generic.IList<global::Reducto.RetrievalFilterBlock>? FilterBlocks { get; set; }

        /// <summary>
        /// If True, use embedding optimized mode. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_optimized")]
        public bool? EmbeddingOptimized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Retrieval" /> class.
        /// </summary>
        /// <param name="chunking">
        /// Default Value: {"chunk_mode":"disabled","chunk_overlap":0}
        /// </param>
        /// <param name="filterBlocks">
        /// A list of block types to filter out from 'content' and 'embed' fields. By default, no blocks are filtered.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="embeddingOptimized">
        /// If True, use embedding optimized mode. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Retrieval(
            global::Reducto.Chunking? chunking,
            global::System.Collections.Generic.IList<global::Reducto.RetrievalFilterBlock>? filterBlocks,
            bool? embeddingOptimized)
        {
            this.Chunking = chunking;
            this.FilterBlocks = filterBlocks;
            this.EmbeddingOptimized = embeddingOptimized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Retrieval" /> class.
        /// </summary>
        public Retrieval()
        {
        }
    }
}