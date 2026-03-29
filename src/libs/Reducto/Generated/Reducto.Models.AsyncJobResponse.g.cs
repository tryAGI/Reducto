
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AsyncJobResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AsyncJobResponseStatus Status { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="progress"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncJobResponse(
            global::Reducto.AsyncJobResponseStatus status,
            global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>? result,
            double? progress,
            string? reason)
        {
            this.Status = status;
            this.Result = result;
            this.Progress = progress;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncJobResponse" /> class.
        /// </summary>
        public AsyncJobResponse()
        {
        }
    }
}