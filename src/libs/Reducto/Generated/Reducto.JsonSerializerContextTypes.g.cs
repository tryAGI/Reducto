
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Reducto
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AdvancedCitationsConfig? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AdvancedProcessingOptions? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AdvancedProcessingOptionsOcrSystem? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AdvancedProcessingOptionsTableOutputFormat? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.PageRange3? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.PageRange3>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.LargeTableChunkingConfig? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AdvancedProcessingOptionsSpreadsheetTableClustering? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AgentExtractConfig? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AgentInTheLoop? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AgenticTablesOverrides? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ArrayExtractConfig? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ArrayExtractConfigMode? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncEditConfig? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<string, global::Reducto.UploadResponse>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.UploadResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EditOptions? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.EditWidget>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EditWidget? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.WebhookConfigNew? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncEditResponse? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncExtractConfig? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ConfigV3AsyncConfig? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Reducto.UploadResponse>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseOptions? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Instructions? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractSettings? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncExtractConfigNew? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.BaseProcessingOptions? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExperimentalProcessingOptions? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncExtractResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncJobResponse? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncJobResponseStatus? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.ExtractResponse, global::Reducto.SplitResponse, global::Reducto.EditResponse, global::Reducto.PipelineResponse, global::Reducto.V3ExtractResponse, global::Reducto.ClassifyResponse>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseResponse? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractResponse? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitResponse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EditResponse? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.PipelineResponse? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.V3ExtractResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ClassifyResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncParseConfig? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Enhance? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Retrieval? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Formatting? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Spreadsheet? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Settings? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.QueuePriority? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncParseConfigNew? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncParseResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncPipelineConfig? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.PipelineSettings? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncPipelineResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AsyncSplitResponse? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.BaseProcessingOptionsOcrMode? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.BaseProcessingOptionsExtractionMode? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ChunkingConfig? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.TableSummaryConfig? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.FigureSummaryConfig? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.BaseProcessingOptionsFilterBlock>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.BaseProcessingOptionsFilterBlock? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.BodyUploadUploadPost? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.BoundingBox? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.CategoryConfidence? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.CriteriaConfidence>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.CriteriaConfidence? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Chunking? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ChunkingChunkMode? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ChunkingConfigChunkMode? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Citations? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ClassificationCategory? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ClassifyConfig? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.ClassificationCategory>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.IList<global::Reducto.PageRange3>, global::System.Collections.Generic.IList<int>>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ClassifyResponseCategory? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ResponseConfidence? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.CriteriaConfidenceConfidence? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.CustomerQueueOverrides? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.DeepSplit? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.DeepSplitPageEvidence>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.DeepSplitPageEvidence? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.DeepSplitPartition>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.DeepSplitPartition? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.DeepSplitPageEvidenceConfidence? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.DeepSplitResult? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.DeepSplit>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.DirectWebhookConfig? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EditConfig? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EditOptionsLlmProviderPreference? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseUsage? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EditWidgetType? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.TableAgentic? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.FigureAgentic? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.TextAgentic? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EnhancedAsyncJobResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EnhancedAsyncJobResponseStatus? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EnhancedAsyncJobResponseType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EnrichConfig? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.EnrichConfigMode? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExperimentalProcessingOptionsLayoutModel? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractAlpha? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractCitationsOverrides? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractConfig? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptions? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractConfigOptions? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ConfigInternalAsyncConfig? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractConfigNew? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractConfigOptionsExtractAlgorithm? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractUsage? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractSplitResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ExtractUsageExtractMode? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.FormattingTableOutputFormat? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.FormattingIncludeItem>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.FormattingIncludeItem? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.FullResult? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.ParseChunk>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseChunk? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.OCRResult? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.GranularConfidence? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.HTTPValidationError? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.ValidationError>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ValidationError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.JobsResponse? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.SingleJob>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SingleJob? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.KeyValueOverrides? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.LayoutAgentic? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.OCRLine? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.OCRWord>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.OCRWord? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.OCRLine>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseAlpha? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOverrides? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseBlock? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseBlockType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.ParseBlock>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseConfig? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ParseConfigNew? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.FullResult, global::Reducto.UrlResult>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.UrlResult? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.PipelineConfig? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.PipelineResult? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.ParseResponse, global::System.Collections.Generic.IList<global::Reducto.ParseResponse>>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.ParseResponse>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.ExtractSplitResponse>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsVersion? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsPdfOcr? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsOcrSystem? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsOcrMode? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsTableOutputFormat? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsChunkMode? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsMode? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsEnrichMode? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.ProcessingOptionsIgnoreBlock>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsIgnoreBlock? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsCustomFormat? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsSpreadsheetTableClustering? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsSpreadsheetLoader? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsLayoutModel? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOptionsAgenticTextThinkingLevel? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ProcessingOverridesBase? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.CategoryConfidence>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.RetrievalFilterBlock>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.RetrievalFilterBlock? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SettingsOcrSystem? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SettingsExtractionMode? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.SettingsReturnImage>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SettingsReturnImage? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SingleJobStatus? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SingleJobType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.Split? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitConf? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.SplitPartition>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitPartition? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitAlpha? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitCategory? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitConfig? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.SplitCategory>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitOptions? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitLargeTableSizes? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitLargeTables? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<int?, global::Reducto.SplitLargeTableSizes>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitOptionsTableCutoff? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitPartitionConf? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.SplitResult, global::Reducto.DeepSplitResult>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitResult? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.Split>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitTableOptions? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SplitTableOptionsTableCutoff? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.SpreadsheetIncludeItem>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SpreadsheetIncludeItem? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SpreadsheetClustering? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.SpreadsheetExcludeItem>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SpreadsheetExcludeItem? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SvixWebhookConfig? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SyncExtractConfig? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SyncParseConfig? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.SyncSplitConfig? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.V3AsyncPipelineConfig? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<object, global::System.Collections.Generic.IList<object>>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.V3PipelineConfig? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reducto.AnyOf<string, int?>>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<string, int?>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.WebhookConfig? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.WebhookConfigMode? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.WebhookConfigNewMode? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ConfigV2AsyncSplitConfig? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.SvixWebhookConfig, global::Reducto.DirectWebhookConfig>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.ConfigV3AsyncSplitConfig? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.OneOf<global::Reducto.SyncParseConfig, global::Reducto.AsyncParseConfig>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.OneOf<global::Reducto.SyncExtractConfig, global::Reducto.AsyncExtractConfig>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.ParseResponse, global::Reducto.AsyncParseResponse>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.OneOf<global::Reducto.V3ExtractResponse, global::Reducto.AsyncExtractResponse>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.AsyncJobResponse, global::Reducto.EnhancedAsyncJobResponse>? Type231 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.List<global::Reducto.PageRange3>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<string>>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.PageRange3>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.EditWidget>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<string, global::System.Collections.Generic.List<string>, global::Reducto.UploadResponse>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.BaseProcessingOptionsFilterBlock>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.CriteriaConfidence>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.ClassificationCategory>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.PageRange3, global::System.Collections.Generic.List<global::Reducto.PageRange3>, global::System.Collections.Generic.List<int>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.DeepSplitPageEvidence>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.DeepSplitPartition>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.DeepSplit>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.AnyOf<global::Reducto.TableAgentic, global::Reducto.FigureAgentic, global::Reducto.TextAgentic>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.FormattingIncludeItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.ParseChunk>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.ValidationError>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.SingleJob>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.OCRWord>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.OCRLine>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.ParseBlock>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::Reducto.ParseResponse, global::System.Collections.Generic.List<global::Reducto.ParseResponse>>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.ParseResponse>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<global::System.Collections.Generic.List<global::Reducto.ExtractSplitResponse>, global::Reducto.ExtractResponse, global::Reducto.V3ExtractResponse>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.ExtractSplitResponse>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.ProcessingOptionsIgnoreBlock>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.CategoryConfidence>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.RetrievalFilterBlock>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.SettingsReturnImage>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.SplitPartition>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.SplitCategory>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.Split>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.SpreadsheetIncludeItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.SpreadsheetExcludeItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Reducto.AnyOf<object, global::System.Collections.Generic.List<object>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Reducto.AnyOf<string, int?>>? ListType38 { get; set; }
    }
}