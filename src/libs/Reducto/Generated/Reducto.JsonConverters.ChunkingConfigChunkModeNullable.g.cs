#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChunkingConfigChunkModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.ChunkingConfigChunkMode?>
    {
        /// <inheritdoc />
        public override global::Reducto.ChunkingConfigChunkMode? Read(
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
                        return global::Reducto.ChunkingConfigChunkModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.ChunkingConfigChunkMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.ChunkingConfigChunkMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.ChunkingConfigChunkMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.ChunkingConfigChunkModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
