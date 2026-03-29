
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum SingleJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Classify,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Extract,
        /// <summary>
        /// 
        /// </summary>
        Parse,
        /// <summary>
        /// 
        /// </summary>
        Pipeline,
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SingleJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SingleJobType value)
        {
            return value switch
            {
                SingleJobType.Classify => "Classify",
                SingleJobType.Edit => "Edit",
                SingleJobType.Extract => "Extract",
                SingleJobType.Parse => "Parse",
                SingleJobType.Pipeline => "Pipeline",
                SingleJobType.Split => "Split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SingleJobType? ToEnum(string value)
        {
            return value switch
            {
                "Classify" => SingleJobType.Classify,
                "Edit" => SingleJobType.Edit,
                "Extract" => SingleJobType.Extract,
                "Parse" => SingleJobType.Parse,
                "Pipeline" => SingleJobType.Pipeline,
                "Split" => SingleJobType.Split,
                _ => null,
            };
        }
    }
}