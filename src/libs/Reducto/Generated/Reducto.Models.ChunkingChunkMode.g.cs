
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Choose how to partition chunks. Variable mode chunks by character length and visual context. Section mode chunks by section headers. Page mode chunks according to pages. Page sections mode chunks first by page, then by sections within each page. Disabled returns one single chunk.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum ChunkingChunkMode
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
    public static class ChunkingChunkModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkingChunkMode value)
        {
            return value switch
            {
                ChunkingChunkMode.Block => "block",
                ChunkingChunkMode.Disabled => "disabled",
                ChunkingChunkMode.Page => "page",
                ChunkingChunkMode.PageSections => "page_sections",
                ChunkingChunkMode.Section => "section",
                ChunkingChunkMode.Variable => "variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkingChunkMode? ToEnum(string value)
        {
            return value switch
            {
                "block" => ChunkingChunkMode.Block,
                "disabled" => ChunkingChunkMode.Disabled,
                "page" => ChunkingChunkMode.Page,
                "page_sections" => ChunkingChunkMode.PageSections,
                "section" => ChunkingChunkMode.Section,
                "variable" => ChunkingChunkMode.Variable,
                _ => null,
            };
        }
    }
}