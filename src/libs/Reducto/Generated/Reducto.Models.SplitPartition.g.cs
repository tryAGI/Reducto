
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitPartition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Pages { get; set; }

        /// <summary>
        /// Default Value: low
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conf")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SplitPartitionConfJsonConverter))]
        public global::Reducto.SplitPartitionConf? Conf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitPartition" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pages"></param>
        /// <param name="conf">
        /// Default Value: low
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitPartition(
            string name,
            global::System.Collections.Generic.IList<int> pages,
            global::Reducto.SplitPartitionConf? conf)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Conf = conf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitPartition" /> class.
        /// </summary>
        public SplitPartition()
        {
        }
    }
}