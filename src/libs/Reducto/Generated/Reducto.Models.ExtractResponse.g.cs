
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.ExtractUsage Usage { get; set; }

        /// <summary>
        /// The link to the studio pipeline for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_link")]
        public string? StudioLink { get; set; }

        /// <summary>
        /// The extracted response in your provided schema. This is a list of dictionaries. If disable_chunking is True (default), then it will be a list of length one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Result { get; set; }

        /// <summary>
        /// The citations corresponding to the extracted response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<object>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResponse" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="result">
        /// The extracted response in your provided schema. This is a list of dictionaries. If disable_chunking is True (default), then it will be a list of length one.
        /// </param>
        /// <param name="jobId"></param>
        /// <param name="studioLink">
        /// The link to the studio pipeline for the document.
        /// </param>
        /// <param name="citations">
        /// The citations corresponding to the extracted response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractResponse(
            global::Reducto.ExtractUsage usage,
            global::System.Collections.Generic.IList<object> result,
            string? jobId,
            string? studioLink,
            global::System.Collections.Generic.IList<object>? citations)
        {
            this.JobId = jobId;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.StudioLink = studioLink;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResponse" /> class.
        /// </summary>
        public ExtractResponse()
        {
        }
    }
}