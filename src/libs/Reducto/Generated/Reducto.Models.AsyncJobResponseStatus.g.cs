
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum AsyncJobResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncJobResponseStatus value)
        {
            return value switch
            {
                AsyncJobResponseStatus.Completed => "Completed",
                AsyncJobResponseStatus.Failed => "Failed",
                AsyncJobResponseStatus.Idle => "Idle",
                AsyncJobResponseStatus.Pending => "Pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Completed" => AsyncJobResponseStatus.Completed,
                "Failed" => AsyncJobResponseStatus.Failed,
                "Idle" => AsyncJobResponseStatus.Idle,
                "Pending" => AsyncJobResponseStatus.Pending,
                _ => null,
            };
        }
    }
}