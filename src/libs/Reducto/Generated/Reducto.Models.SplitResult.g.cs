
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_mapping")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? SectionMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.Split> Splits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResult" /> class.
        /// </summary>
        /// <param name="splits"></param>
        /// <param name="sectionMapping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitResult(
            global::System.Collections.Generic.IList<global::Reducto.Split> splits,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? sectionMapping)
        {
            this.SectionMapping = sectionMapping;
            this.Splits = splits ?? throw new global::System.ArgumentNullException(nameof(splits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResult" /> class.
        /// </summary>
        public SplitResult()
        {
        }
    }
}