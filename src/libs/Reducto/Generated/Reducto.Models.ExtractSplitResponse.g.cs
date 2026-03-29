
#nullable enable

namespace Reducto
{
    /// <summary>
    /// This is the response format for Extract -&gt; Split Pipelines
    /// </summary>
    public sealed partial class ExtractSplitResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SplitName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> PageRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partition")]
        public string? Partition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse> Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSplitResponse" /> class.
        /// </summary>
        /// <param name="splitName"></param>
        /// <param name="pageRange"></param>
        /// <param name="result"></param>
        /// <param name="partition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractSplitResponse(
            string splitName,
            global::System.Collections.Generic.IList<int> pageRange,
            global::Reducto.AnyOf<global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse> result,
            string? partition)
        {
            this.SplitName = splitName ?? throw new global::System.ArgumentNullException(nameof(splitName));
            this.PageRange = pageRange ?? throw new global::System.ArgumentNullException(nameof(pageRange));
            this.Partition = partition;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSplitResponse" /> class.
        /// </summary>
        public ExtractSplitResponse()
        {
        }
    }
}