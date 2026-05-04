# Generate with Stable Diffusion 3.5



This example assumes `using StabilityAI;` is in scope and `apiKey` contains your StabilityAI API key.

```csharp
using var client = new StabilityAIClient(apiKey);

var response = await client.Generate.CreateStableImageGenerateSd3Async(
    contentType: "multipart/form-data",
    accept: CreateStableImageGenerateSd3Accept.ApplicationJson,
    request: new CreateStableImageGenerateSd3Request
    {
        Prompt = "A crisp studio product photo of a ceramic espresso cup on a slate table",
        Model = CreateStableImageGenerateSd3RequestModel.Sd35Large,
        AspectRatio = CreateStableImageGenerateSd3RequestAspectRatio.x1_1,
        OutputFormat = CreateStableImageGenerateSd3RequestOutputFormat.Png,
    });

Console.WriteLine($"Seed: {response.Seed}");
Console.WriteLine($"Base64 bytes: {response.Image.Length}");
```