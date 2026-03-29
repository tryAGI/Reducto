
#nullable enable

namespace Reducto
{
    /// <summary>
    /// In a spreadsheet with different tables inside, we enable splitting up the tables by default. Intelligent mode applies more powerful models for superior accuracy, at 5× the default per-cell rate. Disabling will register as one large table.<br/>
    /// Default Value: default
    /// </summary>
    public enum AdvancedProcessingOptionsSpreadsheetTableClustering
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Intelligent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvancedProcessingOptionsSpreadsheetTableClusteringExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvancedProcessingOptionsSpreadsheetTableClustering value)
        {
            return value switch
            {
                AdvancedProcessingOptionsSpreadsheetTableClustering.Default => "default",
                AdvancedProcessingOptionsSpreadsheetTableClustering.Disabled => "disabled",
                AdvancedProcessingOptionsSpreadsheetTableClustering.Intelligent => "intelligent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvancedProcessingOptionsSpreadsheetTableClustering? ToEnum(string value)
        {
            return value switch
            {
                "default" => AdvancedProcessingOptionsSpreadsheetTableClustering.Default,
                "disabled" => AdvancedProcessingOptionsSpreadsheetTableClustering.Disabled,
                "intelligent" => AdvancedProcessingOptionsSpreadsheetTableClustering.Intelligent,
                _ => null,
            };
        }
    }
}