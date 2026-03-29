
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParseChunk
    {
        /// <summary>
        /// The content of the chunk extracted from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Chunk content optimized for embedding and retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Embed { get; set; }

        /// <summary>
        /// The enriched content of the chunk extracted from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enriched")]
        public string? Enriched { get; set; }

        /// <summary>
        /// Whether the enrichment was successful.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichment_success")]
        public bool? EnrichmentSuccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.ParseBlock> Blocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseChunk" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the chunk extracted from the document.
        /// </param>
        /// <param name="embed">
        /// Chunk content optimized for embedding and retrieval.
        /// </param>
        /// <param name="blocks"></param>
        /// <param name="enriched">
        /// The enriched content of the chunk extracted from the document.
        /// </param>
        /// <param name="enrichmentSuccess">
        /// Whether the enrichment was successful.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseChunk(
            string content,
            string embed,
            global::System.Collections.Generic.IList<global::Reducto.ParseBlock> blocks,
            string? enriched,
            bool? enrichmentSuccess)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Embed = embed ?? throw new global::System.ArgumentNullException(nameof(embed));
            this.Enriched = enriched;
            this.EnrichmentSuccess = enrichmentSuccess;
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseChunk" /> class.
        /// </summary>
        public ParseChunk()
        {
        }
    }
}