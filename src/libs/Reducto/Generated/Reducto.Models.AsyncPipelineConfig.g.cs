
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncPipelineConfig
    {
        /// <summary>
        /// The URL of the document to be processed. You can provide one of the following:<br/>
        ///             1. A publicly available URL<br/>
        ///             2. A presigned S3 URL<br/>
        ///             3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document<br/>
        ///             4. [API-131] A list of URLs (for multi-document pipelines, V3 API only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> DocumentUrl { get; set; }

        /// <summary>
        /// The ID of the pipeline to use for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineId { get; set; }

        /// <summary>
        /// Settings for pipeline execution that override pipeline defaults.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Reducto.PipelineSettings? Settings { get; set; }

        /// <summary>
        /// Default Value: {"mode":"disabled","channels":[]}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::Reducto.WebhookConfigNew? Webhook { get; set; }

        /// <summary>
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public bool? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncPipelineConfig" /> class.
        /// </summary>
        /// <param name="documentUrl">
        /// The URL of the document to be processed. You can provide one of the following:<br/>
        ///             1. A publicly available URL<br/>
        ///             2. A presigned S3 URL<br/>
        ///             3. A reducto:// prefixed URL obtained from the /upload endpoint after directly uploading a document<br/>
        ///             4. [API-131] A list of URLs (for multi-document pipelines, V3 API only)
        /// </param>
        /// <param name="pipelineId">
        /// The ID of the pipeline to use for the document.
        /// </param>
        /// <param name="settings">
        /// Settings for pipeline execution that override pipeline defaults.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="webhook">
        /// Default Value: {"mode":"disabled","channels":[]}
        /// </param>
        /// <param name="priority">
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncPipelineConfig(
            global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse> documentUrl,
            string pipelineId,
            global::Reducto.PipelineSettings? settings,
            global::Reducto.WebhookConfigNew? webhook,
            bool? priority)
        {
            this.DocumentUrl = documentUrl;
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.Settings = settings;
            this.Webhook = webhook;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncPipelineConfig" /> class.
        /// </summary>
        public AsyncPipelineConfig()
        {
        }
    }
}