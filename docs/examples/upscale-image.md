# Upscale Image



This example assumes `using StabilityAI;` is in scope and `apiKey` contains your StabilityAI API key.

```csharp
using var client = new StabilityAIClient(apiKey);

// Load the image to upscale
var imageBytes = await File.ReadAllBytesAsync("low-res.png");

var images = await client.V1Generation.UpscaleImageAsync(
    engineId: "esrgan-v1-x2plus",
    request: new UpscaleImageRequestBody
    {
        Image = imageBytes,
        Imagename = "low-res.png",
        Width = 2048, // Only specify width OR height, not both
    });

foreach (var image in images)
{
    Console.WriteLine($"Seed: {image.Seed}, Finish reason: {image.FinishReason}");

    var bytes = Convert.FromBase64String(image.Base64!);
    await File.WriteAllBytesAsync("upscaled.png", bytes);
}
```