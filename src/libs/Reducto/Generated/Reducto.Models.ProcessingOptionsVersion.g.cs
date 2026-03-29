
#nullable enable

namespace Reducto
{
    /// <summary>
    /// The version of the processing options.<br/>
    /// Default Value: v1
    /// </summary>
    public enum ProcessingOptionsVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingOptionsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingOptionsVersion value)
        {
            return value switch
            {
                ProcessingOptionsVersion.V1 => "v1",
                ProcessingOptionsVersion.V2 => "v2",
                ProcessingOptionsVersion.V3 => "v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingOptionsVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => ProcessingOptionsVersion.V1,
                "v2" => ProcessingOptionsVersion.V2,
                "v3" => ProcessingOptionsVersion.V3,
                _ => null,
            };
        }
    }
}