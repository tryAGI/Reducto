#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Reducto;

public static class ReductoClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that parses a document from a URL to extract structured content.
    /// Uses synchronous parsing for immediate results.
    /// </summary>
    public static AIFunction AsParseDocumentTool(this ReductoClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The URL of the document to parse. Can be a publicly available URL, presigned S3 URL, or reducto:// URL from upload.")] string documentUrl,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ParseParsePostAsync(
                    request: new SyncParseConfig
                    {
                        Input = documentUrl,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parseResponse = response.Value1;
                return new
                {
                    parseResponse?.JobId,
                    parseResponse?.Duration,
                    parseResponse?.PdfUrl,
                    parseResponse?.StudioLink,
                    Result = parseResponse?.Result.Value1 != null
                        ? new { parseResponse.Result.Value1.Chunks }
                        : (object?)new { Url = parseResponse?.Result.Value2?.Url },
                };
            },
            name: "Reducto_ParseDocument",
            description: "Parse a document from a URL to extract structured content including text blocks, tables, and figures using Reducto's document processing API.");
    }

    /// <summary>
    /// Creates an AIFunction tool that extracts structured data from a document using a JSON schema.
    /// </summary>
    public static AIFunction AsExtractDataTool(this ReductoClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The URL of the document to extract data from.")] string documentUrl,
                   [Description("A system prompt describing what data to extract, e.g., 'Extract all invoice line items with amounts.'")] string systemPrompt,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ExtractExtractPostAsync(
                    request: new SyncExtractConfig
                    {
                        Input = documentUrl,
                        Instructions = new Instructions
                        {
                            SystemPrompt = systemPrompt,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var extractResponse = response.Value1;
                return new
                {
                    extractResponse?.JobId,
                    extractResponse?.StudioLink,
                    extractResponse?.Result,
                };
            },
            name: "Reducto_ExtractData",
            description: "Extract structured data from a document using natural language instructions. Useful for extracting specific fields, tables, or information from invoices, contracts, forms, and other documents.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves the status and result of an async job.
    /// </summary>
    public static AIFunction AsGetJobStatusTool(this ReductoClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The job ID to retrieve status for.")] string jobId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.RetrieveParseJobJobIdGetAsync(
                    jobId: jobId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Reducto_GetJobStatus",
            description: "Retrieve the status and results of an async document processing job by its job ID.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists recent document processing jobs.
    /// </summary>
    public static AIFunction AsListJobsTool(this ReductoClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Maximum number of jobs to return (default 100, max 500).")] int? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetJobsJobsGetAsync(
                    limit: limit,
                    excludeConfigs: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Reducto_ListJobs",
            description: "List recent document processing jobs with their statuses and metadata.");
    }

    /// <summary>
    /// Creates an AIFunction tool that classifies a document into categories.
    /// </summary>
    public static AIFunction AsClassifyDocumentTool(this ReductoClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The URL of the document to classify.")] string documentUrl,
                   [Description("Optional document-level metadata to include in classification prompts.")] string? documentMetadata,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ClassifyClassifyPostAsync(
                    input: documentUrl,
                    documentMetadata: documentMetadata,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Reducto_ClassifyDocument",
            description: "Classify a document into categories using Reducto's AI classification. Returns the document's classification results.");
    }

    /// <summary>
    /// Creates an AIFunction tool that cancels a running async job.
    /// </summary>
    public static AIFunction AsCancelJobTool(this ReductoClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The job ID to cancel.")] string jobId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.CancelJobCancelJobIdPostAsync(
                    jobId: jobId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new { Result = response };
            },
            name: "Reducto_CancelJob",
            description: "Cancel a running async document processing job.");
    }
}
