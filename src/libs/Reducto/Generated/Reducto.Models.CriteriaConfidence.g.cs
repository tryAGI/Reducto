
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Confidence result for a single criterion.
    /// </summary>
    public sealed partial class CriteriaConfidence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Criterion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.CriteriaConfidenceConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.CriteriaConfidenceConfidence Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CriteriaConfidence" /> class.
        /// </summary>
        /// <param name="criterion"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CriteriaConfidence(
            string criterion,
            global::Reducto.CriteriaConfidenceConfidence confidence)
        {
            this.Criterion = criterion ?? throw new global::System.ArgumentNullException(nameof(criterion));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriteriaConfidence" /> class.
        /// </summary>
        public CriteriaConfidence()
        {
        }
    }
}