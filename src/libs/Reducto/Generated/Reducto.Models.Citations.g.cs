
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Citations
    {
        /// <summary>
        /// If True, include citations in the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// If True, enable numeric citation confidence scores. Defaults to True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerical_confidence")]
        public bool? NumericalConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Citations" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If True, include citations in the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="numericalConfidence">
        /// If True, enable numeric citation confidence scores. Defaults to True.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Citations(
            bool? enabled,
            bool? numericalConfidence)
        {
            this.Enabled = enabled;
            this.NumericalConfidence = numericalConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Citations" /> class.
        /// </summary>
        public Citations()
        {
        }
    }
}