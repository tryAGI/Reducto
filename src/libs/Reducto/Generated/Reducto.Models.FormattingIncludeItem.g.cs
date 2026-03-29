
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormattingIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        ChangeTracking,
        /// <summary>
        /// 
        /// </summary>
        Comments,
        /// <summary>
        /// 
        /// </summary>
        Highlight,
        /// <summary>
        /// 
        /// </summary>
        Hyperlinks,
        /// <summary>
        /// 
        /// </summary>
        IgnoreWatermarks,
        /// <summary>
        /// 
        /// </summary>
        Signatures,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormattingIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormattingIncludeItem value)
        {
            return value switch
            {
                FormattingIncludeItem.ChangeTracking => "change_tracking",
                FormattingIncludeItem.Comments => "comments",
                FormattingIncludeItem.Highlight => "highlight",
                FormattingIncludeItem.Hyperlinks => "hyperlinks",
                FormattingIncludeItem.IgnoreWatermarks => "ignore_watermarks",
                FormattingIncludeItem.Signatures => "signatures",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormattingIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "change_tracking" => FormattingIncludeItem.ChangeTracking,
                "comments" => FormattingIncludeItem.Comments,
                "highlight" => FormattingIncludeItem.Highlight,
                "hyperlinks" => FormattingIncludeItem.Hyperlinks,
                "ignore_watermarks" => FormattingIncludeItem.IgnoreWatermarks,
                "signatures" => FormattingIncludeItem.Signatures,
                _ => null,
            };
        }
    }
}