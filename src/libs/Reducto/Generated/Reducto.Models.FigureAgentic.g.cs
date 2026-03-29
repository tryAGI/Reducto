
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FigureAgentic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"figure"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string Scope { get; set; } = "figure";

        /// <summary>
        /// Custom prompt for figure agentic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// If True, use the advanced chart agent. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_chart_agent")]
        public bool? AdvancedChartAgent { get; set; }

        /// <summary>
        /// If True, return overlays for the figure. This is so you can use the overlays to double check the quality of the extraction<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_overlays")]
        public bool? ReturnOverlays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureAgentic" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Custom prompt for figure agentic.
        /// </param>
        /// <param name="advancedChartAgent">
        /// If True, use the advanced chart agent. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnOverlays">
        /// If True, return overlays for the figure. This is so you can use the overlays to double check the quality of the extraction<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FigureAgentic(
            string? prompt,
            bool? advancedChartAgent,
            bool? returnOverlays,
            string scope = "figure")
        {
            this.Scope = scope;
            this.Prompt = prompt;
            this.AdvancedChartAgent = advancedChartAgent;
            this.ReturnOverlays = returnOverlays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureAgentic" /> class.
        /// </summary>
        public FigureAgentic()
        {
        }
    }
}