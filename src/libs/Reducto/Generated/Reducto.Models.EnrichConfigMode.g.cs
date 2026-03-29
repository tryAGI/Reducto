
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for enrichment. Defaults to standard<br/>
    /// Default Value: standard
    /// </summary>
    public enum EnrichConfigMode
    {
        /// <summary>
        /// 
        /// </summary>
        Page,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnrichConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnrichConfigMode value)
        {
            return value switch
            {
                EnrichConfigMode.Page => "page",
                EnrichConfigMode.Standard => "standard",
                EnrichConfigMode.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnrichConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "page" => EnrichConfigMode.Page,
                "standard" => EnrichConfigMode.Standard,
                "table" => EnrichConfigMode.Table,
                _ => null,
            };
        }
    }
}