
#nullable enable

namespace Reducto
{
    /// <summary>
    ///
    /// </summary>
    public enum EnhancedAsyncJobResponseType
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
    public static class EnhancedAsyncJobResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhancedAsyncJobResponseType value)
        {
            return value switch
            {
                EnhancedAsyncJobResponseType.Classify => "Classify",
                EnhancedAsyncJobResponseType.Edit => "Edit",
                EnhancedAsyncJobResponseType.Extract => "Extract",
                EnhancedAsyncJobResponseType.Parse => "Parse",
                EnhancedAsyncJobResponseType.Pipeline => "Pipeline",
                EnhancedAsyncJobResponseType.Split => "Split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhancedAsyncJobResponseType? ToEnum(string value)
        {
            return value switch
            {
                "Classify" => EnhancedAsyncJobResponseType.Classify,
                "Edit" => EnhancedAsyncJobResponseType.Edit,
                "Extract" => EnhancedAsyncJobResponseType.Extract,
                "Parse" => EnhancedAsyncJobResponseType.Parse,
                "Pipeline" => EnhancedAsyncJobResponseType.Pipeline,
                "Split" => EnhancedAsyncJobResponseType.Split,
                _ => null,
            };
        }
    }
}