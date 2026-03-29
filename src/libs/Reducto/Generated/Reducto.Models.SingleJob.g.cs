
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SingleJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.SingleJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.SingleJobTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.SingleJobType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public object? Source { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

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
        /// Initializes a new instance of the <see cref="SingleJob" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="rawConfig"></param>
        /// <param name="createdAt"></param>
        /// <param name="source"></param>
        /// <param name="numPages"></param>
        /// <param name="totalPages"></param>
        /// <param name="duration"></param>
        /// <param name="bucket"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleJob(
            string jobId,
            global::Reducto.SingleJobStatus status,
            global::Reducto.SingleJobType type,
            string rawConfig,
            global::System.DateTime createdAt,
            object? source,
            int? numPages,
            int? totalPages,
            double? duration,
            object? bucket)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.Type = type;
            this.RawConfig = rawConfig ?? throw new global::System.ArgumentNullException(nameof(rawConfig));
            this.CreatedAt = createdAt;
            this.Source = source;
            this.NumPages = numPages;
            this.TotalPages = totalPages;
            this.Duration = duration;
            this.Bucket = bucket;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleJob" /> class.
        /// </summary>
        public SingleJob()
        {
        }
    }
}