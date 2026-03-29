
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for OCR. If agentic is enabled, table OCR will be automatically edited.<br/>
    /// Default Value: standard
    /// </summary>
    public enum ProcessingOptionsOcrMode
    {
        /// <summary>
        /// 
        /// </summary>
        Agentic,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsOcrModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsOcrMode value)
        {
            return value switch
            {
                ProcessingOptionsOcrMode.Agentic => "agentic",
                ProcessingOptionsOcrMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsOcrMode? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ProcessingOptionsOcrMode.Agentic,
                "standard" => ProcessingOptionsOcrMode.Standard,
                _ => null,
            };
        }
    }
}