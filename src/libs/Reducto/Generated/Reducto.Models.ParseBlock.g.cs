
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParseBlock
    {
        /// <summary>
        /// The type of block extracted from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ParseBlockTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.ParseBlockType Type { get; set; }

        /// <summary>
        /// The bounding box of the block extracted from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.BoundingBox Bbox { get; set; }

        /// <summary>
        /// The content of the block extracted from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// (Experimental) The URL of the image associated with the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// (Experimental) The URL/link to chart data JSON for figure blocks processed by chart agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_data")]
        public global::System.Collections.Generic.IList<string>? ChartData { get; set; }

        /// <summary>
        /// The confidence for the block. It is either low or high and takes into account factors like OCR and table structure<br/>
        /// Default Value: low
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public string? Confidence { get; set; }

        /// <summary>
        /// Granular confidence scores for the block. It is a dictionary of confidence scores for the block. The confidence scores will not be None if the user has enabled numeric confidence scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granular_confidence")]
        public global::Reducto.GranularConfidence? GranularConfidence { get; set; }

        /// <summary>
        /// Extra metadata fields for the block. Fields like 'is_chart' will only appear when set to True.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of block extracted from the document.
        /// </param>
        /// <param name="bbox">
        /// The bounding box of the block extracted from the document.
        /// </param>
        /// <param name="content">
        /// The content of the block extracted from the document.
        /// </param>
        /// <param name="imageUrl">
        /// (Experimental) The URL of the image associated with the block.
        /// </param>
        /// <param name="chartData">
        /// (Experimental) The URL/link to chart data JSON for figure blocks processed by chart agent.
        /// </param>
        /// <param name="confidence">
        /// The confidence for the block. It is either low or high and takes into account factors like OCR and table structure<br/>
        /// Default Value: low
        /// </param>
        /// <param name="granularConfidence">
        /// Granular confidence scores for the block. It is a dictionary of confidence scores for the block. The confidence scores will not be None if the user has enabled numeric confidence scores.
        /// </param>
        /// <param name="extra">
        /// Extra metadata fields for the block. Fields like 'is_chart' will only appear when set to True.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseBlock(
            global::Reducto.ParseBlockType type,
            global::Reducto.BoundingBox bbox,
            string content,
            string? imageUrl,
            global::System.Collections.Generic.IList<string>? chartData,
            string? confidence,
            global::Reducto.GranularConfidence? granularConfidence,
            object? extra)
        {
            this.Type = type;
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ImageUrl = imageUrl;
            this.ChartData = chartData;
            this.Confidence = confidence;
            this.GranularConfidence = granularConfidence;
            this.Extra = extra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseBlock" /> class.
        /// </summary>
        public ParseBlock()
        {
        }
    }
}