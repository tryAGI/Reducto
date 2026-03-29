
#nullable enable

namespace Reducto
{
    /// <summary>
    /// Customer-facing queue priority for parse jobs.
    /// </summary>
    public enum QueuePriority
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueuePriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueuePriority value)
        {
            return value switch
            {
                QueuePriority.Auto => "auto",
                QueuePriority.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueuePriority? ToEnum(string value)
        {
            return value switch
            {
                "auto" => QueuePriority.Auto,
                "batch" => QueuePriority.Batch,
                _ => null,
            };
        }
    }
}