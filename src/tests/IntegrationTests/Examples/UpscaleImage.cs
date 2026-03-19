/*
order: 30
title: Upscale Image
slug: upscale-image
*/

namespace StabilityAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task UpscaleImage()
    {
        using var client = GetAuthenticatedClient();

        //// Load the image to upscale
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
    }
}
