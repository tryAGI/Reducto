
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProcessingOptionsIgnoreBlock
    {
        /// <summary>
        /// 
        /// </summary>
        Comment,
        /// <summary>
        /// 
        /// </summary>
        Figure,
        /// <summary>
        /// 
        /// </summary>
        Footer,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        KeyValue,
        /// <summary>
        /// 
        /// </summary>
        ListItem,
        /// <summary>
        /// 
        /// </summary>
        PageNumber,
        /// <summary>
        /// 
        /// </summary>
        SectionHeader,
        /// <summary>
        /// 
        /// </summary>
        Signature,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsIgnoreBlockExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsIgnoreBlock value)
        {
            return value switch
            {
                ProcessingOptionsIgnoreBlock.Comment => "Comment",
                ProcessingOptionsIgnoreBlock.Figure => "Figure",
                ProcessingOptionsIgnoreBlock.Footer => "Footer",
                ProcessingOptionsIgnoreBlock.Header => "Header",
                ProcessingOptionsIgnoreBlock.KeyValue => "Key Value",
                ProcessingOptionsIgnoreBlock.ListItem => "List Item",
                ProcessingOptionsIgnoreBlock.PageNumber => "Page Number",
                ProcessingOptionsIgnoreBlock.SectionHeader => "Section Header",
                ProcessingOptionsIgnoreBlock.Signature => "Signature",
                ProcessingOptionsIgnoreBlock.Table => "Table",
                ProcessingOptionsIgnoreBlock.Text => "Text",
                ProcessingOptionsIgnoreBlock.Title => "Title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsIgnoreBlock? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => ProcessingOptionsIgnoreBlock.Comment,
                "Figure" => ProcessingOptionsIgnoreBlock.Figure,
                "Footer" => ProcessingOptionsIgnoreBlock.Footer,
                "Header" => ProcessingOptionsIgnoreBlock.Header,
                "Key Value" => ProcessingOptionsIgnoreBlock.KeyValue,
                "List Item" => ProcessingOptionsIgnoreBlock.ListItem,
                "Page Number" => ProcessingOptionsIgnoreBlock.PageNumber,
                "Section Header" => ProcessingOptionsIgnoreBlock.SectionHeader,
                "Signature" => ProcessingOptionsIgnoreBlock.Signature,
                "Table" => ProcessingOptionsIgnoreBlock.Table,
                "Text" => ProcessingOptionsIgnoreBlock.Text,
                "Title" => ProcessingOptionsIgnoreBlock.Title,
                _ => null,
            };
        }
    }
}