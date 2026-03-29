
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitAlpha
    {
        /// <summary>
        /// If True, uses the deep split agent for higher-quality document splitting. Off by default.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_split")]
        public bool? DeepSplit { get; set; }

        /// <summary>
        /// If True, include confidence scores (high, medium, low) in deep split results. Requires deep_split to be enabled. Off by default.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_confidence")]
        public bool? IncludeConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAlpha" /> class.
        /// </summary>
        /// <param name="deepSplit">
        /// If True, uses the deep split agent for higher-quality document splitting. Off by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeConfidence">
        /// If True, include confidence scores (high, medium, low) in deep split results. Requires deep_split to be enabled. Off by default.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitAlpha(
            bool? deepSplit,
            bool? includeConfidence)
        {
            this.DeepSplit = deepSplit;
            this.IncludeConfidence = includeConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAlpha" /> class.
        /// </summary>
        public SplitAlpha()
        {
        }
    }
}