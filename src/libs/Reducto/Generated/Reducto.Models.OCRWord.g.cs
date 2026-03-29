
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRWord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.BoundingBox Bbox { get; set; }

        /// <summary>
        /// OCR confidence score between 0 and 1, where 1 indicates highest confidence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The index of the chunk that the word belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        public int? ChunkIndex { get; set; }

        /// <summary>
        /// The rotation angle in degrees, from 0 to 360, counterclockwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation")]
        public int? Rotation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRWord" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="bbox"></param>
        /// <param name="confidence">
        /// OCR confidence score between 0 and 1, where 1 indicates highest confidence
        /// </param>
        /// <param name="chunkIndex">
        /// The index of the chunk that the word belongs to.
        /// </param>
        /// <param name="rotation">
        /// The rotation angle in degrees, from 0 to 360, counterclockwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRWord(
            string text,
            global::Reducto.BoundingBox bbox,
            double? confidence,
            int? chunkIndex,
            int? rotation)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Confidence = confidence;
            this.ChunkIndex = chunkIndex;
            this.Rotation = rotation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRWord" /> class.
        /// </summary>
        public OCRWord()
        {
        }
    }
}