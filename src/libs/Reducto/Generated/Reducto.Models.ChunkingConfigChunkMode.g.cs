
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Choose how to partition chunks. Variable mode chunks by character length and visual context. Section mode chunks by section headers. Page mode chunks according to pages. Page sections mode chunks first by page, then by sections within each page. Disabled returns one single chunk.<br/>
    /// Default Value: variable
    /// </summary>
    public enum ChunkingConfigChunkMode
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
    public static class ChunkingConfigChunkModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkingConfigChunkMode value)
        {
            return value switch
            {
                ChunkingConfigChunkMode.Block => "block",
                ChunkingConfigChunkMode.Disabled => "disabled",
                ChunkingConfigChunkMode.Page => "page",
                ChunkingConfigChunkMode.PageSections => "page_sections",
                ChunkingConfigChunkMode.Section => "section",
                ChunkingConfigChunkMode.Variable => "variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkingConfigChunkMode? ToEnum(string value)
        {
            return value switch
            {
                "block" => ChunkingConfigChunkMode.Block,
                "disabled" => ChunkingConfigChunkMode.Disabled,
                "page" => ChunkingConfigChunkMode.Page,
                "page_sections" => ChunkingConfigChunkMode.PageSections,
                "section" => ChunkingConfigChunkMode.Section,
                "variable" => ChunkingConfigChunkMode.Variable,
                _ => null,
            };
        }
    }
}