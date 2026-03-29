
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Reducto
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsOcrSystemJsonConverter),

            typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsOcrSystemNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsTableOutputFormatJsonConverter),

            typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsTableOutputFormatNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsSpreadsheetTableClusteringJsonConverter),

            typeof(global::Reducto.JsonConverters.AdvancedProcessingOptionsSpreadsheetTableClusteringNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ArrayExtractConfigModeJsonConverter),

            typeof(global::Reducto.JsonConverters.ArrayExtractConfigModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.AsyncJobResponseStatusJsonConverter),

            typeof(global::Reducto.JsonConverters.AsyncJobResponseStatusNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.BaseProcessingOptionsOcrModeJsonConverter),

            typeof(global::Reducto.JsonConverters.BaseProcessingOptionsOcrModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.BaseProcessingOptionsExtractionModeJsonConverter),

            typeof(global::Reducto.JsonConverters.BaseProcessingOptionsExtractionModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.BaseProcessingOptionsFilterBlockJsonConverter),

            typeof(global::Reducto.JsonConverters.BaseProcessingOptionsFilterBlockNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ChunkingChunkModeJsonConverter),

            typeof(global::Reducto.JsonConverters.ChunkingChunkModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ChunkingConfigChunkModeJsonConverter),

            typeof(global::Reducto.JsonConverters.ChunkingConfigChunkModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.CriteriaConfidenceConfidenceJsonConverter),

            typeof(global::Reducto.JsonConverters.CriteriaConfidenceConfidenceNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.DeepSplitPageEvidenceConfidence2JsonConverter),

            typeof(global::Reducto.JsonConverters.DeepSplitPageEvidenceConfidence2NullableJsonConverter),

            typeof(global::Reducto.JsonConverters.EditOptionsLlmProviderPreference2JsonConverter),

            typeof(global::Reducto.JsonConverters.EditOptionsLlmProviderPreference2NullableJsonConverter),

            typeof(global::Reducto.JsonConverters.EditWidgetTypeJsonConverter),

            typeof(global::Reducto.JsonConverters.EditWidgetTypeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.EnhancedAsyncJobResponseStatusJsonConverter),

            typeof(global::Reducto.JsonConverters.EnhancedAsyncJobResponseStatusNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.EnhancedAsyncJobResponseType2JsonConverter),

            typeof(global::Reducto.JsonConverters.EnhancedAsyncJobResponseType2NullableJsonConverter),

            typeof(global::Reducto.JsonConverters.EnrichConfigModeJsonConverter),

            typeof(global::Reducto.JsonConverters.EnrichConfigModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ExperimentalProcessingOptionsLayoutModelJsonConverter),

            typeof(global::Reducto.JsonConverters.ExperimentalProcessingOptionsLayoutModelNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ExtractConfigOptionsExtractAlgorithmJsonConverter),

            typeof(global::Reducto.JsonConverters.ExtractConfigOptionsExtractAlgorithmNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ExtractUsageExtractMode2JsonConverter),

            typeof(global::Reducto.JsonConverters.ExtractUsageExtractMode2NullableJsonConverter),

            typeof(global::Reducto.JsonConverters.FormattingTableOutputFormatJsonConverter),

            typeof(global::Reducto.JsonConverters.FormattingTableOutputFormatNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.FormattingIncludeItemJsonConverter),

            typeof(global::Reducto.JsonConverters.FormattingIncludeItemNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ParseBlockTypeJsonConverter),

            typeof(global::Reducto.JsonConverters.ParseBlockTypeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsVersionJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsVersionNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsPdfOcrJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsPdfOcrNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsOcrSystemJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsOcrSystemNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsOcrModeJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsOcrModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsTableOutputFormatJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsTableOutputFormatNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsChunkModeJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsChunkModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsModeJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsEnrichModeJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsEnrichModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsIgnoreBlockJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsIgnoreBlockNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsCustomFormatJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsCustomFormatNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetTableClusteringJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetTableClusteringNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetLoader2JsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetLoader2NullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsLayoutModelJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsLayoutModelNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsAgenticTextThinkingLevelJsonConverter),

            typeof(global::Reducto.JsonConverters.ProcessingOptionsAgenticTextThinkingLevelNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.QueuePriorityJsonConverter),

            typeof(global::Reducto.JsonConverters.QueuePriorityNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.RetrievalFilterBlockJsonConverter),

            typeof(global::Reducto.JsonConverters.RetrievalFilterBlockNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SettingsOcrSystemJsonConverter),

            typeof(global::Reducto.JsonConverters.SettingsOcrSystemNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SettingsExtractionModeJsonConverter),

            typeof(global::Reducto.JsonConverters.SettingsExtractionModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SettingsReturnImageJsonConverter),

            typeof(global::Reducto.JsonConverters.SettingsReturnImageNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SingleJobStatusJsonConverter),

            typeof(global::Reducto.JsonConverters.SingleJobStatusNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SingleJobTypeJsonConverter),

            typeof(global::Reducto.JsonConverters.SingleJobTypeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitConfJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitConfNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitOptionsTableCutoffJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitOptionsTableCutoffNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitPartitionConfJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitPartitionConfNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitTableOptionsTableCutoffJsonConverter),

            typeof(global::Reducto.JsonConverters.SplitTableOptionsTableCutoffNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SpreadsheetIncludeItemJsonConverter),

            typeof(global::Reducto.JsonConverters.SpreadsheetIncludeItemNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SpreadsheetClusteringJsonConverter),

            typeof(global::Reducto.JsonConverters.SpreadsheetClusteringNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.SpreadsheetExcludeItemJsonConverter),

            typeof(global::Reducto.JsonConverters.SpreadsheetExcludeItemNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.WebhookConfigModeJsonConverter),

            typeof(global::Reducto.JsonConverters.WebhookConfigModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.WebhookConfigNewModeJsonConverter),

            typeof(global::Reducto.JsonConverters.WebhookConfigNewModeNullableJsonConverter),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, object>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.FullResult, global::Reducto.UrlResult>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::System.Collections.Generic.IList<global::Reducto.ParseResponse>, object>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse, object>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<int?, global::Reducto.SplitLargeTableSizes>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.SplitResult, global::Reducto.DeepSplitResult>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.SvixWebhookConfig, global::Reducto.DirectWebhookConfig, object>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>),

            typeof(global::Reducto.JsonConverters.OneOfJsonConverter<global::Reducto.SyncParseConfig, global::Reducto.AsyncParseConfig>),

            typeof(global::Reducto.JsonConverters.OneOfJsonConverter<global::Reducto.SyncExtractConfig, global::Reducto.AsyncExtractConfig>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>),

            typeof(global::Reducto.JsonConverters.OneOfJsonConverter<global::Reducto.V3ExtractResponse, global::Reducto.AsyncExtractResponse>),

            typeof(global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.AsyncJobResponse, global::Reducto.EnhancedAsyncJobResponse>),

            typeof(global::Reducto.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AdvancedCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AdvancedProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AdvancedProcessingOptionsOcrSystem), TypeInfoPropertyName = "AdvancedProcessingOptionsOcrSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AdvancedProcessingOptionsTableOutputFormat), TypeInfoPropertyName = "AdvancedProcessingOptionsTableOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfPageRange3IListPageRange3IListInt32IListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.PageRange3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.PageRange3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.LargeTableChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering), TypeInfoPropertyName = "AdvancedProcessingOptionsSpreadsheetTableClustering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AgentExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AgentInTheLoop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AgenticTablesOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ArrayExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ArrayExtractConfigMode), TypeInfoPropertyName = "ArrayExtractConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncEditConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<string, global::Reducto.UploadResponse>), TypeInfoPropertyName = "AnyOfStringUploadResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.UploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EditOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.EditWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EditWidget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.WebhookConfigNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ConfigV3AsyncConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>), TypeInfoPropertyName = "AnyOfStringIListStringUploadResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Instructions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncExtractConfigNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.BaseProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExperimentalProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncExtractResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncJobResponseStatus), TypeInfoPropertyName = "AsyncJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>), TypeInfoPropertyName = "AnyOfParseResponseExtractResponseSplitResponseEditResponsePipelineResponseV3ExtractResponseClassifyResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.PipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.V3ExtractResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ClassifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncParseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Enhance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Retrieval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Formatting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Spreadsheet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Settings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.QueuePriority), TypeInfoPropertyName = "QueuePriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncParseConfigNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncParseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncPipelineConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.PipelineSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AsyncSplitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.BaseProcessingOptionsOcrMode), TypeInfoPropertyName = "BaseProcessingOptionsOcrMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.BaseProcessingOptionsExtractionMode), TypeInfoPropertyName = "BaseProcessingOptionsExtractionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.TableSummaryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.FigureSummaryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.BaseProcessingOptionsFilterBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.BaseProcessingOptionsFilterBlock), TypeInfoPropertyName = "BaseProcessingOptionsFilterBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.BodyUploadUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.BoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.CategoryConfidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.CriteriaConfidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.CriteriaConfidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Chunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ChunkingChunkMode), TypeInfoPropertyName = "ChunkingChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ChunkingConfigChunkMode), TypeInfoPropertyName = "ChunkingConfigChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Citations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ClassificationCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ClassifyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.ClassificationCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, object>), TypeInfoPropertyName = "AnyOfPageRange3IListPageRange3IListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ClassifyResponseCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ResponseConfidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.CriteriaConfidenceConfidence), TypeInfoPropertyName = "CriteriaConfidenceConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.CustomerQueueOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.DeepSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.DeepSplitPageEvidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.DeepSplitPageEvidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.DeepSplitPartition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.DeepSplitPartition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.DeepSplitPageEvidenceConfidence2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.DeepSplitResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.DeepSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.DirectWebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EditConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EditOptionsLlmProviderPreference2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EditWidgetType), TypeInfoPropertyName = "EditWidgetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>), TypeInfoPropertyName = "AnyOfTableAgenticFigureAgenticTextAgentic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.TableAgentic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.FigureAgentic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.TextAgentic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EnhancedAsyncJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EnhancedAsyncJobResponseStatus), TypeInfoPropertyName = "EnhancedAsyncJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EnhancedAsyncJobResponseType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EnrichConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.EnrichConfigMode), TypeInfoPropertyName = "EnrichConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExperimentalProcessingOptionsLayoutModel), TypeInfoPropertyName = "ExperimentalProcessingOptionsLayoutModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractAlpha))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractCitationsOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractConfigOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ConfigInternalAsyncConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractConfigNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractConfigOptionsExtractAlgorithm), TypeInfoPropertyName = "ExtractConfigOptionsExtractAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractSplitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse>), TypeInfoPropertyName = "AnyOfExtractResponseV3ExtractResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ExtractUsageExtractMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.FormattingTableOutputFormat), TypeInfoPropertyName = "FormattingTableOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.FormattingIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.FormattingIncludeItem), TypeInfoPropertyName = "FormattingIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.FullResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.ParseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.OCRResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.GranularConfidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.JobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.SingleJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SingleJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.KeyValueOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.LayoutAgentic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.OCRLine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.OCRWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.OCRWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.OCRLine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseAlpha))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseBlockType), TypeInfoPropertyName = "ParseBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.ParseBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ParseConfigNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.FullResult, global::Reducto.UrlResult>), TypeInfoPropertyName = "AnyOfFullResultUrlResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.UrlResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.PipelineConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.PipelineResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.ParseResponse, global::System.Collections.Generic.IList<global::Reducto.ParseResponse>, object>), TypeInfoPropertyName = "AnyOfParseResponseIListParseResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.ParseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse, object>), TypeInfoPropertyName = "AnyOfIListExtractSplitResponseExtractResponseV3ExtractResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsVersion), TypeInfoPropertyName = "ProcessingOptionsVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsPdfOcr), TypeInfoPropertyName = "ProcessingOptionsPdfOcr2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsOcrSystem), TypeInfoPropertyName = "ProcessingOptionsOcrSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsOcrMode), TypeInfoPropertyName = "ProcessingOptionsOcrMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsTableOutputFormat), TypeInfoPropertyName = "ProcessingOptionsTableOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsChunkMode), TypeInfoPropertyName = "ProcessingOptionsChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsMode), TypeInfoPropertyName = "ProcessingOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsEnrichMode), TypeInfoPropertyName = "ProcessingOptionsEnrichMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.ProcessingOptionsIgnoreBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsIgnoreBlock), TypeInfoPropertyName = "ProcessingOptionsIgnoreBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsCustomFormat), TypeInfoPropertyName = "ProcessingOptionsCustomFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsSpreadsheetTableClustering), TypeInfoPropertyName = "ProcessingOptionsSpreadsheetTableClustering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsSpreadsheetLoader2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsLayoutModel), TypeInfoPropertyName = "ProcessingOptionsLayoutModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOptionsAgenticTextThinkingLevel), TypeInfoPropertyName = "ProcessingOptionsAgenticTextThinkingLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ProcessingOverridesBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.CategoryConfidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.RetrievalFilterBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.RetrievalFilterBlock), TypeInfoPropertyName = "RetrievalFilterBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SettingsOcrSystem), TypeInfoPropertyName = "SettingsOcrSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SettingsExtractionMode), TypeInfoPropertyName = "SettingsExtractionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.SettingsReturnImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SettingsReturnImage), TypeInfoPropertyName = "SettingsReturnImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfPageRange3IListPageRange3IListInt32IListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SingleJobStatus), TypeInfoPropertyName = "SingleJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SingleJobType), TypeInfoPropertyName = "SingleJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.Split))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitConf), TypeInfoPropertyName = "SplitConf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.SplitPartition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitPartition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitAlpha))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitLargeTableSizes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitLargeTables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<int?, global::Reducto.SplitLargeTableSizes>), TypeInfoPropertyName = "AnyOfInt32SplitLargeTableSizes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitOptionsTableCutoff), TypeInfoPropertyName = "SplitOptionsTableCutoff2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitPartitionConf), TypeInfoPropertyName = "SplitPartitionConf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.SplitResult, global::Reducto.DeepSplitResult>), TypeInfoPropertyName = "AnyOfSplitResultDeepSplitResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.Split>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitTableOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SplitTableOptionsTableCutoff), TypeInfoPropertyName = "SplitTableOptionsTableCutoff2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.SpreadsheetIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SpreadsheetIncludeItem), TypeInfoPropertyName = "SpreadsheetIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SpreadsheetClustering), TypeInfoPropertyName = "SpreadsheetClustering2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.SpreadsheetExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SpreadsheetExcludeItem), TypeInfoPropertyName = "SpreadsheetExcludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SvixWebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SyncExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SyncParseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.SyncSplitConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.V3AsyncPipelineConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<object, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.V3PipelineConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reducto.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.WebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.WebhookConfigMode), TypeInfoPropertyName = "WebhookConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.WebhookConfigNewMode), TypeInfoPropertyName = "WebhookConfigNewMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ConfigV2AsyncSplitConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.SvixWebhookConfig, global::Reducto.DirectWebhookConfig, object>), TypeInfoPropertyName = "AnyOfSvixWebhookConfigDirectWebhookConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.ConfigV3AsyncSplitConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.OneOf<global::Reducto.SyncParseConfig, global::Reducto.AsyncParseConfig>), TypeInfoPropertyName = "OneOfSyncParseConfigAsyncParseConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.OneOf<global::Reducto.SyncExtractConfig, global::Reducto.AsyncExtractConfig>), TypeInfoPropertyName = "OneOfSyncExtractConfigAsyncExtractConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>), TypeInfoPropertyName = "AnyOfParseResponseAsyncParseResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.OneOf<global::Reducto.V3ExtractResponse, global::Reducto.AsyncExtractResponse>), TypeInfoPropertyName = "OneOfV3ExtractResponseAsyncExtractResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.AsyncJobResponse, global::Reducto.EnhancedAsyncJobResponse>), TypeInfoPropertyName = "AnyOfAsyncJobResponseEnhancedAsyncJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.List<global::Reducto.PageRange3>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.PageRange3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.EditWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<string, global::System.Collections.Generic.List<string>, global::Reducto.UploadResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.BaseProcessingOptionsFilterBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.CriteriaConfidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.ClassificationCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.List<global::Reducto.PageRange3>, global::System.Collections.Generic.List<int>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.DeepSplitPageEvidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.DeepSplitPartition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.DeepSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.FormattingIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.ParseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.SingleJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.OCRWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.OCRLine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.ParseBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.ParseResponse, global::System.Collections.Generic.List<global::Reducto.ParseResponse>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.ParseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::System.Collections.Generic.List<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.ExtractSplitResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.ProcessingOptionsIgnoreBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.CategoryConfidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.RetrievalFilterBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.SettingsReturnImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.List<global::Reducto.PageRange3>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.SplitPartition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.Split>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.SpreadsheetIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.SpreadsheetExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reducto.AnyOf<object, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reducto.AnyOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}