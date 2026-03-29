
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Type of the form widget
    /// </summary>
    public enum EditWidgetType
    {
        /// <summary>
        /// 
        /// </summary>
        Barcode,
        /// <summary>
        /// 
        /// </summary>
        Checkbox,
        /// <summary>
        /// 
        /// </summary>
        Dropdown,
        /// <summary>
        /// 
        /// </summary>
        Radio,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditWidgetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditWidgetType value)
        {
            return value switch
            {
                EditWidgetType.Barcode => "barcode",
                EditWidgetType.Checkbox => "checkbox",
                EditWidgetType.Dropdown => "dropdown",
                EditWidgetType.Radio => "radio",
                EditWidgetType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditWidgetType? ToEnum(string value)
        {
            return value switch
            {
                "barcode" => EditWidgetType.Barcode,
                "checkbox" => EditWidgetType.Checkbox,
                "dropdown" => EditWidgetType.Dropdown,
                "radio" => EditWidgetType.Radio,
                "text" => EditWidgetType.Text,
                _ => null,
            };
        }
    }
}