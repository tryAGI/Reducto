#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProcessingOptionsChunkModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.ProcessingOptionsChunkMode>
    {
        /// <inheritdoc />
        public override global::Reducto.ProcessingOptionsChunkMode Read(
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
                        return global::Reducto.ProcessingOptionsChunkModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.ProcessingOptionsChunkMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.ProcessingOptionsChunkMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.ProcessingOptionsChunkMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reducto.ProcessingOptionsChunkModeExtensions.ToValueString(value));
        }
    }
}
