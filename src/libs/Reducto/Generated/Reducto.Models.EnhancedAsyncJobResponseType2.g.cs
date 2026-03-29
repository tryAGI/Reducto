
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnhancedAsyncJobResponseType2
    {
        /// <summary>
        /// 
        /// </summary>
        Classify,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Extract,
        /// <summary>
        /// 
        /// </summary>
        Parse,
        /// <summary>
        /// 
        /// </summary>
        Pipeline,
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnhancedAsyncJobResponseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhancedAsyncJobResponseType2 value)
        {
            return value switch
            {
                EnhancedAsyncJobResponseType2.Classify => "Classify",
                EnhancedAsyncJobResponseType2.Edit => "Edit",
                EnhancedAsyncJobResponseType2.Extract => "Extract",
                EnhancedAsyncJobResponseType2.Parse => "Parse",
                EnhancedAsyncJobResponseType2.Pipeline => "Pipeline",
                EnhancedAsyncJobResponseType2.Split => "Split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhancedAsyncJobResponseType2? ToEnum(string value)
        {
            return value switch
            {
                "Classify" => EnhancedAsyncJobResponseType2.Classify,
                "Edit" => EnhancedAsyncJobResponseType2.Edit,
                "Extract" => EnhancedAsyncJobResponseType2.Extract,
                "Parse" => EnhancedAsyncJobResponseType2.Parse,
                "Pipeline" => EnhancedAsyncJobResponseType2.Pipeline,
                "Split" => EnhancedAsyncJobResponseType2.Split,
                _ => null,
            };
        }
    }
}