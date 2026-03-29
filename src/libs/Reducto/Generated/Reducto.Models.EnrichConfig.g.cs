
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnrichConfig
    {
        /// <summary>
        /// If enabled, a large language/vision model will be used to postprocess the extracted content. Note: enabling enrich requires tables be outputted in markdown format. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The mode to use for enrichment. Defaults to standard<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.EnrichConfigModeJsonConverter))]
        public global::Reducto.EnrichConfigMode? Mode { get; set; }

        /// <summary>
        /// Add information to the prompt for enrichment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If enabled, a large language/vision model will be used to postprocess the extracted content. Note: enabling enrich requires tables be outputted in markdown format. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mode">
        /// The mode to use for enrichment. Defaults to standard<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="prompt">
        /// Add information to the prompt for enrichment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnrichConfig(
            bool? enabled,
            global::Reducto.EnrichConfigMode? mode,
            string? prompt)
        {
            this.Enabled = enabled;
            this.Mode = mode;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichConfig" /> class.
        /// </summary>
        public EnrichConfig()
        {
        }
    }
}