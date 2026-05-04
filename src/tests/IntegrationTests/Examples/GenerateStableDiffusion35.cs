/*
order: 20
title: Generate with Stable Diffusion 3.5
slug: generate-stable-diffusion-35
*/

namespace StabilityAI.IntegrationTests;

public partial class Tests
{
    //// Generate an image with Stability AI's REST v2beta Stable Diffusion 3.5 endpoint.
    //// The response is requested as base64 JSON to keep the example easy to inspect.
    [TestMethod]
    public async Task GenerateStableDiffusion35()
    {
        using var client = GetAuthenticatedClient();

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

        response.Image.Should().NotBeNullOrEmpty();
        response.FinishReason.Should().Be(CreateStableImageGenerateSd3ResponseFinishReason.Success);

        Console.WriteLine($"Seed: {response.Seed}");
        Console.WriteLine($"Base64 bytes: {response.Image.Length}");
    }
}
