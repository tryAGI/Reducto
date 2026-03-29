
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractSettings
    {
        /// <summary>
        /// If True, include images in the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// If True, jobs will be processed with a higher throughput and priority at a higher cost. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimize_for_latency")]
        public bool? OptimizeForLatency { get; set; }

        /// <summary>
        /// If True, use array extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array_extract")]
        public bool? ArrayExtract { get; set; }

        /// <summary>
        /// If True, use Deep Extract, an agentic extraction mode that iteratively refines its output to achieve near-perfect accuracy. Best for complex documents where accuracy is critical.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_extract")]
        public bool? DeepExtract { get; set; }

        /// <summary>
        /// The citations to use for the extraction.<br/>
        /// Default Value: {"enabled":false,"numerical_confidence":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::Reducto.Citations? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSettings" /> class.
        /// </summary>
        /// <param name="includeImages">
        /// If True, include images in the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="optimizeForLatency">
        /// If True, jobs will be processed with a higher throughput and priority at a higher cost. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="arrayExtract">
        /// If True, use array extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="deepExtract">
        /// If True, use Deep Extract, an agentic extraction mode that iteratively refines its output to achieve near-perfect accuracy. Best for complex documents where accuracy is critical.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="citations">
        /// The citations to use for the extraction.<br/>
        /// Default Value: {"enabled":false,"numerical_confidence":true}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractSettings(
            bool? includeImages,
            bool? optimizeForLatency,
            bool? arrayExtract,
            bool? deepExtract,
            global::Reducto.Citations? citations)
        {
            this.IncludeImages = includeImages;
            this.OptimizeForLatency = optimizeForLatency;
            this.ArrayExtract = arrayExtract;
            this.DeepExtract = deepExtract;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSettings" /> class.
        /// </summary>
        public ExtractSettings()
        {
        }
    }
}