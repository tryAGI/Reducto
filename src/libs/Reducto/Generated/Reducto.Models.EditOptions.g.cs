
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditOptions
    {
        /// <summary>
        /// The color to use for edits, in hex format.<br/>
        /// Default Value: #FF0000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The font size (in points) to use for filled text fields. If not specified, font size is automatically calculated based on field dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_size")]
        public double? FontSize { get; set; }

        /// <summary>
        /// The LLM provider to use for edit processing. If not specified, defaults to 'google'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider_preference")]
        public global::Reducto.EditOptionsLlmProviderPreference2? LlmProviderPreference { get; set; }

        /// <summary>
        /// If True, creates overflow pages for text that doesn't fit in form fields. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_overflow_pages")]
        public bool? EnableOverflowPages { get; set; }

        /// <summary>
        /// If True, flattens form fields after filling, converting them to static content. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten")]
        public bool? Flatten { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditOptions" /> class.
        /// </summary>
        /// <param name="color">
        /// The color to use for edits, in hex format.<br/>
        /// Default Value: #FF0000
        /// </param>
        /// <param name="fontSize">
        /// The font size (in points) to use for filled text fields. If not specified, font size is automatically calculated based on field dimensions.
        /// </param>
        /// <param name="llmProviderPreference">
        /// The LLM provider to use for edit processing. If not specified, defaults to 'google'
        /// </param>
        /// <param name="enableOverflowPages">
        /// If True, creates overflow pages for text that doesn't fit in form fields. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="flatten">
        /// If True, flattens form fields after filling, converting them to static content. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditOptions(
            string? color,
            double? fontSize,
            global::Reducto.EditOptionsLlmProviderPreference2? llmProviderPreference,
            bool? enableOverflowPages,
            bool? flatten)
        {
            this.Color = color;
            this.FontSize = fontSize;
            this.LlmProviderPreference = llmProviderPreference;
            this.EnableOverflowPages = enableOverflowPages;
            this.Flatten = flatten;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditOptions" /> class.
        /// </summary>
        public EditOptions()
        {
        }
    }
}