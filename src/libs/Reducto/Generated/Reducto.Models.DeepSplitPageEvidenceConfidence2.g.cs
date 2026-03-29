
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeepSplitPageEvidenceConfidence2
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepSplitPageEvidenceConfidence2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepSplitPageEvidenceConfidence2 value)
        {
            return value switch
            {
                DeepSplitPageEvidenceConfidence2.High => "high",
                DeepSplitPageEvidenceConfidence2.Low => "low",
                DeepSplitPageEvidenceConfidence2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepSplitPageEvidenceConfidence2? ToEnum(string value)
        {
            return value switch
            {
                "high" => DeepSplitPageEvidenceConfidence2.High,
                "low" => DeepSplitPageEvidenceConfidence2.Low,
                "medium" => DeepSplitPageEvidenceConfidence2.Medium,
                _ => null,
            };
        }
    }
}