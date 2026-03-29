
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The OCR system to use. Defaults to cloud (AWS Textract/Azure DocAI/etc).<br/>
    /// Default Value: textract
    /// </summary>
    public enum ProcessingOptionsOcrSystem
    {
        /// <summary>
        /// 
        /// </summary>
        Combined,
        /// <summary>
        /// 
        /// </summary>
        Gcloud,
        /// <summary>
        /// 
        /// </summary>
        ReductoV2,
        /// <summary>
        /// 
        /// </summary>
        ReductoV3,
        /// <summary>
        /// 
        /// </summary>
        ReductoV3Shadow,
        /// <summary>
        /// 
        /// </summary>
        Tesseract,
        /// <summary>
        /// 
        /// </summary>
        Textract,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsOcrSystemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsOcrSystem value)
        {
            return value switch
            {
                ProcessingOptionsOcrSystem.Combined => "combined",
                ProcessingOptionsOcrSystem.Gcloud => "gcloud",
                ProcessingOptionsOcrSystem.ReductoV2 => "reducto-v2",
                ProcessingOptionsOcrSystem.ReductoV3 => "reducto-v3",
                ProcessingOptionsOcrSystem.ReductoV3Shadow => "reducto-v3-shadow",
                ProcessingOptionsOcrSystem.Tesseract => "tesseract",
                ProcessingOptionsOcrSystem.Textract => "textract",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsOcrSystem? ToEnum(string value)
        {
            return value switch
            {
                "combined" => ProcessingOptionsOcrSystem.Combined,
                "gcloud" => ProcessingOptionsOcrSystem.Gcloud,
                "reducto-v2" => ProcessingOptionsOcrSystem.ReductoV2,
                "reducto-v3" => ProcessingOptionsOcrSystem.ReductoV3,
                "reducto-v3-shadow" => ProcessingOptionsOcrSystem.ReductoV3Shadow,
                "tesseract" => ProcessingOptionsOcrSystem.Tesseract,
                "textract" => ProcessingOptionsOcrSystem.Textract,
                _ => null,
            };
        }
    }
}