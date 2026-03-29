
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.ParseUsage Usage { get; set; }

        /// <summary>
        /// The split result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.SplitResult, global::Reducto.DeepSplitResult>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<global::Reducto.SplitResult, global::Reducto.DeepSplitResult> Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResponse" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="result">
        /// The split result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitResponse(
            global::Reducto.ParseUsage usage,
            global::Reducto.AnyOf<global::Reducto.SplitResult, global::Reducto.DeepSplitResult> result)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResponse" /> class.
        /// </summary>
        public SplitResponse()
        {
        }
    }
}