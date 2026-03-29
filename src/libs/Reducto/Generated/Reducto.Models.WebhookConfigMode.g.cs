
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Default Value: direct
    /// </summary>
    public enum WebhookConfigMode
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Svix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigMode value)
        {
            return value switch
            {
                WebhookConfigMode.Direct => "direct",
                WebhookConfigMode.Svix => "svix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "direct" => WebhookConfigMode.Direct,
                "svix" => WebhookConfigMode.Svix,
                _ => null,
            };
        }
    }
}