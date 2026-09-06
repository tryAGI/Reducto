#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditOptionsLlmProviderPreferenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.EditOptionsLlmProviderPreference?>
    {
        /// <inheritdoc />
        public override global::Reducto.EditOptionsLlmProviderPreference? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Reducto.EditOptionsLlmProviderPreferenceExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.EditOptionsLlmProviderPreference)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.EditOptionsLlmProviderPreference?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.EditOptionsLlmProviderPreference? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.EditOptionsLlmProviderPreferenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
