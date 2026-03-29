
#nullable enable

namespace Reducto
{
    /// <summary>
    /// A single classification category with its matching criteria.
    /// </summary>
    public sealed partial class ClassificationCategory
    {
        /// <summary>
        /// The category name/label that documents will be classified into (e.g., 'invoice', 'contract', 'receipt').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// A list of criteria, keywords, or descriptions that define what characteristics a document must have to be classified into this category (e.g., ['contains billing information', 'has itemized charges']).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationCategory" /> class.
        /// </summary>
        /// <param name="category">
        /// The category name/label that documents will be classified into (e.g., 'invoice', 'contract', 'receipt').
        /// </param>
        /// <param name="criteria">
        /// A list of criteria, keywords, or descriptions that define what characteristics a document must have to be classified into this category (e.g., ['contains billing information', 'has itemized charges']).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationCategory(
            string category,
            global::System.Collections.Generic.IList<string> criteria)
        {
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationCategory" /> class.
        /// </summary>
        public ClassificationCategory()
        {
        }
    }
}