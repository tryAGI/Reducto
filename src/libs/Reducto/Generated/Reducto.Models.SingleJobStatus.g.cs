
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum SingleJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Completing,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SingleJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SingleJobStatus value)
        {
            return value switch
            {
                SingleJobStatus.Cancelled => "Cancelled",
                SingleJobStatus.Completed => "Completed",
                SingleJobStatus.Completing => "Completing",
                SingleJobStatus.Failed => "Failed",
                SingleJobStatus.Idle => "Idle",
                SingleJobStatus.InProgress => "InProgress",
                SingleJobStatus.Pending => "Pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SingleJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => SingleJobStatus.Cancelled,
                "Completed" => SingleJobStatus.Completed,
                "Completing" => SingleJobStatus.Completing,
                "Failed" => SingleJobStatus.Failed,
                "Idle" => SingleJobStatus.Idle,
                "InProgress" => SingleJobStatus.InProgress,
                "Pending" => SingleJobStatus.Pending,
                _ => null,
            };
        }
    }
}