
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentInTheLoop
    {
        /// <summary>
        /// If True, include the agent in the loop for the extraction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The name of the array that the agent will extract. Only one field is currently allowed.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields_to_verify")]
        public global::System.Collections.Generic.IList<string>? FieldsToVerify { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInTheLoop" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If True, include the agent in the loop for the extraction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fieldsToVerify">
        /// The name of the array that the agent will extract. Only one field is currently allowed.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInTheLoop(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? fieldsToVerify)
        {
            this.Enabled = enabled;
            this.FieldsToVerify = fieldsToVerify;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInTheLoop" /> class.
        /// </summary>
        public AgentInTheLoop()
        {
        }
    }
}