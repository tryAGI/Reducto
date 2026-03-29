
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The type of block extracted from the document.
    /// </summary>
    public enum ParseBlockType
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
    public static class ParseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseBlockType value)
        {
            return value switch
            {
                ParseBlockType.Comment => "Comment",
                ParseBlockType.Figure => "Figure",
                ParseBlockType.Footer => "Footer",
                ParseBlockType.Header => "Header",
                ParseBlockType.KeyValue => "Key Value",
                ParseBlockType.ListItem => "List Item",
                ParseBlockType.PageNumber => "Page Number",
                ParseBlockType.SectionHeader => "Section Header",
                ParseBlockType.Signature => "Signature",
                ParseBlockType.Table => "Table",
                ParseBlockType.Text => "Text",
                ParseBlockType.Title => "Title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => ParseBlockType.Comment,
                "Figure" => ParseBlockType.Figure,
                "Footer" => ParseBlockType.Footer,
                "Header" => ParseBlockType.Header,
                "Key Value" => ParseBlockType.KeyValue,
                "List Item" => ParseBlockType.ListItem,
                "Page Number" => ParseBlockType.PageNumber,
                "Section Header" => ParseBlockType.SectionHeader,
                "Signature" => ParseBlockType.Signature,
                "Table" => ParseBlockType.Table,
                "Text" => ParseBlockType.Text,
                "Title" => ParseBlockType.Title,
                _ => null,
            };
        }
    }
}