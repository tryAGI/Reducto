
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GranularConfidence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_confidence")]
        public double? ExtractConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_confidence")]
        public double? ParseConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularConfidence" /> class.
        /// </summary>
        /// <param name="extractConfidence"></param>
        /// <param name="parseConfidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GranularConfidence(
            double? extractConfidence,
            double? parseConfidence)
        {
            this.ExtractConfidence = extractConfidence;
            this.ParseConfidence = parseConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularConfidence" /> class.
        /// </summary>
        public GranularConfidence()
        {
        }
    }
}