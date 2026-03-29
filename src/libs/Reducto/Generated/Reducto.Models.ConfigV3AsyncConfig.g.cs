
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigV3AsyncConfig
    {
        /// <summary>
        /// JSON metadata included in webhook request body. Defaults to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public bool? Priority { get; set; }

        /// <summary>
        /// The webhook configuration for the asynchronous processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.SvixWebhookConfig, global::Reducto.DirectWebhookConfig, object>))]
        public global::Reducto.AnyOf<global::Reducto.SvixWebhookConfig, global::Reducto.DirectWebhookConfig, object>? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigV3AsyncConfig" /> class.
        /// </summary>
        /// <param name="metadata">
        /// JSON metadata included in webhook request body. Defaults to None.
        /// </param>
        /// <param name="priority">
        /// If True, attempts to process the job with priority if the user has priority processing budget available; by default, sync jobs are prioritized above async jobs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhook">
        /// The webhook configuration for the asynchronous processing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigV3AsyncConfig(
            object? metadata,
            bool? priority,
            global::Reducto.AnyOf<global::Reducto.SvixWebhookConfig, global::Reducto.DirectWebhookConfig, object>? webhook)
        {
            this.Metadata = metadata;
            this.Priority = priority;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigV3AsyncConfig" /> class.
        /// </summary>
        public ConfigV3AsyncConfig()
        {
        }
    }
}