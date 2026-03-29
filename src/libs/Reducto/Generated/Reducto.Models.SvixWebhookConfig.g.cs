
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SvixWebhookConfig
    {
        /// <summary>
        /// Default Value: svix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

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
        /// Initializes a new instance of the <see cref="SvixWebhookConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Default Value: svix
        /// </param>
        /// <param name="channels">
        /// A list of Svix channels the message will be delivered down, omit to send to all channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvixWebhookConfig(
            string? mode,
            global::System.Collections.Generic.IList<string>? channels)
        {
            this.Mode = mode;
            this.Channels = channels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvixWebhookConfig" /> class.
        /// </summary>
        public SvixWebhookConfig()
        {
        }
    }
}