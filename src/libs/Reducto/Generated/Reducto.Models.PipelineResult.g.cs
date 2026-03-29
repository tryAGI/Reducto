
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::System.Collections.Generic.IList<global::Reducto.ParseResponse>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<global::Reducto.ParseResponse, global::System.Collections.Generic.IList<global::Reducto.ParseResponse>, object> Parse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse, object> Extract { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        public global::Reducto.SplitResponse? Split { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit")]
        public global::Reducto.EditResponse? Edit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineResult" /> class.
        /// </summary>
        /// <param name="parse"></param>
        /// <param name="extract"></param>
        /// <param name="split"></param>
        /// <param name="edit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineResult(
            global::Reducto.AnyOf<global::Reducto.ParseResponse, global::System.Collections.Generic.IList<global::Reducto.ParseResponse>, object> parse,
            global::Reducto.AnyOf<global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse, object> extract,
            global::Reducto.SplitResponse? split,
            global::Reducto.EditResponse? edit)
        {
            this.Parse = parse;
            this.Extract = extract;
            this.Split = split;
            this.Edit = edit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineResult" /> class.
        /// </summary>
        public PipelineResult()
        {
        }
    }
}