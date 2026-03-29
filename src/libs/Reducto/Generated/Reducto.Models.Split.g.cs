
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Split
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SplitConfJsonConverter))]
        public global::Reducto.SplitConf? Conf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitions")]
        public global::System.Collections.Generic.IList<global::Reducto.SplitPartition>? Partitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pages"></param>
        /// <param name="conf">
        /// Default Value: low
        /// </param>
        /// <param name="partitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Split(
            string name,
            global::System.Collections.Generic.IList<int> pages,
            global::Reducto.SplitConf? conf,
            global::System.Collections.Generic.IList<global::Reducto.SplitPartition>? partitions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Conf = conf;
            this.Partitions = partitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        public Split()
        {
        }
    }
}