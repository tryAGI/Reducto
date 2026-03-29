
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProcessingOptionsCustomFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AiUsage,
        /// <summary>
        /// 
        /// </summary>
        Aml,
        /// <summary>
        /// 
        /// </summary>
        AmlChunking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsCustomFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsCustomFormat value)
        {
            return value switch
            {
                ProcessingOptionsCustomFormat.AiUsage => "ai_usage",
                ProcessingOptionsCustomFormat.Aml => "aml",
                ProcessingOptionsCustomFormat.AmlChunking => "aml_chunking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsCustomFormat? ToEnum(string value)
        {
            return value switch
            {
                "ai_usage" => ProcessingOptionsCustomFormat.AiUsage,
                "aml" => ProcessingOptionsCustomFormat.Aml,
                "aml_chunking" => ProcessingOptionsCustomFormat.AmlChunking,
                _ => null,
            };
        }
    }
}