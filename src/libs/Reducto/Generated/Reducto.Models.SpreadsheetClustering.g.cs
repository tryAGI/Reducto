
#nullable enable

namespace Reducto
{
    /// <summary>
    /// In a spreadsheet with different tables inside, we enable splitting up the tables by default. Accurate mode applies more powerful models for superior accuracy, at 5× the default per-cell rate. Disabling will register as one large table.<br/>
    /// Default Value: accurate
    /// </summary>
    public enum SpreadsheetClustering
    {
        /// <summary>
        /// 
        /// </summary>
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetClusteringExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetClustering value)
        {
            return value switch
            {
                SpreadsheetClustering.Accurate => "accurate",
                SpreadsheetClustering.Disabled => "disabled",
                SpreadsheetClustering.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetClustering? ToEnum(string value)
        {
            return value switch
            {
                "accurate" => SpreadsheetClustering.Accurate,
                "disabled" => SpreadsheetClustering.Disabled,
                "fast" => SpreadsheetClustering.Fast,
                _ => null,
            };
        }
    }
}