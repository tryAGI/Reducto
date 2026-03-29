
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The mode to use for chunking. Defaults to 'variable'. Section chunks according to sections in the document. Page chunks according to pages. Page sections chunks according to both pages and sections. Disabled returns a single chunk.<br/>
    /// Default Value: variable
    /// </summary>
    public enum ProcessingOptionsChunkMode
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Page,
        /// <summary>
        /// 
        /// </summary>
        PageSections,
        /// <summary>
        /// 
        /// </summary>
        Section,
        /// <summary>
        /// 
        /// </summary>
        Variable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsChunkModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsChunkMode value)
        {
            return value switch
            {
                ProcessingOptionsChunkMode.Block => "block",
                ProcessingOptionsChunkMode.Disabled => "disabled",
                ProcessingOptionsChunkMode.Page => "page",
                ProcessingOptionsChunkMode.PageSections => "page_sections",
                ProcessingOptionsChunkMode.Section => "section",
                ProcessingOptionsChunkMode.Variable => "variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsChunkMode? ToEnum(string value)
        {
            return value switch
            {
                "block" => ProcessingOptionsChunkMode.Block,
                "disabled" => ProcessingOptionsChunkMode.Disabled,
                "page" => ProcessingOptionsChunkMode.Page,
                "page_sections" => ProcessingOptionsChunkMode.PageSections,
                "section" => ProcessingOptionsChunkMode.Section,
                "variable" => ProcessingOptionsChunkMode.Variable,
                _ => null,
            };
        }
    }
}