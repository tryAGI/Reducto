/* order: 10, title: Document Parsing, slug: document-parsing */

namespace Reducto.IntegrationTests.Examples;

[TestClass]
public class DocumentParsing
{
    //// Reducto provides powerful document parsing capabilities that extract structured
    //// content from PDFs, images, spreadsheets, and other document types.

    [TestMethod]
    public async Task ParseDocument()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REDUCTO_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("REDUCTO_API_KEY environment variable is not found.");

        using var client = new ReductoClient(apiKey);

        //// Parse a document from a URL to extract structured content.
        var response = await client.ParseParsePostAsync(
            request: new SyncParseConfig
            {
                Input = "https://arxiv.org/pdf/2310.06825",
            });

        //// The response contains chunks of extracted content including text, tables, and figures.
        var parseResult = response.Value1;
        Assert.IsNotNull(parseResult);
        Assert.IsNotNull(parseResult.JobId);
    }

    [TestMethod]
    public async Task ExtractData()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REDUCTO_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("REDUCTO_API_KEY environment variable is not found.");

        using var client = new ReductoClient(apiKey);

        //// Extract structured data from a document using natural language instructions.
        var response = await client.ExtractExtractPostAsync(
            request: new SyncExtractConfig
            {
                Input = "https://arxiv.org/pdf/2310.06825",
                Instructions = new Instructions
                {
                    SystemPrompt = "Extract the title, authors, and abstract of this paper.",
                },
            });

        //// The response contains the extracted data matching your instructions.
        var extractResult = response.Value1;
        Assert.IsNotNull(extractResult);
    }
}
