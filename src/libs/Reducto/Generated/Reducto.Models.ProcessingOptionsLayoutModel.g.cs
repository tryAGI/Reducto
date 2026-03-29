
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The layout model to use for the document. This will be deprecated in the future.<br/>
    /// Default Value: default
    /// </summary>
    public enum ProcessingOptionsLayoutModel
    {
        /// <summary>
        /// 
        /// </summary>
        Beta,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        PostprocessV2,
        /// <summary>
        /// 
        /// </summary>
        Qwen3527b0317,
        /// <summary>
        /// 
        /// </summary>
        Rfdetr,
        /// <summary>
        /// 
        /// </summary>
        Rfdetr0302,
        /// <summary>
        /// 
        /// </summary>
        Rfdetr0303,
        /// <summary>
        /// 
        /// </summary>
        Rfdetr0304,
        /// <summary>
        /// 
        /// </summary>
        Rfdetrbase0218,
        /// <summary>
        /// 
        /// </summary>
        V3Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsLayoutModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsLayoutModel value)
        {
            return value switch
            {
                ProcessingOptionsLayoutModel.Beta => "beta",
                ProcessingOptionsLayoutModel.Default => "default",
                ProcessingOptionsLayoutModel.PostprocessV2 => "postprocess_v2",
                ProcessingOptionsLayoutModel.Qwen3527b0317 => "qwen35_27b_0317",
                ProcessingOptionsLayoutModel.Rfdetr => "rfdetr",
                ProcessingOptionsLayoutModel.Rfdetr0302 => "rfdetr0302",
                ProcessingOptionsLayoutModel.Rfdetr0303 => "rfdetr0303",
                ProcessingOptionsLayoutModel.Rfdetr0304 => "rfdetr0304",
                ProcessingOptionsLayoutModel.Rfdetrbase0218 => "rfdetrbase0218",
                ProcessingOptionsLayoutModel.V3Standard => "v3_standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsLayoutModel? ToEnum(string value)
        {
            return value switch
            {
                "beta" => ProcessingOptionsLayoutModel.Beta,
                "default" => ProcessingOptionsLayoutModel.Default,
                "postprocess_v2" => ProcessingOptionsLayoutModel.PostprocessV2,
                "qwen35_27b_0317" => ProcessingOptionsLayoutModel.Qwen3527b0317,
                "rfdetr" => ProcessingOptionsLayoutModel.Rfdetr,
                "rfdetr0302" => ProcessingOptionsLayoutModel.Rfdetr0302,
                "rfdetr0303" => ProcessingOptionsLayoutModel.Rfdetr0303,
                "rfdetr0304" => ProcessingOptionsLayoutModel.Rfdetr0304,
                "rfdetrbase0218" => ProcessingOptionsLayoutModel.Rfdetrbase0218,
                "v3_standard" => ProcessingOptionsLayoutModel.V3Standard,
                _ => null,
            };
        }
    }
}