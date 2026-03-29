
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FigureSummaryConfig
    {
        /// <summary>
        /// If figure summarization should be performed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Add information to the prompt for figure summarization. Note any visual cues that should be incorporated. Example: 'When provided a diagram, extract all of the figure content verbatim.'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// If the figure summary prompt should override our default prompt.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override")]
        public bool? Override { get; set; }

        /// <summary>
        /// If True, use the advanced chart agent. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_chart_agent")]
        public bool? AdvancedChartAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureSummaryConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If figure summarization should be performed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// Add information to the prompt for figure summarization. Note any visual cues that should be incorporated. Example: 'When provided a diagram, extract all of the figure content verbatim.'
        /// </param>
        /// <param name="override">
        /// If the figure summary prompt should override our default prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="advancedChartAgent">
        /// If True, use the advanced chart agent. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FigureSummaryConfig(
            bool? enabled,
            string? prompt,
            bool? @override,
            bool? advancedChartAgent)
        {
            this.Enabled = enabled;
            this.Prompt = prompt;
            this.Override = @override;
            this.AdvancedChartAgent = advancedChartAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureSummaryConfig" /> class.
        /// </summary>
        public FigureSummaryConfig()
        {
        }
    }
}