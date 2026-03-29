
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractConfigOptions
    {
        /// <summary>
        /// If citations should be generated for the extracted content.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_citations")]
        public bool? GenerateCitations { get; set; }

        /// <summary>
        /// If True, enable numeric citation confidence scores. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerical_confidence")]
        public bool? NumericalConfidence { get; set; }

        /// <summary>
        /// If spreadsheet agent should be used for extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_agent")]
        public bool? SpreadsheetAgent { get; set; }

        /// <summary>
        /// If table citations should be generated for the extracted content.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental_table_citations")]
        public bool? ExperimentalTableCitations { get; set; }

        /// <summary>
        /// Array extraction allows you to extract long lists of information from lengthy documents. It makes parallel calls on overlapping sections of the document.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array_extract")]
        public bool? ArrayExtract { get; set; }

        /// <summary>
        /// Length of each segment, in pages, for parallel calls with array extraction.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array_extract_pages")]
        public int? ArrayExtractPages { get; set; }

        /// <summary>
        /// The array extraction version to use.<br/>
        /// Default Value: legacy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reducto.JsonConverters.ExtractConfigOptionsExtractAlgorithmJsonConverter))]
        public global::Reducto.ExtractConfigOptionsExtractAlgorithm? ExtractAlgorithm { get; set; }

        /// <summary>
        /// Number of items to extract in each stream call.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_extract_item_density")]
        public int? StreamingExtractItemDensity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfigOptions" /> class.
        /// </summary>
        /// <param name="generateCitations">
        /// If citations should be generated for the extracted content.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="numericalConfidence">
        /// If True, enable numeric citation confidence scores. Defaults to False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetAgent">
        /// If spreadsheet agent should be used for extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="experimentalTableCitations">
        /// If table citations should be generated for the extracted content.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="arrayExtract">
        /// Array extraction allows you to extract long lists of information from lengthy documents. It makes parallel calls on overlapping sections of the document.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="arrayExtractPages">
        /// Length of each segment, in pages, for parallel calls with array extraction.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="extractAlgorithm">
        /// The array extraction version to use.<br/>
        /// Default Value: legacy
        /// </param>
        /// <param name="streamingExtractItemDensity">
        /// Number of items to extract in each stream call.<br/>
        /// Default Value: 50
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractConfigOptions(
            bool? generateCitations,
            bool? numericalConfidence,
            bool? spreadsheetAgent,
            bool? experimentalTableCitations,
            bool? arrayExtract,
            int? arrayExtractPages,
            global::Reducto.ExtractConfigOptionsExtractAlgorithm? extractAlgorithm,
            int? streamingExtractItemDensity)
        {
            this.GenerateCitations = generateCitations;
            this.NumericalConfidence = numericalConfidence;
            this.SpreadsheetAgent = spreadsheetAgent;
            this.ExperimentalTableCitations = experimentalTableCitations;
            this.ArrayExtract = arrayExtract;
            this.ArrayExtractPages = arrayExtractPages;
            this.ExtractAlgorithm = extractAlgorithm;
            this.StreamingExtractItemDensity = streamingExtractItemDensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfigOptions" /> class.
        /// </summary>
        public ExtractConfigOptions()
        {
        }
    }
}