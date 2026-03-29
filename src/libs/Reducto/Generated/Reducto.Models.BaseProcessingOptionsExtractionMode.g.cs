
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for extraction. Metadata/hybrid are only recommended with high quality metadata embeddings.<br/>
    /// Default Value: ocr
    /// </summary>
    public enum BaseProcessingOptionsExtractionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Ocr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseProcessingOptionsExtractionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseProcessingOptionsExtractionMode value)
        {
            return value switch
            {
                BaseProcessingOptionsExtractionMode.Hybrid => "hybrid",
                BaseProcessingOptionsExtractionMode.Metadata => "metadata",
                BaseProcessingOptionsExtractionMode.Ocr => "ocr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseProcessingOptionsExtractionMode? ToEnum(string value)
        {
            return value switch
            {
                "hybrid" => BaseProcessingOptionsExtractionMode.Hybrid,
                "metadata" => BaseProcessingOptionsExtractionMode.Metadata,
                "ocr" => BaseProcessingOptionsExtractionMode.Ocr,
                _ => null,
            };
        }
    }
}