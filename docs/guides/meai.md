# Microsoft.Extensions.AI Integration

Reducto provides `AIFunction` tools that integrate with the Microsoft.Extensions.AI (MEAI) ecosystem,
enabling AI agents to process documents through function/tool calling with any `IChatClient`.

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
