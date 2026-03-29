
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsResponse
    {
        /// <summary>
        /// List of jobs with their job_id, status, type, raw_config, created_at, num_pages and duration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reducto.SingleJob> Jobs { get; set; }

        /// <summary>
        /// Cursor to fetch the next page of results. If null, there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsResponse" /> class.
        /// </summary>
        /// <param name="jobs">
        /// List of jobs with their job_id, status, type, raw_config, created_at, num_pages and duration
        /// </param>
        /// <param name="nextCursor">
        /// Cursor to fetch the next page of results. If null, there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobsResponse(
            global::System.Collections.Generic.IList<global::Reducto.SingleJob> jobs,
            string? nextCursor)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsResponse" /> class.
        /// </summary>
        public JobsResponse()
        {
        }
    }
}