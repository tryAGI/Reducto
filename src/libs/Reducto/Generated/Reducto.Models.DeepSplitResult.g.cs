
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepSplitResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.DeepSplit> Splits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplitResult" /> class.
        /// </summary>
        /// <param name="splits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepSplitResult(
            global::System.Collections.Generic.IList<global::Reducto.DeepSplit> splits)
        {
            this.Splits = splits ?? throw new global::System.ArgumentNullException(nameof(splits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepSplitResult" /> class.
        /// </summary>
        public DeepSplitResult()
        {
        }
    }
}