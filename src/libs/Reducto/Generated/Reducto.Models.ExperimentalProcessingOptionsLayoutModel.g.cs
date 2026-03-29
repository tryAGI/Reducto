
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The layout model to use for the document. This will be deprecated in the future.<br/>
    /// Default Value: default
    /// </summary>
    public enum ExperimentalProcessingOptionsLayoutModel
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentalProcessingOptionsLayoutModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentalProcessingOptionsLayoutModel value)
        {
            return value switch
            {
                ExperimentalProcessingOptionsLayoutModel.Beta => "beta",
                ExperimentalProcessingOptionsLayoutModel.Default => "default",
                ExperimentalProcessingOptionsLayoutModel.Qwen3527b0317 => "qwen35_27b_0317",
                ExperimentalProcessingOptionsLayoutModel.Rfdetr => "rfdetr",
                ExperimentalProcessingOptionsLayoutModel.Rfdetr0302 => "rfdetr0302",
                ExperimentalProcessingOptionsLayoutModel.Rfdetr0303 => "rfdetr0303",
                ExperimentalProcessingOptionsLayoutModel.Rfdetr0304 => "rfdetr0304",
                ExperimentalProcessingOptionsLayoutModel.Rfdetrbase0218 => "rfdetrbase0218",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentalProcessingOptionsLayoutModel? ToEnum(string value)
        {
            return value switch
            {
                "beta" => ExperimentalProcessingOptionsLayoutModel.Beta,
                "default" => ExperimentalProcessingOptionsLayoutModel.Default,
                "qwen35_27b_0317" => ExperimentalProcessingOptionsLayoutModel.Qwen3527b0317,
                "rfdetr" => ExperimentalProcessingOptionsLayoutModel.Rfdetr,
                "rfdetr0302" => ExperimentalProcessingOptionsLayoutModel.Rfdetr0302,
                "rfdetr0303" => ExperimentalProcessingOptionsLayoutModel.Rfdetr0303,
                "rfdetr0304" => ExperimentalProcessingOptionsLayoutModel.Rfdetr0304,
                "rfdetrbase0218" => ExperimentalProcessingOptionsLayoutModel.Rfdetrbase0218,
                _ => null,
            };
        }
    }
}