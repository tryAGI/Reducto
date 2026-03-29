
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum SettingsReturnImage
    {
        /// <summary>
        /// 
        /// </summary>
        Figure,
        /// <summary>
        /// 
        /// </summary>
        Page,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SettingsReturnImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingsReturnImage value)
        {
            return value switch
            {
                SettingsReturnImage.Figure => "figure",
                SettingsReturnImage.Page => "page",
                SettingsReturnImage.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingsReturnImage? ToEnum(string value)
        {
            return value switch
            {
                "figure" => SettingsReturnImage.Figure,
                "page" => SettingsReturnImage.Page,
                "table" => SettingsReturnImage.Table,
                _ => null,
            };
        }
    }
}