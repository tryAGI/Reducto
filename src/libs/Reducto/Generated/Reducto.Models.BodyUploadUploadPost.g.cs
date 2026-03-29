
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadUploadPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadUploadPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadUploadPost(
            byte[]? file,
            string? filename)
        {
            this.File = file;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadUploadPost" /> class.
        /// </summary>
        public BodyUploadUploadPost()
        {
        }
    }
}