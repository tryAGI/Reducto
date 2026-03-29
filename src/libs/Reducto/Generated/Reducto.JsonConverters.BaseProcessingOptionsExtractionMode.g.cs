#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseProcessingOptionsExtractionModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.BaseProcessingOptionsExtractionMode>
    {
        /// <inheritdoc />
        public override global::Reducto.BaseProcessingOptionsExtractionMode Read(
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
                        return global::Reducto.BaseProcessingOptionsExtractionModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.BaseProcessingOptionsExtractionMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.BaseProcessingOptionsExtractionMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.BaseProcessingOptionsExtractionMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reducto.BaseProcessingOptionsExtractionModeExtensions.ToValueString(value));
        }
    }
}
