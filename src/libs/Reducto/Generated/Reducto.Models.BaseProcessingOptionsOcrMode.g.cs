
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for OCR. Agentic mode adds an extra pass, correcting any table/text mistakes at a small cost.<br/>
    /// Default Value: standard
    /// </summary>
    public enum BaseProcessingOptionsOcrMode
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
    public static class BaseProcessingOptionsOcrModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseProcessingOptionsOcrMode value)
        {
            return value switch
            {
                BaseProcessingOptionsOcrMode.Agentic => "agentic",
                BaseProcessingOptionsOcrMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseProcessingOptionsOcrMode? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => BaseProcessingOptionsOcrMode.Agentic,
                "standard" => BaseProcessingOptionsOcrMode.Standard,
                _ => null,
            };
        }
    }
}