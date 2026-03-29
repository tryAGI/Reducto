
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_mode")]
        public global::Reducto.ExtractUsageExtractMode2? ExtractMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractUsage" /> class.
        /// </summary>
        /// <param name="numPages"></param>
        /// <param name="numFields"></param>
        /// <param name="credits"></param>
        /// <param name="extractMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractUsage(
            int numPages,
            int numFields,
            double? credits,
            global::Reducto.ExtractUsageExtractMode2? extractMode)
        {
            this.NumPages = numPages;
            this.NumFields = numFields;
            this.Credits = credits;
            this.ExtractMode = extractMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractUsage" /> class.
        /// </summary>
        public ExtractUsage()
        {
        }
    }
}