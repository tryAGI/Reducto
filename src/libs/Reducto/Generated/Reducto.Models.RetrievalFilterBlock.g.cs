
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetrievalFilterBlock
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
    public static class RetrievalFilterBlockExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalFilterBlock value)
        {
            return value switch
            {
                RetrievalFilterBlock.Comment => "Comment",
                RetrievalFilterBlock.Figure => "Figure",
                RetrievalFilterBlock.Footer => "Footer",
                RetrievalFilterBlock.Header => "Header",
                RetrievalFilterBlock.KeyValue => "Key Value",
                RetrievalFilterBlock.ListItem => "List Item",
                RetrievalFilterBlock.PageNumber => "Page Number",
                RetrievalFilterBlock.SectionHeader => "Section Header",
                RetrievalFilterBlock.Signature => "Signature",
                RetrievalFilterBlock.Table => "Table",
                RetrievalFilterBlock.Text => "Text",
                RetrievalFilterBlock.Title => "Title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalFilterBlock? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => RetrievalFilterBlock.Comment,
                "Figure" => RetrievalFilterBlock.Figure,
                "Footer" => RetrievalFilterBlock.Footer,
                "Header" => RetrievalFilterBlock.Header,
                "Key Value" => RetrievalFilterBlock.KeyValue,
                "List Item" => RetrievalFilterBlock.ListItem,
                "Page Number" => RetrievalFilterBlock.PageNumber,
                "Section Header" => RetrievalFilterBlock.SectionHeader,
                "Signature" => RetrievalFilterBlock.Signature,
                "Table" => RetrievalFilterBlock.Table,
                "Text" => RetrievalFilterBlock.Text,
                "Title" => RetrievalFilterBlock.Title,
                _ => null,
            };
        }
    }
}