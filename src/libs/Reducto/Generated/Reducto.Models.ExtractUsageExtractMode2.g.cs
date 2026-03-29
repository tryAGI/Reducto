
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtractUsageExtractMode2
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
    public static class ExtractUsageExtractMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractUsageExtractMode2 value)
        {
            return value switch
            {
                ExtractUsageExtractMode2.Extract => "extract",
                ExtractUsageExtractMode2.SpreadsheetAgent => "spreadsheet_agent",
                ExtractUsageExtractMode2.SuperAgent => "super_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractUsageExtractMode2? ToEnum(string value)
        {
            return value switch
            {
                "extract" => ExtractUsageExtractMode2.Extract,
                "spreadsheet_agent" => ExtractUsageExtractMode2.SpreadsheetAgent,
                "super_agent" => ExtractUsageExtractMode2.SuperAgent,
                _ => null,
            };
        }
    }
}