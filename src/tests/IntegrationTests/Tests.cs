namespace Reducto.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ReductoClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REDUCTO_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("REDUCTO_API_KEY environment variable is not found.");

        var client = new ReductoClient(apiKey);
        
        return client;
    }
}
