
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkingConfig
    {
        /// <summary>
        /// Choose how to partition chunks. Variable mode chunks by character length and visual context. Section mode chunks by section headers. Page mode chunks according to pages. Page sections mode chunks first by page, then by sections within each page. Disabled returns one single chunk.<br/>
        /// Default Value: variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ChunkingConfigChunkModeJsonConverter))]
        public global::Reducto.ChunkingConfigChunkMode? ChunkMode { get; set; }

        /// <summary>
        /// The approximate size of chunks (in characters) that the document will be split into. Defaults to None, in which case the chunk size is variable between 250 - 1500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Number of characters of overlap to include from adjacent chunks. Defaults to 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_overlap")]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingConfig" /> class.
        /// </summary>
        /// <param name="chunkMode">
        /// Choose how to partition chunks. Variable mode chunks by character length and visual context. Section mode chunks by section headers. Page mode chunks according to pages. Page sections mode chunks first by page, then by sections within each page. Disabled returns one single chunk.<br/>
        /// Default Value: variable
        /// </param>
        /// <param name="chunkSize">
        /// The approximate size of chunks (in characters) that the document will be split into. Defaults to None, in which case the chunk size is variable between 250 - 1500 characters.
        /// </param>
        /// <param name="chunkOverlap">
        /// Number of characters of overlap to include from adjacent chunks. Defaults to 0.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkingConfig(
            global::Reducto.ChunkingConfigChunkMode? chunkMode,
            int? chunkSize,
            int? chunkOverlap)
        {
            this.ChunkMode = chunkMode;
            this.ChunkSize = chunkSize;
            this.ChunkOverlap = chunkOverlap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingConfig" /> class.
        /// </summary>
        public ChunkingConfig()
        {
        }
    }
}