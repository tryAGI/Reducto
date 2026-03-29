
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// The duration of the parse request in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// The storage URL of the converted PDF file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_url")]
        public string? PdfUrl { get; set; }

        /// <summary>
        /// The link to the studio pipeline for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_link")]
        public string? StudioLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.ParseUsage Usage { get; set; }

        /// <summary>
        /// The response from the document processing service. Note that there can be two types of responses, Full Result and URL Result. This is due to limitations on the max return size on HTTPS. If the response is too large, it will be returned as a presigned URL in the URL response. You should handle this in your application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.FullResult, global::Reducto.UrlResult>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<global::Reducto.FullResult, global::Reducto.UrlResult> Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="duration">
        /// The duration of the parse request in seconds.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="result">
        /// The response from the document processing service. Note that there can be two types of responses, Full Result and URL Result. This is due to limitations on the max return size on HTTPS. If the response is too large, it will be returned as a presigned URL in the URL response. You should handle this in your application.
        /// </param>
        /// <param name="pdfUrl">
        /// The storage URL of the converted PDF file.
        /// </param>
        /// <param name="studioLink">
        /// The link to the studio pipeline for the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseResponse(
            string jobId,
            double duration,
            global::Reducto.ParseUsage usage,
            global::Reducto.AnyOf<global::Reducto.FullResult, global::Reducto.UrlResult> result,
            string? pdfUrl,
            string? studioLink)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Duration = duration;
            this.PdfUrl = pdfUrl;
            this.StudioLink = studioLink;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResponse" /> class.
        /// </summary>
        public ParseResponse()
        {
        }
    }
}