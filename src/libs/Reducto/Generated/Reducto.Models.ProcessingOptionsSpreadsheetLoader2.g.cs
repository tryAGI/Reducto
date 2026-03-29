
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProcessingOptionsSpreadsheetLoader2
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsSpreadsheetLoader2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsSpreadsheetLoader2 value)
        {
            return value switch
            {
                ProcessingOptionsSpreadsheetLoader2.Default => "default",
                ProcessingOptionsSpreadsheetLoader2.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsSpreadsheetLoader2? ToEnum(string value)
        {
            return value switch
            {
                "default" => ProcessingOptionsSpreadsheetLoader2.Default,
                "legacy" => ProcessingOptionsSpreadsheetLoader2.Legacy,
                _ => null,
            };
        }
    }
}