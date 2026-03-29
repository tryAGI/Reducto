
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepSplitPageEvidence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Evidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public global::Reducto.DeepSplitPageEvidenceConfidence2? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplitPageEvidence" /> class.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="evidence"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepSplitPageEvidence(
            int pageNumber,
            string evidence,
            global::Reducto.DeepSplitPageEvidenceConfidence2? confidence)
        {
            this.PageNumber = pageNumber;
            this.Evidence = evidence ?? throw new global::System.ArgumentNullException(nameof(evidence));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplitPageEvidence" /> class.
        /// </summary>
        public DeepSplitPageEvidence()
        {
        }
    }
}