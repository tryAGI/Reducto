
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for text extraction from PDFs. OCR mode uses optical character recognition only. Hybrid mode combines OCR with embedded PDF text for best accuracy (default).<br/>
    /// Default Value: hybrid
    /// </summary>
    public enum SettingsExtractionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Ocr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SettingsExtractionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SettingsExtractionMode value)
        {
            return value switch
            {
                SettingsExtractionMode.Hybrid => "hybrid",
                SettingsExtractionMode.Ocr => "ocr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SettingsExtractionMode? ToEnum(string value)
        {
            return value switch
            {
                "hybrid" => SettingsExtractionMode.Hybrid,
                "ocr" => SettingsExtractionMode.Ocr,
                _ => null,
            };
        }
    }
}