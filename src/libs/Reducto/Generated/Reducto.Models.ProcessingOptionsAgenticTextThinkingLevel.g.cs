
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Thinking level for Gemini 3 in key-value model. If set to 'high', uses high thinking level.
    /// </summary>
    public enum ProcessingOptionsAgenticTextThinkingLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsAgenticTextThinkingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsAgenticTextThinkingLevel value)
        {
            return value switch
            {
                ProcessingOptionsAgenticTextThinkingLevel.High => "high",
                ProcessingOptionsAgenticTextThinkingLevel.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsAgenticTextThinkingLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => ProcessingOptionsAgenticTextThinkingLevel.High,
                "low" => ProcessingOptionsAgenticTextThinkingLevel.Low,
                _ => null,
            };
        }
    }
}