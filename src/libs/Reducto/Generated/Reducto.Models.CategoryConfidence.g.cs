
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Confidence result for a category.
    /// </summary>
    public sealed partial class CategoryConfidence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.CriteriaConfidence> CriteriaConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryConfidence" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="confidence"></param>
        /// <param name="criteriaConfidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoryConfidence(
            string category,
            double confidence,
            global::System.Collections.Generic.IList<global::Reducto.CriteriaConfidence> criteriaConfidence)
        {
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Confidence = confidence;
            this.CriteriaConfidence = criteriaConfidence ?? throw new global::System.ArgumentNullException(nameof(criteriaConfidence));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryConfidence" /> class.
        /// </summary>
        public CategoryConfidence()
        {
        }
    }
}