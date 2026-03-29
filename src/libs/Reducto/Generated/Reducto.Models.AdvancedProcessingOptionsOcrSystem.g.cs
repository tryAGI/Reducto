
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The OCR system to use. Highres is recommended for documents with English characters. Legacy uses an alternative OCR backend.<br/>
    /// Default Value: highres
    /// </summary>
    public enum AdvancedProcessingOptionsOcrSystem
    {
        /// <summary>
        /// 
        /// </summary>
        Combined,
        /// <summary>
        /// 
        /// </summary>
        Highres,
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Multilingual,
        /// <summary>
        /// 
        /// </summary>
        Reducto,
        /// <summary>
        /// 
        /// </summary>
        ReductoV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvancedProcessingOptionsOcrSystemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvancedProcessingOptionsOcrSystem value)
        {
            return value switch
            {
                AdvancedProcessingOptionsOcrSystem.Combined => "combined",
                AdvancedProcessingOptionsOcrSystem.Highres => "highres",
                AdvancedProcessingOptionsOcrSystem.Legacy => "legacy",
                AdvancedProcessingOptionsOcrSystem.Multilingual => "multilingual",
                AdvancedProcessingOptionsOcrSystem.Reducto => "reducto",
                AdvancedProcessingOptionsOcrSystem.ReductoV2 => "reducto-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvancedProcessingOptionsOcrSystem? ToEnum(string value)
        {
            return value switch
            {
                "combined" => AdvancedProcessingOptionsOcrSystem.Combined,
                "highres" => AdvancedProcessingOptionsOcrSystem.Highres,
                "legacy" => AdvancedProcessingOptionsOcrSystem.Legacy,
                "multilingual" => AdvancedProcessingOptionsOcrSystem.Multilingual,
                "reducto" => AdvancedProcessingOptionsOcrSystem.Reducto,
                "reducto-v2" => AdvancedProcessingOptionsOcrSystem.ReductoV2,
                _ => null,
            };
        }
    }
}