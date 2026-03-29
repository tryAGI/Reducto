
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Default Value: direct
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.WebhookConfigModeJsonConverter))]
        public global::Reducto.WebhookConfigMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A list of Svix channels the message will be delivered down, omit to send to all channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<string>? Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfig" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="mode">
        /// Default Value: direct
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="channels">
        /// A list of Svix channels the message will be delivered down, omit to send to all channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfig(
            string? url,
            global::Reducto.WebhookConfigMode? mode,
            object? metadata,
            global::System.Collections.Generic.IList<string>? channels)
        {
            this.Url = url;
            this.Mode = mode;
            this.Metadata = metadata;
            this.Channels = channels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfig" /> class.
        /// </summary>
        public WebhookConfig()
        {
        }
    }
}