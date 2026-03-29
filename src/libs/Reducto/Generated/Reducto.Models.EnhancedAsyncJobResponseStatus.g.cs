
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnhancedAsyncJobResponseStatus
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
    public static class EnhancedAsyncJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhancedAsyncJobResponseStatus value)
        {
            return value switch
            {
                EnhancedAsyncJobResponseStatus.Completed => "Completed",
                EnhancedAsyncJobResponseStatus.Failed => "Failed",
                EnhancedAsyncJobResponseStatus.Idle => "Idle",
                EnhancedAsyncJobResponseStatus.Pending => "Pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhancedAsyncJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Completed" => EnhancedAsyncJobResponseStatus.Completed,
                "Failed" => EnhancedAsyncJobResponseStatus.Failed,
                "Idle" => EnhancedAsyncJobResponseStatus.Idle,
                "Pending" => EnhancedAsyncJobResponseStatus.Pending,
                _ => null,
            };
        }
    }
}