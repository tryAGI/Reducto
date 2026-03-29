/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace Reducto.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// Reducto provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios. These tools enable AI agents to parse,
    //// extract, classify, and manage document processing jobs.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REDUCTO_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("REDUCTO_API_KEY environment variable is not found.");

        using var client = new ReductoClient(apiKey);

        //// Create tools for document parsing, extraction, classification, and job management.
        var parseDocumentTool = client.AsParseDocumentTool();
        var extractDataTool = client.AsExtractDataTool();
        var classifyDocumentTool = client.AsClassifyDocumentTool();
        var getJobStatusTool = client.AsGetJobStatusTool();
        var listJobsTool = client.AsListJobsTool();
        var cancelJobTool = client.AsCancelJobTool();

        Assert.AreEqual("Reducto_ParseDocument", parseDocumentTool.Name);
        Assert.AreEqual("Reducto_ExtractData", extractDataTool.Name);
        Assert.AreEqual("Reducto_ClassifyDocument", classifyDocumentTool.Name);
        Assert.AreEqual("Reducto_GetJobStatus", getJobStatusTool.Name);
        Assert.AreEqual("Reducto_ListJobs", listJobsTool.Name);
        Assert.AreEqual("Reducto_CancelJob", cancelJobTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[]
        {
            parseDocumentTool,
            extractDataTool,
            classifyDocumentTool,
            getJobStatusTool,
            listJobsTool,
            cancelJobTool,
        };
        Assert.AreEqual(6, tools.Length);
    }
}
