
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Default Value: low
    /// </summary>
    public enum SplitConf
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
    public static class SplitConfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitConf value)
        {
            return value switch
            {
                SplitConf.High => "high",
                SplitConf.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitConf? ToEnum(string value)
        {
            return value switch
            {
                "high" => SplitConf.High,
                "low" => SplitConf.Low,
                _ => null,
            };
        }
    }
}