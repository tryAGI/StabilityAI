
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateV2alphaGenerationStableImageUpscaleRequestStylePreset
    {
        /// <summary>
        ///
        /// </summary>
        x3dModel,
        /// <summary>
        ///
        /// </summary>
        AnalogFilm,
        /// <summary>
        ///
        /// </summary>
        Anime,
        /// <summary>
        ///
        /// </summary>
        Cinematic,
        /// <summary>
        ///
        /// </summary>
        ComicBook,
        /// <summary>
        ///
        /// </summary>
        DigitalArt,
        /// <summary>
        ///
        /// </summary>
        Enhance,
        /// <summary>
        ///
        /// </summary>
        FantasyArt,
        /// <summary>
        ///
        /// </summary>
        Isometric,
        /// <summary>
        ///
        /// </summary>
        LineArt,
        /// <summary>
        ///
        /// </summary>
        LowPoly,
        /// <summary>
        ///
        /// </summary>
        ModelingCompound,
        /// <summary>
        ///
        /// </summary>
        NeonPunk,
        /// <summary>
        ///
        /// </summary>
        Origami,
        /// <summary>
        ///
        /// </summary>
        Photographic,
        /// <summary>
        ///
        /// </summary>
        PixelArt,
        /// <summary>
        ///
        /// </summary>
        TileTexture,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateV2alphaGenerationStableImageUpscaleRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateV2alphaGenerationStableImageUpscaleRequestStylePreset value)
        {
            return value switch
            {
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.x3dModel => "3d-model",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.AnalogFilm => "analog-film",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Anime => "anime",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Cinematic => "cinematic",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.ComicBook => "comic-book",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.DigitalArt => "digital-art",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Enhance => "enhance",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.FantasyArt => "fantasy-art",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Isometric => "isometric",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.LineArt => "line-art",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.LowPoly => "low-poly",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.NeonPunk => "neon-punk",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Origami => "origami",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Photographic => "photographic",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.PixelArt => "pixel-art",
                CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateV2alphaGenerationStableImageUpscaleRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.x3dModel,
                "analog-film" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.AnalogFilm,
                "anime" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Anime,
                "cinematic" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Cinematic,
                "comic-book" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.ComicBook,
                "digital-art" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.DigitalArt,
                "enhance" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Enhance,
                "fantasy-art" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.FantasyArt,
                "isometric" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Isometric,
                "line-art" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.LineArt,
                "low-poly" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.LowPoly,
                "modeling-compound" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.NeonPunk,
                "origami" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Origami,
                "photographic" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.Photographic,
                "pixel-art" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.PixelArt,
                "tile-texture" => CreateV2alphaGenerationStableImageUpscaleRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}