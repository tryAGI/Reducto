
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for table output. Dynamic returns md for simpler tables and html for more complex tables.<br/>
    /// Default Value: html
    /// </summary>
    public enum AdvancedProcessingOptionsTableOutputFormat
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
        Jsonbbox,
        /// <summary>
        /// 
        /// </summary>
        Md,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvancedProcessingOptionsTableOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvancedProcessingOptionsTableOutputFormat value)
        {
            return value switch
            {
                AdvancedProcessingOptionsTableOutputFormat.AiJson => "ai_json",
                AdvancedProcessingOptionsTableOutputFormat.Csv => "csv",
                AdvancedProcessingOptionsTableOutputFormat.Dynamic => "dynamic",
                AdvancedProcessingOptionsTableOutputFormat.Html => "html",
                AdvancedProcessingOptionsTableOutputFormat.Json => "json",
                AdvancedProcessingOptionsTableOutputFormat.Jsonbbox => "jsonbbox",
                AdvancedProcessingOptionsTableOutputFormat.Md => "md",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvancedProcessingOptionsTableOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "ai_json" => AdvancedProcessingOptionsTableOutputFormat.AiJson,
                "csv" => AdvancedProcessingOptionsTableOutputFormat.Csv,
                "dynamic" => AdvancedProcessingOptionsTableOutputFormat.Dynamic,
                "html" => AdvancedProcessingOptionsTableOutputFormat.Html,
                "json" => AdvancedProcessingOptionsTableOutputFormat.Json,
                "jsonbbox" => AdvancedProcessingOptionsTableOutputFormat.Jsonbbox,
                "md" => AdvancedProcessingOptionsTableOutputFormat.Md,
                _ => null,
            };
        }
    }
}