
#nullable enable

namespace StabilityAI
{
    /// <summary>
    /// Guides the image model towards a particular style.
    /// </summary>
    public enum CreateStableImageGenerateUltraRequestStylePreset
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
    public static class CreateStableImageGenerateUltraRequestStylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStableImageGenerateUltraRequestStylePreset value)
        {
            return value switch
            {
                CreateStableImageGenerateUltraRequestStylePreset.x3dModel => "3d-model",
                CreateStableImageGenerateUltraRequestStylePreset.AnalogFilm => "analog-film",
                CreateStableImageGenerateUltraRequestStylePreset.Anime => "anime",
                CreateStableImageGenerateUltraRequestStylePreset.Cinematic => "cinematic",
                CreateStableImageGenerateUltraRequestStylePreset.ComicBook => "comic-book",
                CreateStableImageGenerateUltraRequestStylePreset.DigitalArt => "digital-art",
                CreateStableImageGenerateUltraRequestStylePreset.Enhance => "enhance",
                CreateStableImageGenerateUltraRequestStylePreset.FantasyArt => "fantasy-art",
                CreateStableImageGenerateUltraRequestStylePreset.Isometric => "isometric",
                CreateStableImageGenerateUltraRequestStylePreset.LineArt => "line-art",
                CreateStableImageGenerateUltraRequestStylePreset.LowPoly => "low-poly",
                CreateStableImageGenerateUltraRequestStylePreset.ModelingCompound => "modeling-compound",
                CreateStableImageGenerateUltraRequestStylePreset.NeonPunk => "neon-punk",
                CreateStableImageGenerateUltraRequestStylePreset.Origami => "origami",
                CreateStableImageGenerateUltraRequestStylePreset.Photographic => "photographic",
                CreateStableImageGenerateUltraRequestStylePreset.PixelArt => "pixel-art",
                CreateStableImageGenerateUltraRequestStylePreset.TileTexture => "tile-texture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStableImageGenerateUltraRequestStylePreset? ToEnum(string value)
        {
            return value switch
            {
                "3d-model" => CreateStableImageGenerateUltraRequestStylePreset.x3dModel,
                "analog-film" => CreateStableImageGenerateUltraRequestStylePreset.AnalogFilm,
                "anime" => CreateStableImageGenerateUltraRequestStylePreset.Anime,
                "cinematic" => CreateStableImageGenerateUltraRequestStylePreset.Cinematic,
                "comic-book" => CreateStableImageGenerateUltraRequestStylePreset.ComicBook,
                "digital-art" => CreateStableImageGenerateUltraRequestStylePreset.DigitalArt,
                "enhance" => CreateStableImageGenerateUltraRequestStylePreset.Enhance,
                "fantasy-art" => CreateStableImageGenerateUltraRequestStylePreset.FantasyArt,
                "isometric" => CreateStableImageGenerateUltraRequestStylePreset.Isometric,
                "line-art" => CreateStableImageGenerateUltraRequestStylePreset.LineArt,
                "low-poly" => CreateStableImageGenerateUltraRequestStylePreset.LowPoly,
                "modeling-compound" => CreateStableImageGenerateUltraRequestStylePreset.ModelingCompound,
                "neon-punk" => CreateStableImageGenerateUltraRequestStylePreset.NeonPunk,
                "origami" => CreateStableImageGenerateUltraRequestStylePreset.Origami,
                "photographic" => CreateStableImageGenerateUltraRequestStylePreset.Photographic,
                "pixel-art" => CreateStableImageGenerateUltraRequestStylePreset.PixelArt,
                "tile-texture" => CreateStableImageGenerateUltraRequestStylePreset.TileTexture,
                _ => null,
            };
        }
    }
}