
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditWidget
    {
        /// <summary>
        /// Bounding box coordinates of the widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.BoundingBox Bbox { get; set; }

        /// <summary>
        /// Description of the widget extracted from the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Type of the form widget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.EditWidgetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reducto.EditWidgetType Type { get; set; }

        /// <summary>
        /// If True (default), the system will attempt to fill this widget. If False, the widget will be created but intentionally left unfilled.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fill")]
        public bool? Fill { get; set; }

        /// <summary>
        /// If provided, this value will be used directly instead of attempting to intelligently determine the field value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Font size in points for this specific field. Takes priority over the global font_size in EditOptions. If not set, falls back to the global font_size, then to auto-calculated sizing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_size")]
        public double? FontSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWidget" /> class.
        /// </summary>
        /// <param name="bbox">
        /// Bounding box coordinates of the widget
        /// </param>
        /// <param name="description">
        /// Description of the widget extracted from the document
        /// </param>
        /// <param name="type">
        /// Type of the form widget
        /// </param>
        /// <param name="fill">
        /// If True (default), the system will attempt to fill this widget. If False, the widget will be created but intentionally left unfilled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="value">
        /// If provided, this value will be used directly instead of attempting to intelligently determine the field value.
        /// </param>
        /// <param name="fontSize">
        /// Font size in points for this specific field. Takes priority over the global font_size in EditOptions. If not set, falls back to the global font_size, then to auto-calculated sizing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditWidget(
            global::Reducto.BoundingBox bbox,
            string description,
            global::Reducto.EditWidgetType type,
            bool? fill,
            string? value,
            double? fontSize)
        {
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Fill = fill;
            this.Value = value;
            this.FontSize = fontSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWidget" /> class.
        /// </summary>
        public EditWidget()
        {
        }
    }
}