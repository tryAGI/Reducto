
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Enhance
    {
        /// <summary>
        /// Agentic uses vision language models to enhance the accuracy of the output of different types of extraction. This will incur a cost and latency increase.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic")]
        public global::System.Collections.Generic.IList<global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>>? Agentic { get; set; }

        /// <summary>
        /// If True, summarize figures using a small vision language model. Defaults to True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarize_figures")]
        public bool? SummarizeFigures { get; set; }

        /// <summary>
        /// If True, use an advanced vision language model to improve reading order accuracy, with a small increase in latency. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligent_ordering")]
        public bool? IntelligentOrdering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Enhance" /> class.
        /// </summary>
        /// <param name="agentic">
        /// Agentic uses vision language models to enhance the accuracy of the output of different types of extraction. This will incur a cost and latency increase.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="summarizeFigures">
        /// If True, summarize figures using a small vision language model. Defaults to True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="intelligentOrdering">
        /// If True, use an advanced vision language model to improve reading order accuracy, with a small increase in latency. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Enhance(
            global::System.Collections.Generic.IList<global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>>? agentic,
            bool? summarizeFigures,
            bool? intelligentOrdering)
        {
            this.Agentic = agentic;
            this.SummarizeFigures = summarizeFigures;
            this.IntelligentOrdering = intelligentOrdering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Enhance" /> class.
        /// </summary>
        public Enhance()
        {
        }
    }
}