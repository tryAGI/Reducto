#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class SplitOptionsTableCutoffNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.SplitOptionsTableCutoff?>
    {
        /// <inheritdoc />
        public override global::Reducto.SplitOptionsTableCutoff? Read(
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
                        return global::Reducto.SplitOptionsTableCutoffExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.SplitOptionsTableCutoff)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.SplitOptionsTableCutoff?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.SplitOptionsTableCutoff? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.SplitOptionsTableCutoffExtensions.ToValueString(value.Value));
            }
        }
    }
}
