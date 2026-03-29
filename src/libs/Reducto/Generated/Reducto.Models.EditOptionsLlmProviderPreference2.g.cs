
#nullable enable

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditOptionsLlmProviderPreference2
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditOptionsLlmProviderPreference2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditOptionsLlmProviderPreference2 value)
        {
            return value switch
            {
                EditOptionsLlmProviderPreference2.Anthropic => "anthropic",
                EditOptionsLlmProviderPreference2.Google => "google",
                EditOptionsLlmProviderPreference2.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditOptionsLlmProviderPreference2? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => EditOptionsLlmProviderPreference2.Anthropic,
                "google" => EditOptionsLlmProviderPreference2.Google,
                "openai" => EditOptionsLlmProviderPreference2.Openai,
                _ => null,
            };
        }
    }
}