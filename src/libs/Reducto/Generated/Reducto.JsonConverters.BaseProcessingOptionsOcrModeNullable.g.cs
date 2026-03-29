#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseProcessingOptionsOcrModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.BaseProcessingOptionsOcrMode?>
    {
        /// <inheritdoc />
        public override global::Reducto.BaseProcessingOptionsOcrMode? Read(
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
                        return global::Reducto.BaseProcessingOptionsOcrModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.BaseProcessingOptionsOcrMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.BaseProcessingOptionsOcrMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.BaseProcessingOptionsOcrMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.BaseProcessingOptionsOcrModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
