
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Overall confidence breakdown for classification response.
    /// </summary>
    public sealed partial class ResponseConfidence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.CategoryConfidence> Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfidence" /> class.
        /// </summary>
        /// <param name="categories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseConfidence(
            global::System.Collections.Generic.IList<global::Reducto.CategoryConfidence> categories)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfidence" /> class.
        /// </summary>
        public ResponseConfidence()
        {
        }
    }
}