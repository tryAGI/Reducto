
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for table output. Defaults to dynamic, which returns md for simpler tables and html for more complex tables.<br/>
    /// Default Value: dynamic
    /// </summary>
    public enum FormattingTableOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Jsonbbox,
        /// <summary>
        /// 
        /// </summary>
        Md,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormattingTableOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormattingTableOutputFormat value)
        {
            return value switch
            {
                FormattingTableOutputFormat.Csv => "csv",
                FormattingTableOutputFormat.Dynamic => "dynamic",
                FormattingTableOutputFormat.Html => "html",
                FormattingTableOutputFormat.Json => "json",
                FormattingTableOutputFormat.Jsonbbox => "jsonbbox",
                FormattingTableOutputFormat.Md => "md",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormattingTableOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => FormattingTableOutputFormat.Csv,
                "dynamic" => FormattingTableOutputFormat.Dynamic,
                "html" => FormattingTableOutputFormat.Html,
                "json" => FormattingTableOutputFormat.Json,
                "jsonbbox" => FormattingTableOutputFormat.Jsonbbox,
                "md" => FormattingTableOutputFormat.Md,
                _ => null,
            };
        }
    }
}