
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdvancedCitationsConfig
    {
        /// <summary>
        /// If True, enable numeric citation confidence scores. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerical_confidence")]
        public bool? NumericalConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedCitationsConfig" /> class.
        /// </summary>
        /// <param name="numericalConfidence">
        /// If True, enable numeric citation confidence scores. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvancedCitationsConfig(
            bool? numericalConfidence)
        {
            this.NumericalConfidence = numericalConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedCitationsConfig" /> class.
        /// </summary>
        public AdvancedCitationsConfig()
        {
        }
    }
}