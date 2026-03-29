
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The array extraction version to use.<br/>
    /// Default Value: legacy
    /// </summary>
    public enum ArrayExtractConfigMode
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
    public static class ArrayExtractConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArrayExtractConfigMode value)
        {
            return value switch
            {
                ArrayExtractConfigMode.Auto => "auto",
                ArrayExtractConfigMode.Legacy => "legacy",
                ArrayExtractConfigMode.NoOverlap => "no_overlap",
                ArrayExtractConfigMode.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArrayExtractConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ArrayExtractConfigMode.Auto,
                "legacy" => ArrayExtractConfigMode.Legacy,
                "no_overlap" => ArrayExtractConfigMode.NoOverlap,
                "streaming" => ArrayExtractConfigMode.Streaming,
                _ => null,
            };
        }
    }
}