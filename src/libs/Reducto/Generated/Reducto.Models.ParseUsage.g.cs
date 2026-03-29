
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParseUsage
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
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_breakdown")]
        public global::System.Collections.Generic.Dictionary<string, double>? CreditBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseUsage" /> class.
        /// </summary>
        /// <param name="numPages"></param>
        /// <param name="credits"></param>
        /// <param name="creditBreakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseUsage(
            int numPages,
            double? credits,
            global::System.Collections.Generic.Dictionary<string, double>? creditBreakdown)
        {
            this.NumPages = numPages;
            this.Credits = credits;
            this.CreditBreakdown = creditBreakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseUsage" /> class.
        /// </summary>
        public ParseUsage()
        {
        }
    }
}