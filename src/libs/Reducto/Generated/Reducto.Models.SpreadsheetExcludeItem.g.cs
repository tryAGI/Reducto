
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpreadsheetExcludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        HiddenCols,
        /// <summary>
        /// 
        /// </summary>
        HiddenRows,
        /// <summary>
        /// 
        /// </summary>
        HiddenSheets,
        /// <summary>
        /// 
        /// </summary>
        SpreadsheetImages,
        /// <summary>
        /// 
        /// </summary>
        Styling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetExcludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetExcludeItem value)
        {
            return value switch
            {
                SpreadsheetExcludeItem.HiddenCols => "hidden_cols",
                SpreadsheetExcludeItem.HiddenRows => "hidden_rows",
                SpreadsheetExcludeItem.HiddenSheets => "hidden_sheets",
                SpreadsheetExcludeItem.SpreadsheetImages => "spreadsheet_images",
                SpreadsheetExcludeItem.Styling => "styling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetExcludeItem? ToEnum(string value)
        {
            return value switch
            {
                "hidden_cols" => SpreadsheetExcludeItem.HiddenCols,
                "hidden_rows" => SpreadsheetExcludeItem.HiddenRows,
                "hidden_sheets" => SpreadsheetExcludeItem.HiddenSheets,
                "spreadsheet_images" => SpreadsheetExcludeItem.SpreadsheetImages,
                "styling" => SpreadsheetExcludeItem.Styling,
                _ => null,
            };
        }
    }
}