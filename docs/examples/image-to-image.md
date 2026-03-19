# Image to Image



This example assumes `using StabilityAI;` is in scope and `apiKey` contains your StabilityAI API key.

```csharp
using var client = new StabilityAIClient(apiKey);

// Load the source image
var initImageBytes = await File.ReadAllBytesAsync("input.png");

var images = await client.V1Generation.ImageToImageAsync(
    engineId: "stable-diffusion-v1-6",
    request: new ImageToImageRequestBody
    {
        TextPrompts =
        [
            new TextPrompt
            {
                Text = "A fantasy castle on a cliff, dramatic lighting",
                Weight = 1.0,
            },
        ],
        InitImage = initImageBytes,
        InitImagename = "input.png",
        ImageStrength = 0.35f, // Lower = closer to original, higher = more creative
        Samples = 1,
    });

foreach (var image in images)
{
    Console.WriteLine($"Seed: {image.Seed}, Finish reason: {image.FinishReason}");

    var bytes = Convert.FromBase64String(image.Base64);
    await File.WriteAllBytesAsync($"output_{image.Seed}.png", bytes);
}
```
