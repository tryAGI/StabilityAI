# Text to Image



This example assumes `using StabilityAI;` is in scope and `apiKey` contains your StabilityAI API key.

```csharp
using var client = new StabilityAIClient(apiKey);

var images = await client.V1Generation.TextToImageAsync(
    engineId: "stable-diffusion-v1-6",
    request: new TextToImageRequestBody(
        value1: new TextToImageRequestBodyVariant1
        {
            TextPrompts =
            [
                new TextPrompt
                {
                    Text = "A beautiful sunset over mountains, digital art",
                    Weight = 1.0f,
                },
            ],
            Height = 512,
            Width = 512,
        },
        value2: new GenerationRequestOptionalParams
        {
            Samples = 1,
        }));

foreach (var image in images)
{
    Console.WriteLine($"Seed: {image.Seed}, Finish reason: {image.FinishReason}");

    // image.Base64 contains the generated image data
    var bytes = Convert.FromBase64String(image.Base64!);
    await File.WriteAllBytesAsync($"output_{image.Seed}.png", bytes);
}
```