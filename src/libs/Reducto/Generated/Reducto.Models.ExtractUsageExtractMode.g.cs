
#nullable enable

namespace Reducto
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractUsageExtractMode
    {
        /// <summary>
        ///
        /// </summary>
        Extract,
        /// <summary>
        ///
        /// </summary>
        SpreadsheetAgent,
        /// <summary>
        ///
        /// </summary>
        SuperAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractUsageExtractModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractUsageExtractMode value)
        {
            return value switch
            {
                ExtractUsageExtractMode.Extract => "extract",
                ExtractUsageExtractMode.SpreadsheetAgent => "spreadsheet_agent",
                ExtractUsageExtractMode.SuperAgent => "super_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractUsageExtractMode? ToEnum(string value)
        {
            return value switch
            {
                "extract" => ExtractUsageExtractMode.Extract,
                "spreadsheet_agent" => ExtractUsageExtractMode.SpreadsheetAgent,
                "super_agent" => ExtractUsageExtractMode.SuperAgent,
                _ => null,
            };
        }
    }
}