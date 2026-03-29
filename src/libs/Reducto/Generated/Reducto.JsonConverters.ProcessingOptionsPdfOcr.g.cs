#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProcessingOptionsPdfOcrJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.ProcessingOptionsPdfOcr>
    {
        /// <inheritdoc />
        public override global::Reducto.ProcessingOptionsPdfOcr Read(
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
                        return global::Reducto.ProcessingOptionsPdfOcrExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.ProcessingOptionsPdfOcr)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.ProcessingOptionsPdfOcr);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.ProcessingOptionsPdfOcr value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reducto.ProcessingOptionsPdfOcrExtensions.ToValueString(value));
        }
    }
}
