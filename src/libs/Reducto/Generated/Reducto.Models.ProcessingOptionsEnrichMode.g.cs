
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for enrichment. Defaults to standard<br/>
    /// Default Value: standard
    /// </summary>
    public enum ProcessingOptionsEnrichMode
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
    public static class ProcessingOptionsEnrichModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsEnrichMode value)
        {
            return value switch
            {
                ProcessingOptionsEnrichMode.Page => "page",
                ProcessingOptionsEnrichMode.Standard => "standard",
                ProcessingOptionsEnrichMode.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsEnrichMode? ToEnum(string value)
        {
            return value switch
            {
                "page" => ProcessingOptionsEnrichMode.Page,
                "standard" => ProcessingOptionsEnrichMode.Standard,
                "table" => ProcessingOptionsEnrichMode.Table,
                _ => null,
            };
        }
    }
}