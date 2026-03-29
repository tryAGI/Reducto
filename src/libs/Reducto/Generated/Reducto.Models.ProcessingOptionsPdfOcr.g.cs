
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The method to use for OCR. hybrid uses the PDF text first, then OCR. pdf only uses the PDF text. ocr only uses OCR.<br/>
    /// Default Value: ocr
    /// </summary>
    public enum ProcessingOptionsPdfOcr
    {
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Ocr,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsPdfOcrExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsPdfOcr value)
        {
            return value switch
            {
                ProcessingOptionsPdfOcr.Hybrid => "hybrid",
                ProcessingOptionsPdfOcr.Ocr => "ocr",
                ProcessingOptionsPdfOcr.Pdf => "pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsPdfOcr? ToEnum(string value)
        {
            return value switch
            {
                "hybrid" => ProcessingOptionsPdfOcr.Hybrid,
                "ocr" => ProcessingOptionsPdfOcr.Ocr,
                "pdf" => ProcessingOptionsPdfOcr.Pdf,
                _ => null,
            };
        }
    }
}