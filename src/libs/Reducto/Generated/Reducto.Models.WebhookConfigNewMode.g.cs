
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for webhook delivery. Defaults to 'disabled'. We recommend using 'svix' for production environments.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum WebhookConfigNewMode
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Svix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookConfigNewModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigNewMode value)
        {
            return value switch
            {
                WebhookConfigNewMode.Direct => "direct",
                WebhookConfigNewMode.Disabled => "disabled",
                WebhookConfigNewMode.Svix => "svix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigNewMode? ToEnum(string value)
        {
            return value switch
            {
                "direct" => WebhookConfigNewMode.Direct,
                "disabled" => WebhookConfigNewMode.Disabled,
                "svix" => WebhookConfigNewMode.Svix,
                _ => null,
            };
        }
    }
}