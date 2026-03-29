
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookConfigNew
    {
        /// <summary>
        /// The mode to use for webhook delivery. Defaults to 'disabled'. We recommend using 'svix' for production environments.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.WebhookConfigNewModeJsonConverter))]
        public global::Reducto.WebhookConfigNewMode? Mode { get; set; }

        /// <summary>
        /// The URL to send the webhook to (if using direct webhoook).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// JSON metadata included in webhook request body
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
        /// Initializes a new instance of the <see cref="WebhookConfigNew" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode to use for webhook delivery. Defaults to 'disabled'. We recommend using 'svix' for production environments.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="url">
        /// The URL to send the webhook to (if using direct webhoook).
        /// </param>
        /// <param name="metadata">
        /// JSON metadata included in webhook request body
        /// </param>
        /// <param name="channels">
        /// A list of Svix channels the message will be delivered down, omit to send to all channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfigNew(
            global::Reducto.WebhookConfigNewMode? mode,
            string? url,
            object? metadata,
            global::System.Collections.Generic.IList<string>? channels)
        {
            this.Mode = mode;
            this.Url = url;
            this.Metadata = metadata;
            this.Channels = channels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfigNew" /> class.
        /// </summary>
        public WebhookConfigNew()
        {
        }
    }
}