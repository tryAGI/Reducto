
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Standard is our best multilingual OCR system. Legacy only supports germanic languages and is available for backwards compatibility.<br/>
    /// Default Value: standard
    /// </summary>
    public enum SettingsOcrSystem
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SettingsOcrSystemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingsOcrSystem value)
        {
            return value switch
            {
                SettingsOcrSystem.Legacy => "legacy",
                SettingsOcrSystem.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingsOcrSystem? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => SettingsOcrSystem.Legacy,
                "standard" => SettingsOcrSystem.Standard,
                _ => null,
            };
        }
    }
}