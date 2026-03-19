namespace StabilityAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static StabilityAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("STABILITYAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("STABILITYAI_API_KEY environment variable is not found.");

        var client = new StabilityAIClient(apiKey);
        
        return client;
    }
}
