
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The type of document to be processed. Defaults to document. If auto is specified, the orientation of the first page will be used to determine the document type.<br/>
    /// Default Value: document
    /// </summary>
    public enum ProcessingOptionsMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Deck,
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsMode value)
        {
            return value switch
            {
                ProcessingOptionsMode.Auto => "auto",
                ProcessingOptionsMode.Deck => "deck",
                ProcessingOptionsMode.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ProcessingOptionsMode.Auto,
                "deck" => ProcessingOptionsMode.Deck,
                "document" => ProcessingOptionsMode.Document,
                _ => null,
            };
        }
    }
}