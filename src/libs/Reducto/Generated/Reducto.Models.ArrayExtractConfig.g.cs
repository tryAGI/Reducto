
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArrayExtractConfig
    {
        /// <summary>
        /// Array extraction allows you to extract long lists of information from lengthy documents. It makes parallel calls on overlapping sections of the document.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The array extraction version to use.<br/>
        /// Default Value: legacy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ArrayExtractConfigModeJsonConverter))]
        public global::Reducto.ArrayExtractConfigMode? Mode { get; set; }

        /// <summary>
        /// Length of each segment, in pages, for parallel calls with array extraction.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_per_segment")]
        public int? PagesPerSegment { get; set; }

        /// <summary>
        /// Number of items to extract in each stream call. Lower numbers will increase quality but be much slower. 50 works well for most documents with tables.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_extract_item_density")]
        public int? StreamingExtractItemDensity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayExtractConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Array extraction allows you to extract long lists of information from lengthy documents. It makes parallel calls on overlapping sections of the document.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mode">
        /// The array extraction version to use.<br/>
        /// Default Value: legacy
        /// </param>
        /// <param name="pagesPerSegment">
        /// Length of each segment, in pages, for parallel calls with array extraction.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="streamingExtractItemDensity">
        /// Number of items to extract in each stream call. Lower numbers will increase quality but be much slower. 50 works well for most documents with tables.<br/>
        /// Default Value: 50
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArrayExtractConfig(
            bool? enabled,
            global::Reducto.ArrayExtractConfigMode? mode,
            int? pagesPerSegment,
            int? streamingExtractItemDensity)
        {
            this.Enabled = enabled;
            this.Mode = mode;
            this.PagesPerSegment = pagesPerSegment;
            this.StreamingExtractItemDensity = streamingExtractItemDensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayExtractConfig" /> class.
        /// </summary>
        public ArrayExtractConfig()
        {
        }
    }
}