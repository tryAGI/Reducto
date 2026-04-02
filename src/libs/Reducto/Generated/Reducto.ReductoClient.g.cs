
#nullable enable

namespace Reducto
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ReductoClient : global::Reducto.IReductoClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://platform.reducto.ai";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Reducto.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Reducto.JsonConverters.AdvancedProcessingOptionsOcrSystemJsonConverter(),
                    new global::Reducto.JsonConverters.AdvancedProcessingOptionsOcrSystemNullableJsonConverter(),
                    new global::Reducto.JsonConverters.AdvancedProcessingOptionsTableOutputFormatJsonConverter(),
                    new global::Reducto.JsonConverters.AdvancedProcessingOptionsTableOutputFormatNullableJsonConverter(),
                    new global::Reducto.JsonConverters.AdvancedProcessingOptionsSpreadsheetTableClusteringJsonConverter(),
                    new global::Reducto.JsonConverters.AdvancedProcessingOptionsSpreadsheetTableClusteringNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ArrayExtractConfigModeJsonConverter(),
                    new global::Reducto.JsonConverters.ArrayExtractConfigModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.AsyncJobResponseStatusJsonConverter(),
                    new global::Reducto.JsonConverters.AsyncJobResponseStatusNullableJsonConverter(),
                    new global::Reducto.JsonConverters.BaseProcessingOptionsOcrModeJsonConverter(),
                    new global::Reducto.JsonConverters.BaseProcessingOptionsOcrModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.BaseProcessingOptionsExtractionModeJsonConverter(),
                    new global::Reducto.JsonConverters.BaseProcessingOptionsExtractionModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.BaseProcessingOptionsFilterBlockJsonConverter(),
                    new global::Reducto.JsonConverters.BaseProcessingOptionsFilterBlockNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ChunkingChunkModeJsonConverter(),
                    new global::Reducto.JsonConverters.ChunkingChunkModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ChunkingConfigChunkModeJsonConverter(),
                    new global::Reducto.JsonConverters.ChunkingConfigChunkModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.CriteriaConfidenceConfidenceJsonConverter(),
                    new global::Reducto.JsonConverters.CriteriaConfidenceConfidenceNullableJsonConverter(),
                    new global::Reducto.JsonConverters.DeepSplitPageEvidenceConfidence2JsonConverter(),
                    new global::Reducto.JsonConverters.DeepSplitPageEvidenceConfidence2NullableJsonConverter(),
                    new global::Reducto.JsonConverters.EditOptionsLlmProviderPreference2JsonConverter(),
                    new global::Reducto.JsonConverters.EditOptionsLlmProviderPreference2NullableJsonConverter(),
                    new global::Reducto.JsonConverters.EditWidgetTypeJsonConverter(),
                    new global::Reducto.JsonConverters.EditWidgetTypeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.EnhancedAsyncJobResponseStatusJsonConverter(),
                    new global::Reducto.JsonConverters.EnhancedAsyncJobResponseStatusNullableJsonConverter(),
                    new global::Reducto.JsonConverters.EnhancedAsyncJobResponseType2JsonConverter(),
                    new global::Reducto.JsonConverters.EnhancedAsyncJobResponseType2NullableJsonConverter(),
                    new global::Reducto.JsonConverters.EnrichConfigModeJsonConverter(),
                    new global::Reducto.JsonConverters.EnrichConfigModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ExperimentalProcessingOptionsLayoutModelJsonConverter(),
                    new global::Reducto.JsonConverters.ExperimentalProcessingOptionsLayoutModelNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ExtractConfigOptionsExtractAlgorithmJsonConverter(),
                    new global::Reducto.JsonConverters.ExtractConfigOptionsExtractAlgorithmNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ExtractUsageExtractMode2JsonConverter(),
                    new global::Reducto.JsonConverters.ExtractUsageExtractMode2NullableJsonConverter(),
                    new global::Reducto.JsonConverters.FormattingTableOutputFormatJsonConverter(),
                    new global::Reducto.JsonConverters.FormattingTableOutputFormatNullableJsonConverter(),
                    new global::Reducto.JsonConverters.FormattingIncludeItemJsonConverter(),
                    new global::Reducto.JsonConverters.FormattingIncludeItemNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ParseBlockTypeJsonConverter(),
                    new global::Reducto.JsonConverters.ParseBlockTypeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsVersionJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsVersionNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsPdfOcrJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsPdfOcrNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsOcrSystemJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsOcrSystemNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsOcrModeJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsOcrModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsTableOutputFormatJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsTableOutputFormatNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsChunkModeJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsChunkModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsModeJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsEnrichModeJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsEnrichModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsIgnoreBlockJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsIgnoreBlockNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsCustomFormatJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsCustomFormatNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetTableClusteringJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetTableClusteringNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetLoader2JsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsSpreadsheetLoader2NullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsLayoutModelJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsLayoutModelNullableJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsAgenticTextThinkingLevelJsonConverter(),
                    new global::Reducto.JsonConverters.ProcessingOptionsAgenticTextThinkingLevelNullableJsonConverter(),
                    new global::Reducto.JsonConverters.QueuePriorityJsonConverter(),
                    new global::Reducto.JsonConverters.QueuePriorityNullableJsonConverter(),
                    new global::Reducto.JsonConverters.RetrievalFilterBlockJsonConverter(),
                    new global::Reducto.JsonConverters.RetrievalFilterBlockNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SettingsOcrSystemJsonConverter(),
                    new global::Reducto.JsonConverters.SettingsOcrSystemNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SettingsExtractionModeJsonConverter(),
                    new global::Reducto.JsonConverters.SettingsExtractionModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SettingsReturnImageJsonConverter(),
                    new global::Reducto.JsonConverters.SettingsReturnImageNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SingleJobStatusJsonConverter(),
                    new global::Reducto.JsonConverters.SingleJobStatusNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SingleJobTypeJsonConverter(),
                    new global::Reducto.JsonConverters.SingleJobTypeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SplitConfJsonConverter(),
                    new global::Reducto.JsonConverters.SplitConfNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SplitOptionsTableCutoffJsonConverter(),
                    new global::Reducto.JsonConverters.SplitOptionsTableCutoffNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SplitPartitionConfJsonConverter(),
                    new global::Reducto.JsonConverters.SplitPartitionConfNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SplitTableOptionsTableCutoffJsonConverter(),
                    new global::Reducto.JsonConverters.SplitTableOptionsTableCutoffNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SpreadsheetIncludeItemJsonConverter(),
                    new global::Reducto.JsonConverters.SpreadsheetIncludeItemNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SpreadsheetClusteringJsonConverter(),
                    new global::Reducto.JsonConverters.SpreadsheetClusteringNullableJsonConverter(),
                    new global::Reducto.JsonConverters.SpreadsheetExcludeItemJsonConverter(),
                    new global::Reducto.JsonConverters.SpreadsheetExcludeItemNullableJsonConverter(),
                    new global::Reducto.JsonConverters.WebhookConfigModeJsonConverter(),
                    new global::Reducto.JsonConverters.WebhookConfigModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.WebhookConfigNewModeJsonConverter(),
                    new global::Reducto.JsonConverters.WebhookConfigNewModeNullableJsonConverter(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, object>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse, object>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.FullResult, global::Reducto.UrlResult>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::System.Collections.Generic.IList<global::Reducto.ParseResponse>, object>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse, object>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>, object>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<int?, global::Reducto.SplitLargeTableSizes>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.SplitResult, global::Reducto.DeepSplitResult>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.SvixWebhookConfig, global::Reducto.DirectWebhookConfig, object>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>(),
                    new global::Reducto.JsonConverters.OneOfJsonConverter<global::Reducto.SyncParseConfig, global::Reducto.AsyncParseConfig>(),
                    new global::Reducto.JsonConverters.OneOfJsonConverter<global::Reducto.SyncExtractConfig, global::Reducto.AsyncExtractConfig>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>(),
                    new global::Reducto.JsonConverters.OneOfJsonConverter<global::Reducto.V3ExtractResponse, global::Reducto.AsyncExtractResponse>(),
                    new global::Reducto.JsonConverters.AnyOfJsonConverter<global::Reducto.AsyncJobResponse, global::Reducto.EnhancedAsyncJobResponse>(),
                    new global::Reducto.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Creates a new instance of the ReductoClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ReductoClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Reducto.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Reducto.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}