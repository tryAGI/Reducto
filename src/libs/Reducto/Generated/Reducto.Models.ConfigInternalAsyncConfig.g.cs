
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigInternalAsyncConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::Reducto.WebhookConfig? Webhook { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="ConfigInternalAsyncConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="webhook"></param>
        /// <param name="priority">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigInternalAsyncConfig(
            bool? enabled,
            global::Reducto.WebhookConfig? webhook,
            bool? priority)
        {
            this.Enabled = enabled;
            this.Webhook = webhook;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigInternalAsyncConfig" /> class.
        /// </summary>
        public ConfigInternalAsyncConfig()
        {
        }
    }
}