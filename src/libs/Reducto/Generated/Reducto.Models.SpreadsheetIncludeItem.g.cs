
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpreadsheetIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        CellColors,
        /// <summary>
        /// 
        /// </summary>
        Dropdowns,
        /// <summary>
        /// 
        /// </summary>
        Formula,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetIncludeItem value)
        {
            return value switch
            {
                SpreadsheetIncludeItem.CellColors => "cell_colors",
                SpreadsheetIncludeItem.Dropdowns => "dropdowns",
                SpreadsheetIncludeItem.Formula => "formula",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "cell_colors" => SpreadsheetIncludeItem.CellColors,
                "dropdowns" => SpreadsheetIncludeItem.Dropdowns,
                "formula" => SpreadsheetIncludeItem.Formula,
                _ => null,
            };
        }
    }
}