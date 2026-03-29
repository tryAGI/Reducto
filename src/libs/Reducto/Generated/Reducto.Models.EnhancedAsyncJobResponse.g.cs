
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnhancedAsyncJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.EnhancedAsyncJobResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.EnhancedAsyncJobResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>))]
        public global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Reducto.EnhancedAsyncJobResponseType2? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pages")]
        public int? NumPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public object? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_config")]
        public string? RawConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public object? Bucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedAsyncJobResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="progress"></param>
        /// <param name="reason"></param>
        /// <param name="type"></param>
        /// <param name="numPages"></param>
        /// <param name="totalPages"></param>
        /// <param name="source"></param>
        /// <param name="duration"></param>
        /// <param name="createdAt"></param>
        /// <param name="rawConfig"></param>
        /// <param name="bucket"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnhancedAsyncJobResponse(
            global::Reducto.EnhancedAsyncJobResponseStatus status,
            global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>? result,
            double? progress,
            string? reason,
            global::Reducto.EnhancedAsyncJobResponseType2? type,
            int? numPages,
            int? totalPages,
            object? source,
            double? duration,
            global::System.DateTime? createdAt,
            string? rawConfig,
            object? bucket)
        {
            this.Status = status;
            this.Result = result;
            this.Progress = progress;
            this.Reason = reason;
            this.Type = type;
            this.NumPages = numPages;
            this.TotalPages = totalPages;
            this.Source = source;
            this.Duration = duration;
            this.CreatedAt = createdAt;
            this.RawConfig = rawConfig;
            this.Bucket = bucket;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedAsyncJobResponse" /> class.
        /// </summary>
        public EnhancedAsyncJobResponse()
        {
        }
    }
}