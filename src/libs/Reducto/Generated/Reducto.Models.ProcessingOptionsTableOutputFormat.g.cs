
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for table output. Defaults to html.<br/>
    /// Default Value: html
    /// </summary>
    public enum ProcessingOptionsTableOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AiJson,
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
        Md,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsTableOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsTableOutputFormat value)
        {
            return value switch
            {
                ProcessingOptionsTableOutputFormat.AiJson => "ai_json",
                ProcessingOptionsTableOutputFormat.Csv => "csv",
                ProcessingOptionsTableOutputFormat.Dynamic => "dynamic",
                ProcessingOptionsTableOutputFormat.Html => "html",
                ProcessingOptionsTableOutputFormat.Json => "json",
                ProcessingOptionsTableOutputFormat.Md => "md",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsTableOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "ai_json" => ProcessingOptionsTableOutputFormat.AiJson,
                "csv" => ProcessingOptionsTableOutputFormat.Csv,
                "dynamic" => ProcessingOptionsTableOutputFormat.Dynamic,
                "html" => ProcessingOptionsTableOutputFormat.Html,
                "json" => ProcessingOptionsTableOutputFormat.Json,
                "md" => ProcessingOptionsTableOutputFormat.Md,
                _ => null,
            };
        }
    }
}