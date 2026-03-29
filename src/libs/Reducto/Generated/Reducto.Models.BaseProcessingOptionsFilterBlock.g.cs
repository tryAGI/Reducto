
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseProcessingOptionsFilterBlock
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
    public static class BaseProcessingOptionsFilterBlockExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseProcessingOptionsFilterBlock value)
        {
            return value switch
            {
                BaseProcessingOptionsFilterBlock.Comment => "Comment",
                BaseProcessingOptionsFilterBlock.Figure => "Figure",
                BaseProcessingOptionsFilterBlock.Footer => "Footer",
                BaseProcessingOptionsFilterBlock.Header => "Header",
                BaseProcessingOptionsFilterBlock.KeyValue => "Key Value",
                BaseProcessingOptionsFilterBlock.ListItem => "List Item",
                BaseProcessingOptionsFilterBlock.PageNumber => "Page Number",
                BaseProcessingOptionsFilterBlock.SectionHeader => "Section Header",
                BaseProcessingOptionsFilterBlock.Signature => "Signature",
                BaseProcessingOptionsFilterBlock.Table => "Table",
                BaseProcessingOptionsFilterBlock.Text => "Text",
                BaseProcessingOptionsFilterBlock.Title => "Title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseProcessingOptionsFilterBlock? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => BaseProcessingOptionsFilterBlock.Comment,
                "Figure" => BaseProcessingOptionsFilterBlock.Figure,
                "Footer" => BaseProcessingOptionsFilterBlock.Footer,
                "Header" => BaseProcessingOptionsFilterBlock.Header,
                "Key Value" => BaseProcessingOptionsFilterBlock.KeyValue,
                "List Item" => BaseProcessingOptionsFilterBlock.ListItem,
                "Page Number" => BaseProcessingOptionsFilterBlock.PageNumber,
                "Section Header" => BaseProcessingOptionsFilterBlock.SectionHeader,
                "Signature" => BaseProcessingOptionsFilterBlock.Signature,
                "Table" => BaseProcessingOptionsFilterBlock.Table,
                "Text" => BaseProcessingOptionsFilterBlock.Text,
                "Title" => BaseProcessingOptionsFilterBlock.Title,
                _ => null,
            };
        }
    }
}