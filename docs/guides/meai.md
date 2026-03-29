# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Reducto SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models document parsing, extraction, classification, and job management capabilities.

## Available Tools

| Tool | Method | Description |
|------|--------|-------------|
| `Reducto_ParseDocument` | `AsParseDocumentTool()` | Parse a document URL to extract structured content (text, tables, figures) |
| `Reducto_ExtractData` | `AsExtractDataTool()` | Extract structured data from a document using natural language instructions |
| `Reducto_ClassifyDocument` | `AsClassifyDocumentTool()` | Classify a document into categories |
| `Reducto_GetJobStatus` | `AsGetJobStatusTool()` | Retrieve the status and results of an async job |
| `Reducto_ListJobs` | `AsListJobsTool()` | List recent document processing jobs |
| `Reducto_CancelJob` | `AsCancelJobTool()` | Cancel a running async job |

## Usage

```csharp
using Reducto;

var client = new ReductoClient(apiKey);

// Create tools
var tools = new[]
{
    client.AsParseDocumentTool(),
    client.AsExtractDataTool(),
    client.AsClassifyDocumentTool(),
    client.AsGetJobStatusTool(),
    client.AsListJobsTool(),
    client.AsCancelJobTool(),
};

// Pass tools to any IChatClient that supports function calling
```
