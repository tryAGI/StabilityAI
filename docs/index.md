# StabilityAI

[![Nuget package](https://img.shields.io/nuget/vpre/StabilityAI)](https://www.nuget.org/packages/StabilityAI/)
[![dotnet](https://github.com/tryAGI/StabilityAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/StabilityAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/StabilityAI)](https://github.com/tryAGI/StabilityAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Stability AI OpenAPI specification](https://raw.githubusercontent.com/Stability-AI/rest-api-support/main/generated/spec/merged.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using StabilityAI;

using var client = new StabilityAIClient(apiKey);
```

<!-- EXAMPLES:START -->
### Text to Image


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

### Image to Image


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
                Weight = 1.0f,
            },
        ],
        InitImage = initImageBytes,
        InitImagename = "input.png",
        ImageStrength = 0.35f, // Lower = closer to original, higher = more creative
    });

foreach (var image in images)
{
    Console.WriteLine($"Seed: {image.Seed}, Finish reason: {image.FinishReason}");

    var bytes = Convert.FromBase64String(image.Base64!);
    await File.WriteAllBytesAsync($"output_{image.Seed}.png", bytes);
}
```

### Upscale Image


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

### Masking


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
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/StabilityAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/StabilityAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).