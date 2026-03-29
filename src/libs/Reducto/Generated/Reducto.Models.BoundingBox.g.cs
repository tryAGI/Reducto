
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BoundingBox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Top { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Height { get; set; }

        /// <summary>
        /// The page number of the bounding box (1-indexed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// The page number in the original document of the bounding box (1-indexed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_page")]
        public int? OriginalPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="page">
        /// The page number of the bounding box (1-indexed).
        /// </param>
        /// <param name="originalPage">
        /// The page number in the original document of the bounding box (1-indexed).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoundingBox(
            double left,
            double top,
            double width,
            double height,
            int page,
            int? originalPage)
        {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
            this.Page = page;
            this.OriginalPage = originalPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        public BoundingBox()
        {
        }
    }
}