#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProcessingOptionsIgnoreBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.ProcessingOptionsIgnoreBlock>
    {
        /// <inheritdoc />
        public override global::Reducto.ProcessingOptionsIgnoreBlock Read(
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
                        return global::Reducto.ProcessingOptionsIgnoreBlockExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.ProcessingOptionsIgnoreBlock)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.ProcessingOptionsIgnoreBlock);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.ProcessingOptionsIgnoreBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reducto.ProcessingOptionsIgnoreBlockExtensions.ToValueString(value));
        }
    }
}
