
#nullable enable

namespace Reducto
{
    /// <summary>
    ///
    /// </summary>
    public enum EditOptionsLlmProviderPreference
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
    public static class EditOptionsLlmProviderPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditOptionsLlmProviderPreference value)
        {
            return value switch
            {
                EditOptionsLlmProviderPreference.Anthropic => "anthropic",
                EditOptionsLlmProviderPreference.Google => "google",
                EditOptionsLlmProviderPreference.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditOptionsLlmProviderPreference? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => EditOptionsLlmProviderPreference.Anthropic,
                "google" => EditOptionsLlmProviderPreference.Google,
                "openai" => EditOptionsLlmProviderPreference.Openai,
                _ => null,
            };
        }
    }
}