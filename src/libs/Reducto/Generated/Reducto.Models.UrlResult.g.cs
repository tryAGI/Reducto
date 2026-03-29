
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UrlResult
    {
        /// <summary>
        /// type = 'url'
        /// </summary>
        /// <default>"url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "url";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlResult" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="resultId"></param>
        /// <param name="type">
        /// type = 'url'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlResult(
            string url,
            string resultId,
            string type = "url")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ResultId = resultId ?? throw new global::System.ArgumentNullException(nameof(resultId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlResult" /> class.
        /// </summary>
        public UrlResult()
        {
        }
    }
}