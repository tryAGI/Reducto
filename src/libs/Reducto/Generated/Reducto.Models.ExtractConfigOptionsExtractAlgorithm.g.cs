
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The array extraction version to use.<br/>
    /// Default Value: legacy
    /// </summary>
    public enum ExtractConfigOptionsExtractAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        NoOverlap,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractConfigOptionsExtractAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractConfigOptionsExtractAlgorithm value)
        {
            return value switch
            {
                ExtractConfigOptionsExtractAlgorithm.Auto => "auto",
                ExtractConfigOptionsExtractAlgorithm.Legacy => "legacy",
                ExtractConfigOptionsExtractAlgorithm.NoOverlap => "no_overlap",
                ExtractConfigOptionsExtractAlgorithm.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractConfigOptionsExtractAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ExtractConfigOptionsExtractAlgorithm.Auto,
                "legacy" => ExtractConfigOptionsExtractAlgorithm.Legacy,
                "no_overlap" => ExtractConfigOptionsExtractAlgorithm.NoOverlap,
                "streaming" => ExtractConfigOptionsExtractAlgorithm.Streaming,
                _ => null,
            };
        }
    }
}