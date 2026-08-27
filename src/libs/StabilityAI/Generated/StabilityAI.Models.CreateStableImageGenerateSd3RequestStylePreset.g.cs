
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageGenerateSd3RequestStylePreset
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
    public static class CreateStableImageGenerateSd3RequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateSd3RequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageGenerateSd3RequestStylePreset.x3dModel => "3d-model",
                CreateStableImageGenerateSd3RequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageGenerateSd3RequestStylePreset.Anime => "anime",
                CreateStableImageGenerateSd3RequestStylePreset.Cinematic => "cinematic",
                CreateStableImageGenerateSd3RequestStylePreset.ComicBook => "comic-book",
                CreateStableImageGenerateSd3RequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageGenerateSd3RequestStylePreset.Enhance => "enhance",
                CreateStableImageGenerateSd3RequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageGenerateSd3RequestStylePreset.Isometric => "isometric",
                CreateStableImageGenerateSd3RequestStylePreset.LineArt => "line-art",
                CreateStableImageGenerateSd3RequestStylePreset.LowPoly => "low-poly",
                CreateStableImageGenerateSd3RequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageGenerateSd3RequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageGenerateSd3RequestStylePreset.Origami => "origami",
                CreateStableImageGenerateSd3RequestStylePreset.Photographic => "photographic",
                CreateStableImageGenerateSd3RequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageGenerateSd3RequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateSd3RequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageGenerateSd3RequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageGenerateSd3RequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageGenerateSd3RequestStylePreset.Anime,
                "cinematic" => CreateStableImageGenerateSd3RequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageGenerateSd3RequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageGenerateSd3RequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageGenerateSd3RequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageGenerateSd3RequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageGenerateSd3RequestStylePreset.Isometric,
                "line-art" => CreateStableImageGenerateSd3RequestStylePreset.LineArt,
                "low-poly" => CreateStableImageGenerateSd3RequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageGenerateSd3RequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageGenerateSd3RequestStylePreset.NeonPunk,
                "origami" => CreateStableImageGenerateSd3RequestStylePreset.Origami,
                "photographic" => CreateStableImageGenerateSd3RequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageGenerateSd3RequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageGenerateSd3RequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}