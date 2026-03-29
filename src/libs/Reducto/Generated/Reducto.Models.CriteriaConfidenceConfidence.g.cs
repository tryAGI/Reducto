
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum CriteriaConfidenceConfidence
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CriteriaConfidenceConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CriteriaConfidenceConfidence value)
        {
            return value switch
            {
                CriteriaConfidenceConfidence.High => "high",
                CriteriaConfidenceConfidence.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CriteriaConfidenceConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => CriteriaConfidenceConfidence.High,
                "low" => CriteriaConfidenceConfidence.Low,
                _ => null,
            };
        }
    }
}