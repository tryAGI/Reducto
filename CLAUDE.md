# CLAUDE.md -- Reducto SDK

## Overview

Auto-generated C# SDK for [Reducto](https://reducto.ai/) -- AI-powered document parsing, extraction, splitting, editing, classification, and pipeline processing.
OpenAPI spec from Stainless-hosted YAML (resolved via `reductoai/reducto-python-sdk/.stats.yml`).

## Build & Test

```bash
dotnet build Reducto.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard HTTP Bearer token. Constructor accepts API key directly:

```csharp
var client = new ReductoClient(apiKey); // REDUCTO_API_KEY env var
```

## Key Files

- `src/libs/Reducto/openapi.yaml` -- Stainless-hosted OpenAPI 3.1.0 spec
- `src/libs/Reducto/generate.sh` -- Downloads spec and runs autosdk generate
- `src/libs/Reducto/Generated/` -- **Never edit** -- auto-generated code (696 files)
- `src/libs/Reducto/Extensions/ReductoClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Endpoints

```csharp
var client = new ReductoClient(apiKey);

// Document Processing (sync)
client.ParseParsePostAsync(config)               // Parse document to structured content
client.ExtractExtractPostAsync(config)            // Extract structured data with instructions
client.SplitSplitPostAsync(config)                // Split document into segments
client.EditEditPostAsync(config)                  // Edit/annotate documents
client.ClassifyClassifyPostAsync(config)          // Classify documents into categories
client.PipelinePipelinePostAsync(config)          // Execute multi-step processing pipelines

// Document Processing (async)
client.AsyncParseParseAsyncPostAsync(config)      // Async parse
client.ExtractAsyncExtractAsyncPostAsync(config)  // Async extract
client.SplitAsyncSplitAsyncPostAsync(config)      // Async split
client.EditAsyncEditAsyncPostAsync(config)        // Async edit
client.PipelineAsyncPipelineAsyncPostAsync(config)// Async pipeline

// Job Management
client.RetrieveParseJobJobIdGetAsync(jobId)       // Get job status/results
client.CancelJobCancelJobIdPostAsync(jobId)       // Cancel running job
client.GetJobsJobsGetAsync()                      // List jobs

// Utilities
client.UploadUploadPostAsync(file)                // Upload document
client.WebhookPortalConfigureWebhookPostAsync()   // Configure webhooks
client.GetVersionVersionGetAsync()                // Get API version
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsParseDocumentTool()` -- Parse a document URL to extract structured content
- `AsExtractDataTool()` -- Extract structured data using natural language instructions
- `AsClassifyDocumentTool()` -- Classify a document into categories
- `AsGetJobStatusTool()` -- Get async job status and results
- `AsListJobsTool()` -- List recent document processing jobs
- `AsCancelJobTool()` -- Cancel a running async job

## Spec Notes

- Base URL: `https://platform.reducto.ai`
- Auth: HTTP Bearer (`SkippableHTTPBearer` in spec, overridden with `--security-scheme Http:Header:Bearer`)
- Spec version: OpenAPI 3.1.0 (Stainless-generated)
- 17 endpoints across document processing, job management, and utilities
- Sync endpoints return results directly; async endpoints return job IDs for polling
