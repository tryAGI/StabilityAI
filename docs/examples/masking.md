# Masking



This example assumes `using StabilityAI;` is in scope and `apiKey` contains your StabilityAI API key.

```csharp
using var client = new StabilityAIClient(apiKey);

// Load the source image and mask image (must be same dimensions)
var initImageBytes = await File.ReadAllBytesAsync("input.png");
var maskImageBytes = await File.ReadAllBytesAsync("mask.png");

var images = await client.V1Generation.MaskingAsync(
    engineId: "stable-diffusion-v1-6",
    request: new MaskingRequestBody
    {
        TextPrompts =
        [
            new TextPrompt
            {
                Text = "A bright blue sky with fluffy clouds",
                Weight = 1.0f,
            },
        ],
        InitImage = initImageBytes,
        InitImagename = "input.png",
        MaskImage = maskImageBytes,
        MaskImagename = "mask.png",
    });

foreach (var image in images)
{
    Console.WriteLine($"Seed: {image.Seed}, Finish reason: {image.FinishReason}");

    var bytes = Convert.FromBase64String(image.Base64!);
    await File.WriteAllBytesAsync($"masked_{image.Seed}.png", bytes);
}
```