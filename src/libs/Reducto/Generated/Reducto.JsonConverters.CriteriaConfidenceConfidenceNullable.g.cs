#nullable enable

namespace Reducto.JsonConverters
{
    /// <inheritdoc />
    public sealed class CriteriaConfidenceConfidenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reducto.CriteriaConfidenceConfidence?>
    {
        /// <inheritdoc />
        public override global::Reducto.CriteriaConfidenceConfidence? Read(
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
                        return global::Reducto.CriteriaConfidenceConfidenceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reducto.CriteriaConfidenceConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reducto.CriteriaConfidenceConfidence?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reducto.CriteriaConfidenceConfidence? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reducto.CriteriaConfidenceConfidenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
