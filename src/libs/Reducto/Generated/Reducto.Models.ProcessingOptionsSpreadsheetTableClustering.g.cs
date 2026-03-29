
#nullable enable

namespace Reducto
{
    /// <summary>
    /// On a spreadsheet, the algorithm that is used to split up sheets into multiple tables.<br/>
    /// Default Value: default
    /// </summary>
    public enum ProcessingOptionsSpreadsheetTableClustering
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
    public static class ProcessingOptionsSpreadsheetTableClusteringExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsSpreadsheetTableClustering value)
        {
            return value switch
            {
                ProcessingOptionsSpreadsheetTableClustering.Default => "default",
                ProcessingOptionsSpreadsheetTableClustering.Disabled => "disabled",
                ProcessingOptionsSpreadsheetTableClustering.Intelligent => "intelligent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsSpreadsheetTableClustering? ToEnum(string value)
        {
            return value switch
            {
                "default" => ProcessingOptionsSpreadsheetTableClustering.Default,
                "disabled" => ProcessingOptionsSpreadsheetTableClustering.Disabled,
                "intelligent" => ProcessingOptionsSpreadsheetTableClustering.Intelligent,
                _ => null,
            };
        }
    }
}