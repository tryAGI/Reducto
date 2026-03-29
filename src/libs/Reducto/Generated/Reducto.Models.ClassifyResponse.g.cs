
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Response from classify job - returned when polling /job/{job_id}
    /// </summary>
    public sealed partial class ClassifyResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.ClassifyResponseCategory Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_confidence")]
        public global::Reducto.ResponseConfidence? ResponseConfidence { get; set; }

        /// <summary>
        /// The duration of the classify request in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="result"></param>
        /// <param name="responseConfidence"></param>
        /// <param name="duration">
        /// The duration of the classify request in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyResponse(
            string jobId,
            global::Reducto.ClassifyResponseCategory result,
            global::Reducto.ResponseConfidence? responseConfidence,
            double? duration)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.ResponseConfidence = responseConfidence;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponse" /> class.
        /// </summary>
        public ClassifyResponse()
        {
        }
    }
}