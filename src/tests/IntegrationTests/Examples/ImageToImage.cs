/*
order: 20
title: Image to Image
slug: image-to-image
*/

namespace StabilityAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ImageToImage()
    {
        using var client = GetAuthenticatedClient();

        //// Load the source image
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
    }
}
