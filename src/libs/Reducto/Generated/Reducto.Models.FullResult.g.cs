
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FullResult
    {
        /// <summary>
        /// type = 'full'
        /// </summary>
        /// <default>"full"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "full";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.ParseChunk> Chunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr")]
        public global::Reducto.OCRResult? Ocr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public object? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FullResult" /> class.
        /// </summary>
        /// <param name="chunks"></param>
        /// <param name="ocr"></param>
        /// <param name="custom"></param>
        /// <param name="type">
        /// type = 'full'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FullResult(
            global::System.Collections.Generic.IList<global::Reducto.ParseChunk> chunks,
            global::Reducto.OCRResult? ocr,
            object? custom,
            string type = "full")
        {
            this.Type = type;
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.Ocr = ocr;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullResult" /> class.
        /// </summary>
        public FullResult()
        {
        }
    }
}