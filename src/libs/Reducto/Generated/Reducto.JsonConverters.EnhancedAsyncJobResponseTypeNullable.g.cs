#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnhancedAsyncJobResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.EnhancedAsyncJobResponseType?>
    {
        /// <inheritdoc />
        public override global::Reducto.EnhancedAsyncJobResponseType? Read(
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
                        return global::Reducto.EnhancedAsyncJobResponseTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.EnhancedAsyncJobResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.EnhancedAsyncJobResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.EnhancedAsyncJobResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.EnhancedAsyncJobResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
