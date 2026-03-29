#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdvancedProcessingOptionsSpreadsheetTableClusteringNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering?>
    {
        /// <inheritdoc />
        public override global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering? Read(
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
                        return global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClusteringExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClusteringExtensions.ToValueString(value.Value));
            }
        }
    }
}
