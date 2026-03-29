#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseProcessingOptionsFilterBlockNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.BaseProcessingOptionsFilterBlock?>
    {
        /// <inheritdoc />
        public override global::Reducto.BaseProcessingOptionsFilterBlock? Read(
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
                        return global::Reducto.BaseProcessingOptionsFilterBlockExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.BaseProcessingOptionsFilterBlock)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.BaseProcessingOptionsFilterBlock?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.BaseProcessingOptionsFilterBlock? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.BaseProcessingOptionsFilterBlockExtensions.ToValueString(value.Value));
            }
        }
    }
}
