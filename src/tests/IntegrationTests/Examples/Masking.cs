/*
order: 40
title: Masking
slug: masking
*/

namespace StabilityAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Masking()
    {
        using var client = GetAuthenticatedClient();

        //// Load the source image and mask image (must be same dimensions)
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
    }
}
