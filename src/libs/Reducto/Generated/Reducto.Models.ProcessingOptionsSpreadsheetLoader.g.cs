
#nullable enable

namespace Reducto
{
    /// <summary>
    ///
    /// </summary>
    public enum ProcessingOptionsSpreadsheetLoader
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
    public static class ProcessingOptionsSpreadsheetLoaderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsSpreadsheetLoader value)
        {
            return value switch
            {
                ProcessingOptionsSpreadsheetLoader.Default => "default",
                ProcessingOptionsSpreadsheetLoader.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsSpreadsheetLoader? ToEnum(string value)
        {
            return value switch
            {
                "default" => ProcessingOptionsSpreadsheetLoader.Default,
                "legacy" => ProcessingOptionsSpreadsheetLoader.Legacy,
                _ => null,
            };
        }
    }
}