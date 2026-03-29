
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Default Value: low
    /// </summary>
    public enum SplitPartitionConf
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
    public static class SplitPartitionConfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitPartitionConf value)
        {
            return value switch
            {
                SplitPartitionConf.High => "high",
                SplitPartitionConf.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitPartitionConf? ToEnum(string value)
        {
            return value switch
            {
                "high" => SplitPartitionConf.High,
                "low" => SplitPartitionConf.Low,
                _ => null,
            };
        }
    }
}