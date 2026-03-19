# List Engines



This example assumes `using StabilityAI;` is in scope and `apiKey` contains your StabilityAI API key.

```csharp
using var client = new StabilityAIClient(apiKey);

// Discover available engines before generating images
var engines = await client.V1Engines.ListEnginesAsync();

foreach (var engine in engines)
{
    Console.WriteLine($"{engine.Id}: {engine.Name} ({engine.Type})");
    Console.WriteLine($"  {engine.Description}");
}
```