
#nullable enable

namespace Reducto
{
    /// <summary>
    /// If tables should be truncated to the first few rows or if all content should be preserved. truncate improves latency, preserve is recommended for cases where partition_key is being used and the partition_key may be included within the table. Defaults to truncate<br/>
    /// Default Value: truncate
    /// </summary>
    public enum SplitOptionsTableCutoff
    {
        /// <summary>
        /// 
        /// </summary>
        Preserve,
        /// <summary>
        /// 
        /// </summary>
        Truncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitOptionsTableCutoffExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitOptionsTableCutoff value)
        {
            return value switch
            {
                SplitOptionsTableCutoff.Preserve => "preserve",
                SplitOptionsTableCutoff.Truncate => "truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitOptionsTableCutoff? ToEnum(string value)
        {
            return value switch
            {
                "preserve" => SplitOptionsTableCutoff.Preserve,
                "truncate" => SplitOptionsTableCutoff.Truncate,
                _ => null,
            };
        }
    }
}