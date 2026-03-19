/*
order: 5
title: List Engines
slug: list-engines
*/

namespace StabilityAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListEngines()
    {
        using var client = GetAuthenticatedClient();

        //// Discover available engines before generating images
        var engines = await client.V1Engines.ListEnginesAsync();

        foreach (var engine in engines)
        {
            Console.WriteLine($"{engine.Id}: {engine.Name} ({engine.Type})");
            Console.WriteLine($"  {engine.Description}");
        }
    }
}
